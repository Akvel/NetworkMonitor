using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PService.data
{
    public class Dtraceroute
    {
        public readonly int index;
        public readonly long milisecond;
        public readonly string host;


        public Dtraceroute(int index, long milisecond, string host)
        {
           this.index = index;
            this.milisecond = milisecond;
            this.host = host;
        }


        public override string ToString()
        {
            return index + " " + milisecond + " " + host;
        }
    }



}
