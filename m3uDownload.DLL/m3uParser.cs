using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using M3U.NET;

namespace m3uDownload.DLL
{
    public class m3uParser
    {
        public IEnumerable<IWebSong> Parse(string m3uPlaylistPath)
        {
            if (File.Exists(m3uPlaylistPath))
            {
                var m3uFile = new M3UFile(new FileInfo(m3uPlaylistPath));
                var m3uMediaItems = m3uFile.Files;

                List<IWebSong> songs = new List<IWebSong>();
                foreach (var item in m3uMediaItems)
                {
                    var lastSong = ParseMediaItem(item);
                    lastSong.Number = songs.Count + 1;
                    songs.Add(lastSong);
                }
                return songs;
            }
            else
                throw new FileNotFoundException("Указанный m3u - плейлист не существует!");
        }

        private IWebSong ParseMediaItem(MediaItem item)
        {
            string[] separator = new string [] { " - " };
            string[] splited = item.Inf.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
            return new Song(splited[0], splited[1], 1, item.Location);
        }
    }
}
