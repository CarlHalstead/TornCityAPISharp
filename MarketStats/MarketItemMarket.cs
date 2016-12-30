using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.MarketStats
{
    public class MarketItemMarket : IMarketStatistics
    {
        [JsonProperty("itemmarket")]
        public Dictionary<long,Item> ItemMarket { get; set; }

        public string GetMethodName()
        {
            return MarketMethods.itemmarket.ToString();
        }
    }
}
