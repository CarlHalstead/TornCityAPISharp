using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornCompanies : ITornStats
    {
        [JsonProperty("companies")]
        public Dictionary<int,Companies> Companies { get; set; }

        public string GetMethodName()
        {
            return TornMethods.companies.ToString();
        }
    }
}
