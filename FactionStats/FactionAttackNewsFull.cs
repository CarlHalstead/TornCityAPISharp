using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionAttackNewsFull : IFactionStatistics
    {
        /// <summary>
        /// List of attack news full
        /// </summary>
        [JsonProperty("attacknewsfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.armorynewsfull.ToString();
        }
    }
}
