using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class HofItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
