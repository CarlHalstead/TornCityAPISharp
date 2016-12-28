using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionAttackNews : IFactionStatistics
    {
        /// <summary>
        /// List of attack news
        /// </summary>
        [JsonProperty("attacknews")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.attacknews.ToString();
        }
    }
}
