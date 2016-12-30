using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserProperties:IUserStatistics
    {
        [JsonProperty("properties")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Property> Properties { get; set; }

        public string GetMethodName()
        {
            return UserMethods.properties.ToString();
        }
    }
}
