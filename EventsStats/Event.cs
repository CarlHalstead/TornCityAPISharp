using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.EventsStats
{
    public class Event
    {
        [JsonProperty("Timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("event")]
        public string EventText { get; set; }

        [JsonProperty("seen")]
        public bool Seen { get; set; }
    }
}
