using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class Employee
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("days_in_company")]
        public int DaysInCompany { get; set; }
    }
}
