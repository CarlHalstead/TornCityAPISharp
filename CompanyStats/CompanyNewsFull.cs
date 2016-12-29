using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyNewsFull : ICompanyStatistics
    {
        [JsonProperty("newsfull")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        Dictionary<long,News> NewsFull { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.news.ToString();
        }
    }
}
