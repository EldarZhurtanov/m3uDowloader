using System;
using System.IO;

namespace m3uDownload.DLL
{
    public static class Tagger
    {
        public static void TagFile(ILocalSong song, bool setTagNumber = false)
        {
            if (System.IO.File.Exists(song.LocalPath))
            {
                var tag = TagLib.File.Create(song.LocalPath);
                tag.Tag.Performers = null;
                tag.Tag.Performers = new string[1];
                tag.Tag.Performers[0] = song.Performer;
                tag.Tag.Title = song.Title;
                if (setTagNumber)
                    tag.Tag.Track = Convert.ToUInt32(song.Number);
                tag.Save();
            }
            else
                throw new FileNotFoundException("Трек \"" + song.LocalPath + "\" не найден!");
        }
    }
}
