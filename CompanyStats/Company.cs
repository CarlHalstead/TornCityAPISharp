using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.CompanyStats
{
    public class Company
    {
        [JsonProperty("company_type")]
        public int CompanyType { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("director")]
        public int Director { get; set; }

        [JsonProperty("daily_profit")]
        public int DailyProfit { get; set; }

        [JsonProperty("weekly_profit")]
        public int WeeklyProfit { get; set; }

        [JsonProperty("daily_customers")]
        public int DailyCustomers { get; set; }

        [JsonProperty("weekly_customers")]
        public int WeeklyCustomers { get; set; }

        [JsonProperty("days_old")]
        public int DaysOld { get; set; }

        [JsonProperty("employees")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long,Employee> Employees { get; set; }
    }
}
