using GuitarTabFinder.Interfaces;
using GuitarTabFinder.TabsProcessor;
using GuitarTabFinder.UltimateGuitar;
using GuitarTabFinder.UltimateGuitar.Models;
using GuitarTabFinder.UltimateGuitar.Scrapers;

namespace GuitarTabFinder.Web.Managers
{
    public class UltimateGuitarManager : ITabManager
    {
        public ITab FindBestRatedTab(string url)
        {
            var scraper = new UltimateGuitarTabScraper();
            var tabs = scraper.ScrapeTabs(url);

            var bestRatedTab = TabsHandler.GetBestRatedTab(tabs, TabType.Tab);

            return bestRatedTab;
        }

        public ITab FindMostVotedTab(string url)
        {
            var scraper = new UltimateGuitarTabScraper();
            var tabs = scraper.ScrapeTabs(url);

            var mostVotedTab = TabsHandler.GetMostVotedTab(tabs, TabType.Tab);

            return mostVotedTab;
        }
    }
}
