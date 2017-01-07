using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.Utils
{
    /// <summary>
    /// Exception that is beeing throw 1
    /// 
    /// </summary>
    public class TornApiToManyRequestException : Exception
    {
        /// <summary>
        /// To many calls were made 
        /// </summary>
        public TornApiToManyRequestException()
        {
        }

        /// <summary>
        /// To many call were made
        /// </summary>
        /// <param name="message"></param>
        public TornApiToManyRequestException(string message)
        : base(message)
        {
        }

        /// <summary>
        /// To many calls were made
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public TornApiToManyRequestException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
