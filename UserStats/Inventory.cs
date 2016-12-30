using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Inventory
    {
        [JsonProperty("ID")]
        public int ItemID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("equipped")]
        public int Equipped { get; set; }

        [JsonProperty("market_price")]
        public int MarketPrice { get; set; }
    }
}
