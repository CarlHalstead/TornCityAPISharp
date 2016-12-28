using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionTemporary: IFactionStatistics
    {
        
        /// <summary>
        /// Temporary items in the faction
        /// </summary>
        [JsonProperty("temporary")]
        public List<Item> Temporary { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.temporary.ToString();
        }
    }
}
