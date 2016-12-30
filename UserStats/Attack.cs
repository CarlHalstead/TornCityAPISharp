using Newtonsoft.Json;

namespace TornCityAPISharp.UserStats
{
    public class Attack
    {
        [JsonProperty("timestamp_started")]
        public int TimestampStarted { get; set; }

        [JsonProperty("timestamp_ended")]
        public int TimeStampended { get; set; }

        [JsonProperty("attacker_id")]
        public int? AttackerId  { get; set; }

        [JsonProperty("attacker_namev")]
        public string AttackerName { get; set; }

        [JsonProperty("attacker_faction")]
        public int? AttackerFaction { get; set; }

        [JsonProperty("attacker_factionname")]
        public string AttackerFactionName { get; set; }

        [JsonProperty("defender_id")]
        public int? DefenderId  { get; set; }

        [JsonProperty("defender_name")]
        public string DefendetName  { get; set; }

        [JsonProperty("defender_faction")]
        public int? DefenderFaction { get; set; }

        [JsonProperty("defender_factionname")]
        public string DefenderFactionName { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("respect_gain")]
        public double RespectGain { get; set; }
    }
}
