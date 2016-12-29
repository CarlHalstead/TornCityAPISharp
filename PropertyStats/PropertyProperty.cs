using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.PropertyStats
{
    public class PropertyProperty : IPropertyStatistics
    {
        [JsonProperty("property")]
        public Property Property { get; set; }

        public string GetMethodName()
        {
            return PropertyMethods.property.ToString();
        }
    }
}