using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TornCityAPISharp.CompanyStats
{
    public class CompanyEmpolyees: ICompanyStatistics
    {
        /// <summary>
        /// Value of the Company employees node of the json response (renamed because of it would have been abigous with the class name)
        /// </summary>
        [JsonProperty("company_employees")]
        public Dictionary<long, EmployeeDetails> CompanyEmployees { get; set; }

        public string GetMethodName()
        {
            return CompanyMethods.employees.ToString();
        }
    }
}
