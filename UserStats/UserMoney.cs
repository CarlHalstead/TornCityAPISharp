using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserMoney:IUserStatistics
    {
        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("cayman_bank")]
        public long CaymanBank { get; set; }

        [JsonProperty("vault_amount")]
        public int VaultAmount { get; set; }

        [JsonProperty("networth")]
        public long Networth { get; set; }

        [JsonProperty("money_onhand")]
        public int MoneyOnhand { get; set; }

        [JsonProperty("city_bank")]
        public CityBank CityBank { get; set; }

        public string GetMethodName()
        {
            return UserMethods.money.ToString();
        }
    }
}
