using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Bar
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("maximum")]
        public int Maximum { get; set; }

        [JsonProperty("increment")]
        public int Increment { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("ticktime")]
        public int Ticktime { get; set; }

        [JsonProperty("fulltime")]
        public int FullTime { get; set; }
    }
}
