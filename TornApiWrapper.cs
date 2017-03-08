using System;
using System.Threading.Tasks;
using TornCityAPISharp.Utils;
using TornCityAPISharp.Enums;
using TornCityAPISharp.FactionStats;
using TornCityAPISharp.PropertyStats;
using TornCityAPISharp.CompanyStats;
using TornCityAPISharp.MarketStats;
using TornCityAPISharp.UserStats;
using TornCityAPISharp.TornStats;

namespace TornCityAPISharp
{
    /// <summary>
    /// Wrapper class that does all the Torn api calls
    /// </summary>
    public class TornApiWrapper
    {
        #region Accessors
        /// <summary>
        /// Maximum number of calls that can be used;
        /// </summary>
        public int MaxNumberOfCalls { get; set; }

        /// <summary>
        /// Object that keeps track of the api key beeing used
        /// </summary>
        public API ApiKey
        {
            get
            {
                return _apiKey;
            }

            private set
            {
                this._apiKey = value;
            }
        }
        #endregion

        #region Mutators
        private API _apiKey;
        private GetObjectFromUrl apiCaller = new GetObjectFromUrl();
        private string urlBase = @"https://api.torn.com/";
        #endregion

        #region Constructors
        /// <summary>
        /// Create a TornWrapper instance
        /// </summary>
        /// <param name="apiKey">Api to use</param>
        /// <param name="maxNumberOfCalls">Number of call limit (Throws error when going over this amount).</param>
        public TornApiWrapper(string apiKey, int maxNumberOfCalls)
        {
            ApiKey = new API(apiKey);
           
            MaxNumberOfCalls = maxNumberOfCalls;
        }

        /// <summary>
        /// Create a TornWrapper instance. That does not limit the amount of calls
        /// </summary>
        /// <param name="apiKey">Api to use</param>
        public TornApiWrapper(string apiKey)
        {
            ApiKey = new API(apiKey);

            MaxNumberOfCalls = int.MaxValue;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Call Methods from the Faction APi
        /// </summary>
        /// <typeparam name="T">Object that implements IFactionStatistics from the  TornCityAPISharp.FactionStats namespace</typeparam>
        /// <param name="factionID">Id of the faction or "" for user faction</param>
        /// <returns>Object containing response of type T</returns>
        public async Task<T> GetFromFactionApi<T>(string factionID) where T:IFactionStatistics,new()
        {
            var method = new T();
            string url = urlBase + Fields.faction.ToString() + "/"   + factionID + "?selections="+ method.GetMethodName() +"&key=" + _apiKey.ApiKey;
            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Call Methods from the property APi
        /// </summary>
        /// <typeparam name="T">object implementing IPropertyStatistics interface from the TornCityAPISharp.PropertyStats namespace</typeparam>
        /// <param name="propertyId">A Property Id</param>
        /// <returns>Object of type T</returns>
        public async Task<T> GetFromPropertyApi<T>(string propertyId) where T : IPropertyStatistics, new()
        {
            var method = new T();
            if(string.IsNullOrWhiteSpace(propertyId) == true)
            {
                throw new ArgumentException("Property id cannot be null of whitespace");
            }

            string url = urlBase + Fields.property.ToString() + "/" + propertyId + "?selections=" + method.GetMethodName() + "&key=" + _apiKey.ApiKey;

            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Call Methods from the company APi
        /// </summary>
        /// <typeparam name="T">object implementing ICompanyStatistics interface from the TornCityAPISharp.CompanyStats namespace</typeparam>
        /// <param name="companyId">A company Id</param>
        /// <returns>Object of type T</returns>
        public async Task<T> GetFromCompanyApi<T>(string companyId) where T : ICompanyStatistics, new()
        {
            var method = new T();

            string url = urlBase + Fields.company.ToString() + "/" + companyId + "?selections=" + method.GetMethodName() + "&key=" + _apiKey.ApiKey;

            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Call Methods from the market APi
        /// </summary>
        /// <typeparam name="T">object implementing IMarketStatistics interface from the TornCityAPISharp.MarketStats namespace</typeparam>
        /// <param name="itemId">An item Id</param>
        /// <returns>Object of type T</returns>
        public async Task<T> GetFromMarketApi<T>(string itemId) where T : IMarketStatistics, new()
        {
            var method = new T();

            string url = urlBase + Fields.market.ToString() + "/" + itemId + "?selections=" + method.GetMethodName() + "&key=" + _apiKey.ApiKey;

            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Call Methods from the user APi
        /// </summary>
        /// <typeparam name="T">object implementing IUserStatistics interface from the TornCityAPISharp.UserStats namespace</typeparam>
        /// <param name="userId">A porperty Id</param>
        /// <returns>Object of type T</returns>
        public async Task<T> GetFromUserApi<T>(string userId) where T : IUserStatistics, new()
        {
            var method = new T();

            string url = urlBase + Fields.user.ToString() + "/" + userId + "?selections=" + method.GetMethodName() + "&key=" + _apiKey.ApiKey;

            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Call Methods from the torn APi
        /// </summary>
        /// <typeparam name="T">object implementing ITornStats interface from the TornCityAPISharp.TornStats namespace</typeparam>
        /// <param name="parameter">Could be an item number, honor number depending on the api that is beeing called</param>
        /// <returns>Object of type T</returns>
        public async Task<T> GetFromTornApi<T>(string parameter) where T : ITornStats, new()
        {
            var method = new T();

            string url = urlBase + Fields.torn.ToString() + "/" + parameter + "?selections=" + method.GetMethodName() + "&key=" + _apiKey.ApiKey;

            try
            {
                var response = await DoCall<T>(url);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private async Task<T> DoCall<T>(string url)
        {
            if (_apiKey.GetApiCount() > MaxNumberOfCalls)
            {
                throw new TornApiToManyRequestException("To many calls have been made with this api key maximum amount: " + this.MaxNumberOfCalls.ToString());
            }
            try
            {
                var response = await apiCaller.GetObject<T>(url);

                _apiKey.AddApiCount();

                return response;
            }
            catch(Exception e)
            {
                throw  e;
            }
            
        }
        #endregion
    }
}
