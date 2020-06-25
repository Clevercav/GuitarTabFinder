using GuitarTabFinder.Interfaces;

namespace GuitarTabFinder.UltimateGuitar.Models
{
    public class UltimateGuitarTabModel : ITab
    {
        public string SongName { get; set; }
        public string Url { get; set; }
        public string Artist { get; set; }
        public int NumberOfVotes { get; set; }
        public double Rating { get; set; }
        public TabType Type { get; set; }
    }
}
