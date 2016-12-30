using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TornCityAPISharp.UserStats
{
    public class UserPerks:IUserStatistics
    {
        [JsonProperty("job_perks")]
        public List<string> job_perks { get; set; }

        [JsonProperty("property_perks")]
        public List<string> property_perks { get; set; }

        [JsonProperty("stock_perks")]
        public List<string> stock_perks { get; set; }

        [JsonProperty("merit_perks")]
        public List<string> merit_perks { get; set; }

        [JsonProperty("education_perks")]
        public List<string> education_perks { get; set; }

        [JsonProperty("enhancer_perks")]
        public List<string> enhancer_perks { get; set; }

        [JsonProperty("company_perks")]
        public List<string> company_perks { get; set; }

        [JsonProperty("faction_perks")]
        public List<string> faction_perks { get; set; }

        public string GetMethodName()
        {
            return UserMethods.perks.ToString();
        }
    }
}

