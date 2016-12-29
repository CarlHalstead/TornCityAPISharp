using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyNews : ICompanyStatistics
    {
        [JsonProperty("news")]
        Dictionary<long,News> News { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.news.ToString();
        }
    }
}
