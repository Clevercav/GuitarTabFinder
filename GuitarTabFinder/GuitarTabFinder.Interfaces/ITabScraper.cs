using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTabFinder.Interfaces
{
    public interface ITabScraper
    {
        IEnumerable<ITab> ScrapeTabs(string guitarTabUrl);
    }
}
