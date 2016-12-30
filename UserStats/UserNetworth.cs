using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class UserNetworth:IUserStatistics
    {
        [JsonProperty("networth")]
        public Networth Networth { get; set; }

        public string GetMethodName()
        {
            return UserMethods.networth.ToString();
        }
    }
}


