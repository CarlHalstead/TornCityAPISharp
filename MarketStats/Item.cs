using Newtonsoft.Json;

namespace TornCityAPISharp.MarketStats
{
    public class Item
    {
        [JsonProperty("cost")]
        public int cost { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
