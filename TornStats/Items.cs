using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("buy_price")]
        public long BuyPrice { get; set; }

        [JsonProperty("sell_price")]
        public int SellPrice { get; set; }

        [JsonProperty("market_value")]
        public long MarketValue { get; set; }

        [JsonProperty("circulation")]
        public int Circulation { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
