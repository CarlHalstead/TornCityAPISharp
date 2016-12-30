using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Cooldowns
    {
        [JsonProperty("drug")]
        public int Drug { get; set; }

        [JsonProperty("medical")]
        public int Medical { get; set; }

        [JsonProperty("booster")]
        public int Booster { get; set; }
    }
}
