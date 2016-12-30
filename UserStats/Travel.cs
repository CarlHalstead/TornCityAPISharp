using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Travel
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("departed")]
        public int Departed { get; set; }

        [JsonProperty("time_left")]
        public int TimeLeft { get; set; }
    }
}
