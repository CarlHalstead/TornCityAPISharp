using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class UserCooldowns:IUserStatistics
    {
        [JsonProperty("cooldowns")]
        public Cooldowns Cooldowns { get; set; }

        public string GetMethodName()
        {
            return UserMethods.cooldowns.ToString();
        }
    }
}
