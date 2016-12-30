using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.UserStats
{
    public class UserBasic:IUserStatistics
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public List<string> Status { get; set; }

        public string GetMethodName()
        {
            return UserMethods.basic.ToString();
        }
    }
}
