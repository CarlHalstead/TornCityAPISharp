using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornOrganisedCrimes: ITornStats
    {
        [JsonProperty("organisedcrimes")]
        public Dictionary<int,OrganisedCrimes> OrganisedCrimes { get; set; }

        public string GetMethodName()
        {
            return TornMethods.organisedcrimes.ToString();
        }
    }
}
