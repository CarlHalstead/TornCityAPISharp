using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionWeapon :IFactionStatistics
    {
        /// <summary>
        /// Weapons in the faction
        /// </summary>
        [JsonProperty("weapons")]
        public List<Item> Weapons { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.weapons.ToString();
        }
    }

   
}
