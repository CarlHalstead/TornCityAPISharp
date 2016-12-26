using Newtonsoft.Json;

namespace TornCityAPISharp.FactionStats
{
    public class FactionMember
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("days_in_faction")]
        public long DaysInFaction { get; set; }

        public FactionMember()
        {
            this.Name = "";
            this.DaysInFaction = 0;
        }
    }
}
