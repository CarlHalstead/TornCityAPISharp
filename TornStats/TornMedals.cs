using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornMedals: ITornStats
    {
        [JsonProperty("medals")]
        public Dictionary<int,Medal> Medals { get; set; }

        public string GetMethodName()
        {
            return TornMethods.medals.ToString();
        }
    }
}
