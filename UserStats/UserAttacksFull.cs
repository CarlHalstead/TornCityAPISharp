using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserAttacksFull:IUserStatistics
    {
        [JsonProperty("attacksfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        Dictionary<long, Attack> AttacksFull { get; set; }

        public string GetMethodName()
        {
            return UserMethods.attacksfull.ToString();
        }
    }
}
