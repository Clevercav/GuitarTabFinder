using System.Collections.Generic;

namespace GuitarTabFinder.UltimateGuitar.Models
{
    class GFG : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }

            // CompareTo() method 
            return x.CompareTo(y);

        }
    }

    public class UltimateGuitarJsonData
    {
        public Config config { get; set; }
        public Store store { get; set; }
        public object[] globalHelpers { get; set; }
        public Helpers helpers { get; set; }
        public Cmp cmp { get; set; }
        public Bidding bidding { get; set; }
    }

    public class Config
    {
        public object abVariation { get; set; }
        public object abVariation2 { get; set; }
        public object abVariation3 { get; set; }
        public object[] abTestAccountVariation { get; set; }
        public Experiments experiments { get; set; }
        public string urlFacebook { get; set; }
        public string urlGoogle { get; set; }
        public string urlApple { get; set; }
        public string main_server { get; set; }
        public string ps_server { get; set; }
        public string static_server { get; set; }
        public string statik_cache { get; set; }
        public string staticPrefix { get; set; }
        public long time { get; set; }
        public bool isGDPRAvailable { get; set; }
        public bool isCcpaAvailable { get; set; }
        public User user { get; set; }
        public bool isOfficeUser { get; set; }
        public bool isOfficeRequest { get; set; }
        public bool isWebp { get; set; }
        public bool isBot { get; set; }
        public bool is_mobile { get; set; }
        public bool is_tablet { get; set; }
        public bool isThemeMobile { get; set; }
        public bool isIe { get; set; }
        public Socketcluster socketCluster { get; set; }
        public int metricaId { get; set; }
        public string captcha_id { get; set; }
        public string stripeApiKey { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string browserName { get; set; }
        public string browser { get; set; }
        public string urlUgProAppIcon { get; set; }
        public bool withCritical { get; set; }
        public bool isJobEnabled { get; set; }
        public Analytics analytics { get; set; }
        public Braintree braintree { get; set; }
        public Vimeo vimeo { get; set; }
        public int hasStaticCache { get; set; }
        public Jinba jinba { get; set; }
        public Metricaparams metricaParams { get; set; }
    }

    public class Experiments
    {
        public bool isPianoChordGroup { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string iq { get; set; }
        public bool contributorPower { get; set; }
    }

    public class Socketcluster
    {
        public string serviceKey { get; set; }
        public string channelPrefix { get; set; }
        public string hostname { get; set; }
        public int port { get; set; }
        public string channelName { get; set; }
    }

    public class Analytics
    {
        public string userTrackerId { get; set; }
    }

    public class Braintree
    {
        public string environment { get; set; }
        public string tokenizationKey { get; set; }
        public string paypalClientId { get; set; }
    }

    public class Vimeo
    {
        public string baseImagePath { get; set; }
    }

    public class Jinba
    {
        public object[] customTimings { get; set; }
        public string appLabel { get; set; }
        public string appLabelExp { get; set; }
    }

    public class Metricaparams
    {
        public int rights { get; set; }
        public string u_id { get; set; }
        public string auth { get; set; }
        public int is_registered { get; set; }
    }

    public class Store
    {
        public Page page { get; set; }
        public I18n i18n { get; set; }
        public User1 user { get; set; }
        public Notifications notifications { get; set; }
        public object[] forms { get; set; }
        public string theme { get; set; }
        public Commentform commentForm { get; set; }
        public int isUgOffice { get; set; }
        public Ugsearch ugSearch { get; set; }
        public object sponsorsFooter { get; set; }
        public Takeover takeover { get; set; }
        public bool interstitial { get; set; }
        public object[] customAlerts { get; set; }
    }

    public class Page
    {
        public Template template { get; set; }
        public Data data { get; set; }
        public Header_Bidding header_bidding { get; set; }
    }

    public class Template
    {
        public string module { get; set; }
        public string controller { get; set; }
        public string action { get; set; }
        public string reactAction { get; set; }
    }

    public class Data
    {
        public string search_query { get; set; }
        public string search_query_type { get; set; }
        public int results_count { get; set; }
        public Result[] results { get; set; }
        public Pagination pagination { get; set; }
        public string spellcheck { get; set; }
        public bool not_found { get; set; }
        public Order[] order { get; set; }
        public Filters filters { get; set; }
    }

    public class Pagination
    {
        public int total { get; set; }
        public int current { get; set; }
    }

    public class Filters
    {
        public Band[] bands { get; set; }
        public Type[] types { get; set; }
        public Current_Filters current_filters { get; set; }
    }

    public class Current_Filters
    {
        public string[] types { get; set; }
    }

    public class Band
    {
        public string name { get; set; }
        public string url { get; set; }
        public string count { get; set; }
        public string search_url { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }
        public object count { get; set; }
    }

    public class Result
    {
        public string artist_name { get; set; }
        public string artist_url { get; set; }
        public string song_name { get; set; }
        public string marketing_type { get; set; }
        public string tab_url { get; set; }
        public object device { get; set; }
        public string app_link { get; set; }
        public Highlight highlight { get; set; }
        public string tracks { get; set; }
        public string duration { get; set; }
        public float rating { get; set; }
        public int votes { get; set; }
        public int id { get; set; }
        public int song_id { get; set; }
        public int artist_id { get; set; }
        public string type { get; set; }
        public string part { get; set; }
        public int version { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public int preset_id { get; set; }
        public string tab_access_type { get; set; }
        public int tp_version { get; set; }
        public string tonality_name { get; set; }
        public string version_description { get; set; }
        public int verified { get; set; }
        public Recording recording { get; set; }
    }

    public class Highlight
    {
        public int[][] song_name { get; set; }
        public object[] artist_name { get; set; }
    }

    public class Recording
    {
        public int is_acoustic { get; set; }
        public string tonality_name { get; set; }
        public Performance performance { get; set; }
        public object[] recording_artists { get; set; }
    }

    public class Performance
    {
        public string name { get; set; }
        public object serie { get; set; }
        public Venue venue { get; set; }
        public int date_start { get; set; }
        public int date_end { get; set; }
        public int cancelled { get; set; }
        public string type { get; set; }
        public string comment { get; set; }
        public object[] video_urls { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public Area area { get; set; }
    }

    public class Area
    {
        public string name { get; set; }
        public Country country { get; set; }
    }

    public class Country
    {
        public string name_english { get; set; }
    }

    public class Order
    {
        public string name { get; set; }
        public bool is_current { get; set; }
        public string url { get; set; }
    }

    public class Header_Bidding
    {
        public string page_type { get; set; }
        public Ad_Units[] ad_units { get; set; }
    }

    public class Ad_Units
    {
        public string code { get; set; }
        public string dfpCode { get; set; }
        public int[][] sizes { get; set; }
        public string placementId { get; set; }
        public string layoutPlacement { get; set; }
        public int appnexusPlacementId { get; set; }
        public string mediaType { get; set; }
        public Bid[] bids { get; set; }
        public bool primis { get; set; }
    }

    public class Bid
    {
        public string bidder { get; set; }
        public Params _params { get; set; }
    }

    public class Params
    {
        public int placementId { get; set; }
        public Keywords keywords { get; set; }
        public string mid { get; set; }
        public string id { get; set; }
        public string siteID { get; set; }
        public int[] size { get; set; }
        public string siteId { get; set; }
        public string delDomain { get; set; }
        public string unit { get; set; }
        public string publisherId { get; set; }
        public string adSlot { get; set; }
        public string accountId { get; set; }
        public string zoneId { get; set; }
    }

    public class Keywords
    {
        public string is_refresh { get; set; }
        public string subcat { get; set; }
    }

    public class I18n
    {
    }

    public class User1
    {
        public int id { get; set; }
        public string avatarUrl { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int usergroupid { get; set; }
        public Contributor contributor { get; set; }
        public int iq { get; set; }
        public int tabsCount { get; set; }
        public int playlistCount { get; set; }
        public int messagesCount { get; set; }
        public object[] rights { get; set; }
        public int joinDate { get; set; }
        public string user_status { get; set; }
    }

    public class Contributor
    {
        public bool isContributor { get; set; }
        public int first_tab { get; set; }
    }

    public class Notifications
    {
        public int count_new { get; set; }
        public object[] data { get; set; }
        public int giveaway_id { get; set; }
        public Texts texts { get; set; }
    }

    public class Texts
    {
        public string markAll { get; set; }
        public string settings { get; set; }
        public string thanksForVote { get; set; }
    }

    public class Commentform
    {
        public int is_new { get; set; }
    }

    public class Ugsearch
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Takeover
    {
        public Item[] items { get; set; }
        public int debug_takeover_id { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public int start_at { get; set; }
        public int end_at { get; set; }
        public int date_updated { get; set; }
        public string[] county { get; set; }
        public string[] page_type { get; set; }
        public string[] platform { get; set; }
        public Track track { get; set; }
        public Style style { get; set; }
        public Extensions extensions { get; set; }
        public string image_right { get; set; }
        public string image_left { get; set; }
    }

    public class Track
    {
        public string pixel { get; set; }
        public string yandex { get; set; }
        public string click_left { get; set; }
        public string click_right { get; set; }
    }

    public class Style
    {
        public string background { get; set; }
    }

    public class Extensions
    {
        public string image_left { get; set; }
        public string image_right { get; set; }
    }

    public class Helpers
    {
        public Typehelper typeHelper { get; set; }
    }

    public class Typehelper
    {
        public Short _short { get; set; }
        public Filter filter { get; set; }
        public Full full { get; set; }
    }

    public class Short
    {
        public string Official { get; set; }
        public string Chords { get; set; }
        public string Tabs { get; set; }
        public string Pro { get; set; }
        public string Power { get; set; }
        public string BassTabs { get; set; }
        public string DrumTabs { get; set; }
        public string Video { get; set; }
        public string UkuleleChords { get; set; }
        public string TabPro { get; set; }
        public string ChordPro { get; set; }
    }

    public class Filter
    {
        public string Official { get; set; }
        public string Chords { get; set; }
        public string Tabs { get; set; }
        public string Pro { get; set; }
        public string Power { get; set; }
        public string BassTabs { get; set; }
        public string DrumTabs { get; set; }
        public string Video { get; set; }
        public string UkuleleChords { get; set; }
        public string TabPro { get; set; }
        public string ChordPro { get; set; }
    }

    public class Full
    {
        public string Official { get; set; }
        public string Chords { get; set; }
        public string Tabs { get; set; }
        public string Pro { get; set; }
        public string Power { get; set; }
        public string BassTabs { get; set; }
        public string DrumTabs { get; set; }
        public string Video { get; set; }
        public string UkuleleChords { get; set; }
        public string TabPro { get; set; }
        public string ChordPro { get; set; }
    }

    public class Cmp
    {
        public string setConsentUrl { get; set; }
    }

    public class Bidding
    {
        public Analytics1 analytics { get; set; }
        public Refresh refresh { get; set; }
        public float minRefreshCpm { get; set; }
        public float cpmFloor { get; set; }
        public int timeout { get; set; }
        public int refreshTimeout { get; set; }
        public int dfpId { get; set; }
        public Unit[] units { get; set; }
        public Pricegranularity[] priceGranularity { get; set; }
        public bool dynamicLoad { get; set; }
        public bool disableAdx { get; set; }
        public bool apstagEnabled { get; set; }
        public bool isGDPRAvailable { get; set; }
        public bool isForensiqDisabled { get; set; }
        public bool isShowOnTap { get; set; }
    }

    public class Analytics1
    {
        public string logUrl { get; set; }
        public string pageType { get; set; }
        public string region { get; set; }
        public string device { get; set; }
        public string variation { get; set; }
        public bool hasHardRefresh { get; set; }
    }

    public class Refresh
    {
        public int limit { get; set; }
        public int maxVisibleTime { get; set; }
        public int delay { get; set; }
        public int delayDeviation { get; set; }
        public bool enabled { get; set; }
        public bool hasHardRefresh { get; set; }
        public string[] availableBidders { get; set; }
        public bool ignoreChangePageVisibility { get; set; }
    }

    public class Unit
    {
        public string code { get; set; }
        public string dfpCode { get; set; }
        public int[][] sizes { get; set; }
        public string placementId { get; set; }
        public string layoutPlacement { get; set; }
        public int appnexusPlacementId { get; set; }
        public string mediaType { get; set; }
        public Bid1[] bids { get; set; }
        public bool primis { get; set; }
    }

    public class Bid1
    {
        public string bidder { get; set; }
        public Params1 _params { get; set; }
    }

    public class Params1
    {
        public int placementId { get; set; }
        public Keywords1 keywords { get; set; }
        public string mid { get; set; }
        public string id { get; set; }
        public string siteID { get; set; }
        public int[] size { get; set; }
        public string siteId { get; set; }
        public string delDomain { get; set; }
        public string unit { get; set; }
        public string publisherId { get; set; }
        public string adSlot { get; set; }
        public string accountId { get; set; }
        public string zoneId { get; set; }
    }

    public class Keywords1
    {
        public string is_refresh { get; set; }
        public string subcat { get; set; }
    }

    public class Pricegranularity
    {
        public int precision { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public float increment { get; set; }
    }

}
