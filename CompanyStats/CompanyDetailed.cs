using System;
using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyDetails
    {
        [JsonProperty("company_bank")]
        public long CompanyBank { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("efficiency")]
        public int Efficiency { get; set; }

        [JsonProperty("environment")]
        public int Environment { get; set; }

        [JsonProperty("trains_available")]
        public int TrainsAvailable { get; set; }

        [JsonProperty("advertising_budget")]
        public int AdvertisingBudget { get; set; }

        [JsonProperty("upgrades")]
        public Upgrades Upgrades { get; set; }

    }
}
