using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TornCityAPISharp.FactionStats;


namespace TornCityAPISharp
{
    public class TornApiWrapper
    {
        #region Accessors
        public int MaxNumberOfCalls { get; set; }

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

        public FactionStatistics FactionStatistics { get; private set; }

        public PlayerStatistics PlayerStatistics { get; private set; }

        public PropertyStatistics PropertyStatistics { get; private set; }
        #endregion

        #region Mutators
        private API _apiKey;
        #endregion

        #region Constructors
        public TornApiWrapper(string apiKey, int maxNumberOfCalls)
        {
            ApiKey = new API(apiKey);
            MaxNumberOfCalls = maxNumberOfCalls;
            FactionStatistics = new FactionStatistics(ref _apiKey);

        }

        #endregion

        #region Methods
        public void ChangeApiKey(string apiKey)
        {
            this.ApiKey.ApiKey = apiKey;
        }
        #endregion


       
    }
}
