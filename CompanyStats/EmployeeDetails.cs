using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class EmployeeDetails
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("days_employed")]
        public int DaysEmployed { get; set; }

        [JsonProperty("wage")]
        public int Wage { get; set; }

        [JsonProperty("effectiveness")]
        public int Effectiveness { get; set; }

        [JsonProperty("manual_labor")]
        public int ManualLabour { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("endurance")]
        public int Endurance { get; set; }
    }
}
