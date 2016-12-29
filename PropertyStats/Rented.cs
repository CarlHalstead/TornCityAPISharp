using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.PropertyStats
{
    public class Rented
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("days_left")]
        public string DaysLeft { get; set; }

        [JsonProperty("total_cost")]
        public string TotalCost { get; set; }

        [JsonProperty("cost_per_day")]
        public string CostPerDay { get; set; }
    }
}
