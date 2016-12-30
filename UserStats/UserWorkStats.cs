using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class UserWorkStats: IUserStatistics
    {
        [JsonProperty("manual_labor")]
        public int ManualLabor { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("endurance")]
        public int Endurance { get; set; }

        public string GetMethodName()
        {
            return UserMethods.workstats.ToString();
        }
    }
}
