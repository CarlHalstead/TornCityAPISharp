using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.MarketStats
{
    public class Point
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }
    }
}
