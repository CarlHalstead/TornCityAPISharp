using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.UserStats
{
    public class UserBazaar:IUserStatistics
    {
        [JsonProperty("bazaar")]
        public List<Bazaar> Bazaar { get; set; }

        public string GetMethodName()
        {
            return UserMethods.bazaar.ToString();
        }
    }
}
