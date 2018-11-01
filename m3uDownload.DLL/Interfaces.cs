using System;

namespace m3uDownload.DLL
{
    public interface ISong
    {
        string Performer { get; set; }
        string Title     { get; set; }
        int    Number    { get; set; }
    }

    public interface IWebSong : ISong
    {
        string WebLink   { get; set; }
    }

    public interface ILocalSong : ISong
    {
        string LocalPath { get; set; }
    }
}
