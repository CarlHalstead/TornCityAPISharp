using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Event
    {
        [JsonProperty("timestamp")]
        public int Time { get; set; }

        [JsonProperty("event")]
        public string EventText { get; set; }

        [JsonProperty("seen")]
        public int Seen { get; set; }
    }
}
