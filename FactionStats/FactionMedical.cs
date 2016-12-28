using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionMedical:IFactionStatistics
    {
        /// <summary>
        /// Medical items in the faction
        /// </summary>
        [JsonProperty("medical")]
        public List<Item> Medical { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.medical.ToString();
        }
    }
}
