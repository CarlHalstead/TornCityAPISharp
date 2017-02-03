using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.FactionStats
{
    public class Stats
    {
        [JsonProperty("medicalitemsused")]
        public int MedicalItemsUsed { get; set; }

        [JsonProperty("criminaloffences")]
        public int CriminalOffences { get; set; }

        [JsonProperty("organisedcrimerespect")]
        public int OrganisedCrimeRespect { get; set; }

        [JsonProperty("organisedcrimemoney")]
        public int OrganisedCrimeMoney { get; set; }

        [JsonProperty("organisedcrimesuccess")]
        public int OrganisedCrimeSuccess { get; set; }

        [JsonProperty("organisedcrimefail")]
        public int OrganisedCrimeFail { get; set; }

        [JsonProperty("attackswon")]
        public int AttacksWon { get; set; }

        [JsonProperty("attackslost")]
        public int AttacksLost { get; set; }

        [JsonProperty("attacksleave")]
        public int AttacksLeave { get; set; }

        [JsonProperty("attacksmug")]
        public int AttacksMug { get; set; }

        [JsonProperty("attackshosp")]
        public int AttacksHosp { get; set; }

        [JsonProperty("busts")]
        public int Busts { get; set; }

        [JsonProperty("revives")]
        public int Revives { get; set; }

        [JsonProperty("jails")]
        public int Jails { get; set; }

        [JsonProperty("hosps")]
        public int Hosps { get; set; }

        [JsonProperty("medicalitemrecovery")]
        public int MedicalItemRecovery { get; set; }

        [JsonProperty("medicalcooldownused")]
        public int MedicalCooldownUsed { get; set; }

        [JsonProperty("gymtrains")]
        public int GymTrains { get; set; }

        [JsonProperty("gymstrength")]
        public int GymStrength { get; set; }

        [JsonProperty("gymspeed")]
        public int GymSpeed { get; set; }

        [JsonProperty("gymdefense")]
        public int GymDefense { get; set; }

        [JsonProperty("gymdexterity")]
        public int GymDexterity { get; set; }

        [JsonProperty("candyused")]
        public int CandyUsed { get; set; }

        [JsonProperty("alcoholused")]
        public int AlcoholUsed { get; set; }

        [JsonProperty("energydrinkused")]
        public int EnergyDrinkUsed { get; set; }

        [JsonProperty("drugsused")]
        public int DrugsUsed { get; set; }

        [JsonProperty("drugoverdoses")]
        public int DrugOverdoses { get; set; }

        [JsonProperty("rehabs")]
        public int Rehabs { get; set; }

        [JsonProperty("caymaninterest")]
        public int CaymanInterest { get; set; }

        [JsonProperty("traveltimes")]
        public int TravelTimes { get; set; }

        [JsonProperty("traveltime")]
        public int TravelTime { get; set; }

        [JsonProperty("hunting")]
        public int Hunting { get; set; }

        [JsonProperty("attacksdamagehits")]
        public int AttacksDamageHits { get; set; }

        [JsonProperty("attacksdamage")]
        public int AttacksDamage { get; set; }

        [JsonProperty("hosptimegiven")]
        public int HospTimeGiven { get; set; }

        [JsonProperty("hosptimereceived")]
        public int HospTimeReceived { get; set; }

        [JsonProperty("attacksdamaging")]
        public int AttacksDamaging { get; set; }

        [JsonProperty("attacksrunaway")]
        public int AttacksRunaway { get; set; }

        [JsonProperty("territoryrespect")]
        public int TerritoryRespect { get; set; }

        
    }

    public class FactionStats : IFactionStatistics
    {
        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.stats.ToString();
        }
    }
}
