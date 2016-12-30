using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserAttacks:IUserStatistics
    {
        [JsonProperty("attacks")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Attack> Attacks { get; set; }

        public string GetMethodName()
        {
            return UserMethods.attacks.ToString();
        }
    }
}
