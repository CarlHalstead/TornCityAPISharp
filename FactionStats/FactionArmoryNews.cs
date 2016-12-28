using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using TornCityAPISharp.Enums;

namespace TornCityAPISharp.FactionStats
{
    public class FactionArmoryNews : IFactionStatistics
    {
        /// <summary>
        /// List of armoury news
        /// </summary>
        [JsonProperty("armorynews")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.armorynews.ToString();
        }
    }
}
