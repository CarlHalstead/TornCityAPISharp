using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.MarketStats
{
    public class MarketBazaar : IMarketStatistics
    {
        [JsonProperty("bazaar")]
        public Dictionary<long,Item> BazaarItems { get; set; }

        public string GetMethodName()
        {
            return MarketMethods.bazaar.ToString();
        }
    }
}
