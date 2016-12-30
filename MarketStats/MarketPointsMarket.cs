using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.MarketStats
{
    public class MarketPointsMarket : IMarketStatistics
    {
        [JsonProperty("pointsmarket")]
        public Dictionary<long, Point> PointsMarket { get; set; }

        public string GetMethodName()
        {
            return MarketMethods.pointsmarket.ToString();
        }
    }
}
