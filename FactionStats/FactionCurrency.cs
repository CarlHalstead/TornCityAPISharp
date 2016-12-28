

using System;
using Newtonsoft.Json;

namespace TornCityAPISharp.FactionStats
{
    public class FactionCurrency: IFactionStatistics
    {
        /// <summary>
        /// Faction Id
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// Points in the faction
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// Money in the faction 
        /// </summary>
        [JsonProperty("money")]
        public int Money { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.currency.ToString();
        }
    }
}
