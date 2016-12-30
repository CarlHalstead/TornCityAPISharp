using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserMedals:IUserStatistics
    {
        [JsonProperty("medals_awarded")]
        public List<int> MedalsAwarded { get; set; }
        [JsonProperty("medals_time")]
        public List<int> MedalsTime { get; set; }

        public string GetMethodName()
        {
            return UserMethods.medals.ToString();
        }
    }
}
