using System.Web;
using GuitarTabFinder.UltimateGuitar;
using GuitarTabFinder.UltimateGuitar.Models;
using GuitarTabFinder.Web.AppsettingsModels;
using GuitarTabFinder.Web.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GuitarTabFinder.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UltimateGuitarController : ControllerBase
    {
        private readonly string _ultimateGuitarUrl;
        public UltimateGuitarController(IOptions<UltimateGuitarAppSettings> op)
        {
            _ultimateGuitarUrl = op.Value.SearchUrl;
        }

        [HttpGet("/mostvoted/{songTitle}")]
        public UltimateGuitarTabModel GetMostVotedTab(string songTitle)
        {
            if (string.IsNullOrEmpty(songTitle))
                return null;

            var ugManager = new UltimateGuitarManager();

            var bestRatedTab = ugManager.FindMostVotedTab(_ultimateGuitarUrl + HttpUtility.UrlEncode(songTitle));

            return bestRatedTab as UltimateGuitarTabModel;
        }

        [HttpGet("/bestrated/{songTitle}")]
        public UltimateGuitarTabModel GetBestRatedTab(string songTitle)
        {
            if (string.IsNullOrEmpty(songTitle))
                return null;

            var ugManager = new UltimateGuitarManager();

            var bestRatedTab = ugManager.FindBestRatedTab(_ultimateGuitarUrl + HttpUtility.UrlEncode(songTitle));

            return bestRatedTab as UltimateGuitarTabModel;
        }
    }
}