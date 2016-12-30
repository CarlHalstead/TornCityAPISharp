using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.UserStats
{
    public class UserEducation:IUserStatistics
    {
        [JsonProperty("education_current")]
        public int EducationCurrent { get; set; }

        [JsonProperty("education_timeleft")]
        public int EducationTimeleft { get; set; }

        [JsonProperty("education_completed")]
        public List<int> EducationCompleted { get; set; }

        public string GetMethodName()
        {
            return UserMethods.education.ToString();
        }
    }
}
