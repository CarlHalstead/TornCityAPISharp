using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyDetailed : ICompanyStatistics
    {
        [JsonProperty("company_detailed")]
        public CompanyDetails Details { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.detailed.ToString();
        }
    }
}




