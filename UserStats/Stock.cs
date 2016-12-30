using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Stock
    {
        [JsonProperty("stock_id")]
        public int StockId { get; set; }

        [JsonProperty("shares")]
        public int Shares { get; set; }

        [JsonProperty("bought_price")]
        public double boughtPrice { get; set; }

        [JsonProperty("time_bought")]
        public int TimeBought { get; set; }

        [JsonProperty("time_listed")]
        public int TimeListed { get; set; }
    }
}
