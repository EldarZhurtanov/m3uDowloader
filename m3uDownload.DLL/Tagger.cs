using System;
using System.IO;

namespace m3uDownload.DLL
{
    public static class Tagger
    {
        public static void TagFile(ILocalSong song)
        {
            if (System.IO.File.Exists(song.LocalPath))
            {
                var tag = TagLib.File.Create(song.LocalPath);
                tag.Tag.Performers = null;
                tag.Tag.Performers = new string[1];
                tag.Tag.Performers[0] = song.Performer;
                tag.Tag.Title = song.Title;
                tag.Tag.Track = Convert.ToUInt32(song.Number);
                tag.Save();
            }
            else
                throw new FileNotFoundException("Трек по пути \"" + song.LocalPath + "\" не найден!");
        }
    }
}
