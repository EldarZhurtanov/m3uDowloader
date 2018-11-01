using System;

namespace m3uDownload.DLL
{
    public class Song : IWebSong, ILocalSong
    {

        public string Performer { get; set; }
        public string Title     { get; set; }
        public int    Number    { get; set; }
        public string WebLink   { get; set; }
        public string LocalPath { get; set; }

        public Song(string performer, string title, int number, string webLink = null, string localDir = null)
        {
            Performer = performer;
            Title     = title;
            Number    = number;
            WebLink   = webLink;
            LocalPath = localDir;
        }
    }
}
