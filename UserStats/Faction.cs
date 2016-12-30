using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Faction
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        [JsonProperty("days_in_faction")]
        public int DaysInFaction { get; set; }

        [JsonProperty("faction_name")]
        public string FactionName { get; set; }
    }
}
