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


        public string id_parent;


        public override string ToString()
        {
            return "IP:" + ip + (String.Empty.Equals(hostname) ? "" : " (" + hostname + ")") + (String.Empty.Equals(desc) ? "" : " " + desc);
        }

        public bool Equals(Hardware other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.hostname, hostname);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Hardware)) return false;
            return Equals((Hardware) obj);
        }

        public override int GetHashCode()
        {
            return (hostname != null ? hostname.GetHashCode() : 0);
        }
    }
}
