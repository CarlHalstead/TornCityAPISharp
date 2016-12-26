using System.Collections.Generic;
using Newtonsoft.Json;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.FactionStats
{
    public class FactionBasic
    {
        /// <summary>
        /// Faction Id
        /// </summary>
        [JsonProperty("ID")]
        public long FactionID { get; set; }

        /// <summary>
        /// Faction name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Leader of the faction ID
        /// </summary>
        [JsonProperty("leader")]
        public long Leader { get; set; }

        /// <summary>
        /// Longest chain
        /// </summary>
        [JsonProperty("best_chain")]
        public long BestChain { get; set; }

        /// <summary>
        /// Respect Gained
        /// </summary>
        [JsonProperty("respect")]
        public long Respect { get; set; }

        /// <summary>
        /// Faction Rank
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// List of members
        /// </summary>
        [JsonProperty("members")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, FactionMember> Members { get; set; }

        /// <summary>
        /// Faction specials (Name of special/Level)
        /// </summary>
        [JsonProperty("specials")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string, long> Specials { get; set; }

        /// <summary>
        /// Factions that are in war with this faction (name / Epoc timestamp (start date))
        /// </summary>
        [JsonProperty("wars")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string, long> Wars { get; set; }

        /// <summary>
        /// Factions that have a non agression pact with this faction (name / Epoc timestamp (start date))
        /// </summary>
        [JsonProperty("naps")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string, long> Naps { get; set; }

        /// <summary>
        /// Factions that have a peace treaty with this factions (name / Epoc timestamp (start date))
        /// </summary>
        [JsonProperty("peace")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string, long> Peace { get; set; }
    }
}
