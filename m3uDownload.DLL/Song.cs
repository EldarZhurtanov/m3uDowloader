using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m3uDownload.DLL
{
    public class Song : IWebSong, ILocalSong
    {

        public string Performer { get; set; }
        public string Title     { get; set; }
        public string Number    { get; set; }
        public string WebLink   { get; set; }
        public string LocalDir  { get; set; }

        public Song(string performer, string title, string number, string webLink = null, string localDir = null)
        {
            Performer = performer;
            Title = title;
            Number = number;
            WebLink = webLink;
            LocalDir = localDir;
        }
    }
}
