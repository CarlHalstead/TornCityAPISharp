using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace TornCityAPISharp.UserStats
{
    public class UserDisplay:IUserStatistics
    {
        [JsonProperty("display")]
        public List<Display> Display { get; set; }

        public string GetMethodName()
        {
            return UserMethods.display.ToString();
        }
    }
}
