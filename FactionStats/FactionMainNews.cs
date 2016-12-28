using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionMainNews: IFactionStatistics
    {
        /// <summary>
        /// List of main news
        /// </summary>
        [JsonProperty("mainnews")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> events { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.mainnews.ToString();
        }
    }
}
