using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.FactionStats
{
    public class FactionArmoryNewsFull : IFactionStatistics
    {
        /// <summary>
        /// List Full armoury news
        /// </summary>
        [JsonProperty("armorynewsfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.armorynewsfull.ToString();
        }
    }
}
