using System.Collections.Generic;
using System.Linq;
using GuitarTabFinder.Interfaces;

namespace GuitarTabFinder.TabsProcessor
{
    public class TabsHandler
    {
        public static ITab GetMostVotedTab(IEnumerable<ITab> tabs, TabType type)
        {
            var tabsList = tabs.Where(tab => tab.Type == type).ToList();

            tabsList.Sort((x, y) => x.NumberOfVotes.CompareTo(y.NumberOfVotes));

            return tabsList.Last();
        }

        public static ITab GetBestRatedTab(IEnumerable<ITab> tabs, TabType type)
        {
            var tabsList = tabs.Where(tab => tab.Type == type).ToList();

            tabsList.Sort((x, y) => x.Rating.CompareTo(y.Rating));

            return tabsList.Last();
        }
    }
}
