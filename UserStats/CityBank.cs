using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class CityBank
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("time_left")]
        public int TimeLeft { get; set; }
    }
}
