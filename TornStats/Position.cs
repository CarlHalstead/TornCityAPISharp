using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Position
    {
        [JsonProperty("man_required")]
        public int ManRequired { get; set; }

        [JsonProperty("int_required")]
        public int IntRequired { get; set; }

        [JsonProperty("end_required")]
        public int EndRequired { get; set; }

        [JsonProperty("man_gain")]
        public int ManGain { get; set; }

        [JsonProperty("int_gain")]
        public int IntGain { get; set; }

        [JsonProperty("end_gain")]
        public int EndGain { get; set; }

        [JsonProperty("special_ability")]
        public string SpecialAbility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
