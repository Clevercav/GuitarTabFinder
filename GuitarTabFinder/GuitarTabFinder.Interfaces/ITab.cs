using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTabFinder.Interfaces
{
    public interface ITab
    {
        string SongName { get; set; }
        string Url { get; set; }
        string Artist { get; set; }
        int NumberOfVotes { get; set; }
        double Rating { get; set; }
        TabType Type { get; set; }
    }
}
