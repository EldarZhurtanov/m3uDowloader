using System;
using System.IO;
using System.Collections.Generic;

namespace m3uDownload.DLL
{
    public static class Tagger
    {
        public static void TagFile(ILocalSong song, bool setTagNumber = false)
        {
            if (System.IO.File.Exists(song.LocalPath))
            {
                var tag = TagLib.File.Create(song.LocalPath);
                
                var newPerformers = new List<string>();
                newPerformers.Add(song.Performer);
                tag.Tag.Performers = newPerformers.ToArray();

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
