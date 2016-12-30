using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserHof:IUserStatistics
    {
        [JsonProperty("hof")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string,HofItem> hof { get; set; }

        public string GetMethodName()
        {
            return UserMethods.hof.ToString();
        }
    }
}
