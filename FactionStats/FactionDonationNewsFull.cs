using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionDonationNewsFull : IFactionStatistics
    {
        /// <summary>
        /// List of donation news full
        /// </summary>
        [JsonProperty("donationnewsfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.donationnewsfull.ToString();
        }
    }
}
