using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserMerits:IUserStatistics
    {
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        [JsonProperty("merits")]
        public Dictionary<string,int> merits { get; set; }

        public string GetMethodName()
        {
            return UserMethods.merits.ToString();
        }
    }
}
