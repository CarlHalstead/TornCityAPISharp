using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Specials
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("rating_required")]
        public int RatingRequired { get; set; }
    }
}
