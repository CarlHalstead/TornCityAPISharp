using System;
using Newtonsoft.Json;

namespace TornCityAPISharp.FactionStats
{
    public class Member
    {
        /// <summary>
        /// Username name
        /// </summary>
        [JsonProperty("name")]
        public string UserId { get; set; }

        /// <summary>
        /// Days that this user is in the faction
        /// </summary>
        [JsonProperty("days_in_faction")]
        public long DaysInFaction { get; set; }


        public Member()
        {
            this.UserId = "";
            this.DaysInFaction = 0;
        }
    }
}
