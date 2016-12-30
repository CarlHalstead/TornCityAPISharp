using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserProfile:IUserStatistics
    {
        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }

        [JsonProperty("signup")]
        public string Signup { get; set; }

        [JsonProperty("awards")]
        public int Awards { get; set; }

        [JsonProperty("friends")]
        public int Friends { get; set; }

        [JsonProperty("enemies")]
        public int Enemies { get; set; }

        [JsonProperty("forum_posts")]
        public int Forum_posts { get; set; }

        [JsonProperty("karma")]
        public int Karma { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("maximum_life")]
        public int MaximumLife { get; set; }

        [JsonProperty("donator")]
        public int Donator { get; set; }

        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("property_id")]
        public int PropertyID { get; set; }

        [JsonProperty("last_action")]
        public string LastAction { get; set; }

        [JsonProperty("status")]
        public List<string> Status { get; set; }

        [JsonProperty("job")]
        public Job Job { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("married")]
        public Married Married { get; set; }

        [JsonProperty("icons")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string,string> Icons { get; set; }

        public string GetMethodName()
        {
            return UserMethods.profile.ToString();
        }
    }
}
