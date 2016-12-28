using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionDrugs: IFactionStatistics
    {
        /// <summary>
        /// Drugs in the faction
        /// </summary>
        [JsonProperty("drugs")]
        public List<Item> Drugs { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.drugs.ToString();
        }
    }
}
