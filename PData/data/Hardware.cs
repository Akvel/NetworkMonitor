using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PData.data
{
    public class Hardware
    {
        public String ip = String.Empty;
        public String hostname = String.Empty;
        public String desc = String.Empty;
        public string device_id;


        public override string ToString()
        {
            return "IP:" + ip + (String.Empty.Equals(hostname) ? "" : " (" + hostname + ")") + (String.Empty.Equals(desc) ? "" : " " + desc);
        }



    }
}
