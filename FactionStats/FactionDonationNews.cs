using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.FactionStats
{
    public class FactionDonationNews: IFactionStatistics
    {
        /// <summary>
        /// List of donation news
        /// </summary>
        [JsonProperty("donationnews")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> MainNewsFull { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.donationnews.ToString();
        }
    }
}
