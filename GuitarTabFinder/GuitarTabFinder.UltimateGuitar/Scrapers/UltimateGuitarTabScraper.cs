using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuitarTabFinder.Interfaces;
using GuitarTabFinder.UltimateGuitar.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace GuitarTabFinder.UltimateGuitar.Scrapers
{
    public class UltimateGuitarTabScraper : ITabScraper
    {
        public IEnumerable<ITab> ScrapeTabs(string guitarTabUrl)
        {
            var web = new HtmlWeb();
            var html = web.Load(guitarTabUrl);

            var dataContent = html.DocumentNode
                .SelectSingleNode("//div[@data-content]")
                .Attributes["data-content"].Value;

            var dataContentDecoded = HttpUtility.HtmlDecode(dataContent);

            var ugJsonData = JsonConvert.DeserializeObject<UltimateGuitarJsonData>(dataContentDecoded);

            var tabs = new List<ITab>();

            var publicTabs = ugJsonData.store.page.data.results.Where(tab => tab.tab_access_type?.ToUpper() == "PUBLIC");

            tabs.AddRange(publicTabs.Select(
                result => new UltimateGuitarTabModel()
                    {
                        Artist = result.artist_name,
                        NumberOfVotes = result.votes,
                        Rating = result.rating,
                        SongName = result.song_name,
                        Type = HandleType(result.type),
                        Url = result.tab_url
                    }
                ));

            return tabs;
        }

        private TabType HandleType(string type)
        {
            switch (type.ToUpper())
            {
                case "TABS":
                    return TabType.Tab;
                case "GUITAR PRO":
                    return TabType.Pro;
                case "CHORDS":
                    return TabType.Chords;
                case "POWER":
                    return TabType.Power;
            }
            return TabType.Chords;
        }
    }
}
