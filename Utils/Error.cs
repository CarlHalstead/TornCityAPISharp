using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.Utils
{
    public class Error
    {
        public int code { get; set; }
        public string error { get; set; }
    }

    public class ErrorWrapper
    {
        public Error error { get; set; }
    }
}
