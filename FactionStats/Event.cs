using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.FactionStats
{
    public class Event
    {
        /// <summary>
        /// Time of the event
        /// </summary>
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        /// <summary>
        /// Event tekst
        /// </summary>
        [JsonProperty("news")]
        public string News { get; set; }
    }
}
