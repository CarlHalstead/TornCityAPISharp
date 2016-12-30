using Newtonsoft.Json;
using System;

namespace TornCityAPISharp.UserStats
{
    public class UserNotifications:IUserStatistics
    {
        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }

        public string GetMethodName()
        {
            return UserMethods.notifications.ToString();
        }
    }
}
