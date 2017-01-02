using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornGyms : ITornStats
    {
        [JsonProperty("gyms")]
        public Dictionary<int,Gyms> Gyms { get; set; }

        public string GetMethodName()
        {
            return TornMethods.gyms.ToString();
        }
    }
}
