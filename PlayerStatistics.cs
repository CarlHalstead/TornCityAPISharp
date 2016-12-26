using TornCityAPISharp.Utils;
using TornCityAPISharp.EventsStats;
using System.Threading.Tasks;
using TornCityAPISharp.PlayerStats;

namespace TornCityAPISharp
{
	/// <summary>
	/// This class is for retrieving specific player stats
	/// </summary>
	public class PlayerStatistics
	{
        private API api;
        private GetObjectFromUrl apiCaller = new GetObjectFromUrl();
        private static string urlBase = @"https://api.torn.com/user/";

        public PlayerStatistics(ref API api)
        {
            this.api = api;
        }

        public async Task<EventsBase> GetPlayerEvents()
        {
            string url = urlBase + "?selections=events&key=" + api.ApiKey;
            var response = await apiCaller.GetObject<EventsBase>(url);
            api.ApiCallCount++;

            return response;
        }
        
        public async Task<PlayerBase> GetPlayerBasic(string playerID = "")
        {
            string url = urlBase + playerID + "?selections=basic&key=" + api.ApiKey;
            var response = await apiCaller.GetObject<PlayerBase>(url);
            api.ApiCallCount++;

            return response;
            
        }
	}
}