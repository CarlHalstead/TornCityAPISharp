using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class StockItem
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("rrp")]
        public int Rrp { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("in_stock")]
        public int InStock { get; set; }

        [JsonProperty("on_order")]
        public int OnOrder { get; set; }

        [JsonProperty("sold_amount")]
        public int SoldAmount { get; set; }

        [JsonProperty("sold_worth")]
        public int SoldWorth { get; set; }
    }
}
