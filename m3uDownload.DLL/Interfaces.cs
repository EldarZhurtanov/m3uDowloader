using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m3uDownload.DLL
{
    public interface ISong
    {
        string Performer { get; set; }
        string Title     { get; set; }
        string Number    { get; set; }
    }

    public interface IWebSong : ISong
    {
        string WebLink   { get; set; }
    }

    public interface ILocalSong : ISong
    {
        string LocalDir  { get; set; }
    }
}
