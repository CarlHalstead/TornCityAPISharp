using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserInventory:IUserStatistics
    {
        [JsonProperty("inventory")]
        public List<Inventory> Inventory { get; set; }

        public string GetMethodName()
        {
            return UserMethods.inventory.ToString();
        }
    }
}
