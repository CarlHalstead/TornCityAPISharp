using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyStock : ICompanyStatistics
    {
        [JsonProperty("company_stock")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string,StockItem> Stock { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.stock.ToString();
        }
    }
}



