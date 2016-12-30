using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class UserBars:IUserStatistics
    {
        [JsonProperty("server_time")]
        public int ServerTime { get; set; }

        [JsonProperty("happy")]
        public Bar Happy { get; set; }

        [JsonProperty("life")]
        public Bar Life { get; set; }

        [JsonProperty("energy")]
        public Bar Energy { get; set; }

        [JsonProperty("nerve")]
        public Bar Nerve { get; set; }

        [JsonProperty("chain")]
        public Bar Chain { get; set; }

        public string GetMethodName()
        {
            return UserMethods.bars.ToString();
        }
    }
}
