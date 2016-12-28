using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionBoosters : IFactionStatistics
    {
        /// <summary>
        /// Boosters in the faction
        /// </summary>
        [JsonProperty("boosters")]
        public List<Item> Boosters { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.boosters.ToString();
        }
    }
}
