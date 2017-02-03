using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.FactionStats
{
    public class FactionUpgrades : IFactionStatistics
    {
        /// <summary>
        /// List of attack news
        /// </summary>
        [JsonProperty("upgrades")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Upgrade> Upgrades { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.upgrades.ToString();
        }
    }

    public class Upgrade
    {
        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("ability")]
        public string Ability { get; set; }
    }
}
