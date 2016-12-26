using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TornCityAPISharp.FactionStats;
using TornCityAPISharp.Utils;

namespace TornCityAPISharp
{
    /// <summary>
    /// Class That Will get the Faction statistics
    /// </summary>
    public class FactionStatistics
    {
        private API api;
        private GetObjectFromUrl apiCaller = new GetObjectFromUrl();
        private static string urlBase = @"https://api.torn.com/faction/";

        public FactionStatistics(ref API api)
        {
            this.api = api;
        }

        /// <summary>
        /// Perform Faction Basic Method
        /// </summary>
        /// <param name="apiKey">Api Key To Use</param>
        /// <param name="factionID"></param>
        /// <returns></returns>
        public async Task<FactionBasic> GetFactionBasic(string factionID = "")
        {
            string url = urlBase + factionID + "?selections=basic&key=" + api.ApiKey;
            var response = await apiCaller.GetObject<FactionBasic>(url);
            api.ApiCallCount++;

            return response;
        }
    }
}
