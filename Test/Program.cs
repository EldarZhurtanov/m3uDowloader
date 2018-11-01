using m3uDownload.DLL;
using System;
using System.ComponentModel;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            m3uDownload.DLL.Downloader downloader = new Downloader();
            downloader.M3uPlaylistPath = @"D:\Downloads\Для ВК 2018-11-01 19-59.m3u";
            downloader.SaveDirectory = @"D:\Music\M3U\M";
            downloader.NumberInTheTitle = true;
            downloader.NumberInTheTag = true;
            downloader.CountOfParallelDownload = 10;
            while(true)
                System.Threading.Thread.Sleep(1);
        }
        void AsyncCompletedEventHandler(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("\"" 
                + (sender as DownloadSongClient).LastDownloadedSong.LocalPath 
                + "\" - загружено");
        }
    }
}
