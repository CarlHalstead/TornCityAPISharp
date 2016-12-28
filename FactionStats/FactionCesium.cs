using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.FactionStats
{
    public class FactionCesium :IFactionStatistics
    {
        /// <summary>
        /// Celium in the faction
        /// </summary>
        [JsonProperty("cesium")]
        public List<Item> Cesium { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.cesium.ToString();
        }
    }
}
