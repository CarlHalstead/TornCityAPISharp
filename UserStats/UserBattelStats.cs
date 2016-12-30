using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.UserStats
{
    public class UserBattelStats:IUserStatistics
    {
        [JsonProperty("strength")]
        public double Strength { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("dexterity")]
        public double Dexterity { get; set; }

        [JsonProperty("defense")]
        public double Defense { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("strength_modifier")]
        public int StrengthModifier { get; set; }

        [JsonProperty("defense_modifier")]
        public int DefenseModifier { get; set; }

        [JsonProperty("speed_modifier")]
        public int SpeedModifier { get; set; }

        [JsonProperty("dexterity_modifier")]
        public int DexterityModifier { get; set; }

        [JsonProperty("strength_info")]
        public List<string> StrengthInfo { get; set; }

        [JsonProperty("defense_info")]
        public List<string> DefenseInfo { get; set; }

        [JsonProperty("speed_info")]
        public List<string> SpeedInfo { get; set; }

        [JsonProperty("dexterity_info")]
        public List<string> DexterityInfo { get; set; }

        public string GetMethodName()
        {
            return UserMethods.battlestats.ToString();
        }
    }
}
