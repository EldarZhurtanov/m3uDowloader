using System;
using System.Collections.Generic;
using System.Net;
using System.ComponentModel;
using System.Linq;

namespace m3uDownload.DLL
{
    public class Downloader

    {
        private string _m3uPlaylistPath = null;
        private IEnumerable<Song> _playlist = new Queue<Song>();

        public string M3uPlaylistPath { get => _m3uPlaylistPath; set => _m3uPlaylistPath = SetM3UPlaylistPath(value); }
        public string SaveDirectory { get; set; } = null;
        public uint CountOfParallelDownload { get; set; } = 1;
        public bool NumberInTheTag { get; set; } = false;
        public bool NumberInTheTitle { get; set; } = false;
        public uint CountOfTrackOnPlaylist { get; private set; } = 0;
        public event AsyncCompletedEventHandler DownloadOneSongCompleted;

        public void AsyncDownload()
        {
            if (_m3uPlaylistPath == null)
                throw new ArgumentNullException("m3u плейлист не указан!");
            if(SaveDirectory == null)
                throw new ArgumentNullException("Путь сохранения не указан!");

            foreach (var item in (_playlist.ToList()))
                SetLocalPath(item);

            for(int i = 0; i < CountOfParallelDownload; i++)
            {
                DownloadSongClient newClient = new DownloadSongClient();
                newClient.DownloadSongCompleted += AsyncCompletedSong;
                newClient.Download((_playlist as Queue<Song>).Dequeue());
            }
        }

        private void AsyncCompletedSong(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Cancelled == false && e.Error == null)
                Tagger.TagFile((sender as DownloadSongClient).LastDownloadedSong, NumberInTheTag);

            DownloadOneSongCompleted(sender, e);

            if ((_playlist as Queue<Song>).Count != 0)
            {
                (sender as DownloadSongClient).Download((_playlist as Queue<Song>).Dequeue());
            }
        }
        public void SetDefaultSettings()
        {
            _m3uPlaylistPath = null;
            _playlist = new Queue<Song>();
            SaveDirectory = null;
            NumberInTheTag = false;
            NumberInTheTitle = false;
            CountOfParallelDownload = 1;
            CountOfTrackOnPlaylist = 0;
        }
        private string SetM3UPlaylistPath(string m3uPath)
        {
            List<IWebSong> playlist = m3uParser.Parse(m3uPath).ToList();

            CountOfTrackOnPlaylist = Convert.ToUInt32(playlist.Count);

            foreach (var item in playlist)
                (_playlist as Queue<Song>).Enqueue(item as Song);

            return m3uPath;
        }
        private void SetLocalPath(ILocalSong song)
        {
            song.LocalPath = SaveDirectory + @"/";
            if (NumberInTheTitle)
                song.LocalPath += song.Number + ". ";
            song.LocalPath += song.Performer + " - " + song.Title + ".mp3";
        }
    }

    public class DownloadSongClient
    {
        private WebClient _webClient;
        public Song LastDownloadedSong = null;
        public event AsyncCompletedEventHandler DownloadSongCompleted;

        public DownloadSongClient()
        {
            _webClient = new WebClient();
            _webClient.DownloadFileCompleted += AsyncCompletedSubscriber;
        }
        public void Download(Song downloadedSong)
        {
            LastDownloadedSong = downloadedSong;
            _webClient.DownloadFileAsync(new Uri(downloadedSong.WebLink), downloadedSong.LocalPath);
        }

        private void AsyncCompletedSubscriber(object sender, AsyncCompletedEventArgs e)
        {
            DownloadSongCompleted(this, e);
        }
    }
}
