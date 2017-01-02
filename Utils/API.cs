using System;

namespace TornCityAPISharp.Utils
{
	/// <summary>
	/// This class holds some very simple information for the working of the API
	/// </summary>
	public class API
	{
		/// <summary>
		/// This holds a reference to the apiKey that you must provide
		/// </summary>
		public string ApiKey {
            get
            {
                if(string.IsNullOrWhiteSpace(_apiKey))
                {
                    throw new Exception("Invalid Api Key");
                }else
                {
                    return _apiKey;
                }
            }

            set
            {
                if(string.IsNullOrWhiteSpace(_apiKey))
                {
                    this._apiKey = value;
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// number of calls with this api key
        /// </summary>
        public int ApiCallCount
        {
            get
            {
                var timeDiff = DateTime.Now - _lastReset;
                if(timeDiff.Seconds > 60)
                {
                    _apiCallCount = 0;
                    _lastReset = DateTime.Now;
                    return _apiCallCount;
                }
                else
                {
                    return _apiCallCount;
                }
            }

            set
            {
                var timeDiff = DateTime.Now - _lastReset;
                if (timeDiff.Seconds > 60)
                {
                    _apiCallCount = 0;
                    _lastReset = DateTime.Now;
                }
                else
                {
                    _apiCallCount = value;
                }
            }
        }

        /// <summary>
        /// number of api calls with this key
        /// </summary>
        private int _apiCallCount;

        /// <summary>
        /// Last the the api key was reset to zero
        /// </summary>
        private DateTime _lastReset;

        /// <summary>
        /// that api key to use
        /// </summary>
        private string _apiKey;

        /// <summary>
        /// API constructor
        /// </summary>
        /// <param name="apiKey">Api key to use</param>
        public API(string apiKey)
        {
            _apiKey = apiKey;
            _lastReset = DateTime.Now;
            _apiCallCount = 0;
        }
	}
}
