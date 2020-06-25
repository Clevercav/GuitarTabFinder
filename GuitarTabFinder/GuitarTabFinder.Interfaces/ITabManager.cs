using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTabFinder.Interfaces
{
    public interface ITabManager
    {
        ITab FindBestRatedTab(string url);
        ITab FindMostVotedTab(string url);
    }
}
