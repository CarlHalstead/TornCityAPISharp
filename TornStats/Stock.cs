using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Stock
    {
        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("rrp")]
        public int RRP { get; set; }
    }
}
