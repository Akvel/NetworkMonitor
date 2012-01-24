using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PService
{
    public class PResult
    {
        public int errCode { get; set; }
        public String message { get; set; }
        public Exception exception { get; set; }
        public Object result { get; set; }

        public override string ToString()
        {
            return result + " " + message + " " + errCode + " " + (exception != null ? exception.Message : "");
        }
    }
}
