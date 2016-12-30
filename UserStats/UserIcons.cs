using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserIcons: IUserStatistics
    {
        [JsonProperty("icons")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string,string> Icons { get; set; }

        public string GetMethodName()
        {
            return UserMethods.icons.ToString();
        }
    }
}
