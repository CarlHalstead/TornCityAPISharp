using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornHonors: ITornStats
    {
        [JsonProperty("honors")]
        public Dictionary<int,Honor> Honors { get; set; }

        public string GetMethodName()
        {
            return TornMethods.honors.ToString();
        }
    }
}
