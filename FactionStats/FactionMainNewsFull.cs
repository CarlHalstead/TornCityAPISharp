using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionMainNewsFull: IFactionStatistics
    {
        /// <summary>
        /// List of main news ful
        /// </summary>
        [JsonProperty("mainnewsfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.mainnewsfull.ToString();
        }
    }
}
