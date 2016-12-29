using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyProfile: ICompanyStatistics
    {
        [JsonProperty("company")]
        public Company Company { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.profile.ToString();
        }
    }
}
