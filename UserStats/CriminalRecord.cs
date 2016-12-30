using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Criminalrecord
    {
        [JsonProperty("selling_illegal_products")]
        public int SellingIllegalProducts { get; set; }

        [JsonProperty("theft")]
        public int Theft { get; set; }

        [JsonProperty("auto_theft")]
        public int AutoTheft { get; set; }

        [JsonProperty("drug_deals")]
        public int DrugDeals { get; set; }

        [JsonProperty("computer_crimes")]
        public int ComputerCrimes { get; set; }

        [JsonProperty("murder")]
        public int Murder { get; set; }

        [JsonProperty("fraud_crimes")]
        public int FruadCrimes { get; set; }

        [JsonProperty("other")]
        public int Other  { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
