using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Notifications
    {
        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("events")]
        public int Events { get; set; }

        [JsonProperty("awards")]
        public int Awards { get; set; }

        [JsonProperty("competition")]
        public int Competition { get; set; }
    }

}
