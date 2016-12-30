using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class UserCrimes:IUserStatistics
    {
        [JsonProperty("criminalrecord")]
        public Criminalrecord criminalrecord { get; set; }

        public string GetMethodName()
        {
            return UserMethods.crimes.ToString();
        }
    }
}
