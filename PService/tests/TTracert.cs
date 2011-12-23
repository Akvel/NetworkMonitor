using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using PService.data;

namespace PService.tests
{
    public class TTracert : ITest
    {

        private readonly String address;
        private readonly int maxHops;

        private const string Data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";


        public TTracert(String address)
        {
            this.address = address;
            this.maxHops = 30;
        }

        public TTracert(String address, int maxHops)
        {
            this.address = address;
            this.maxHops = maxHops;

        }

        public PResult getTest()
        {
            PResult result = new PResult();

            try
            {
                List<Dtraceroute> rr = getTraceRoute(address, maxHops);

                if (rr.Count() > 0)
                {

                    result.errCode = 0;
                    result.result = rr;
                }else
                {
                    result.errCode = 1;
                    result.result = rr;
                    result.message = "Empty list";
                }

            }catch(Exception e)
            {
                result.errCode = -1;
                result.exception = e;
                result.message = e.Message;
           }

            return result;
        }


        public static List<Dtraceroute> getTraceRoute(string ipAddressOrHostName, int maxHop)
        {
            List<Dtraceroute> result = new List<Dtraceroute>();
            IPAddress ipAddress = Dns.GetHostEntry(ipAddressOrHostName).AddressList[0];
            using (Ping pingSender = new Ping())
            {
                PingOptions pingOptions = new PingOptions();
                Stopwatch stopWatch = new Stopwatch();
                byte[] bytes = new byte[32];
                pingOptions.DontFragment = true;
                pingOptions.Ttl = 1;
                for (int i = 1; i < maxHop + 1; i++)
                {
                    stopWatch.Reset();
                    stopWatch.Start();
                    PingReply pingReply = pingSender.Send(
                        ipAddress,
                        5000,
                        new byte[32], pingOptions);
                    stopWatch.Stop();

                    result.Add(new Dtraceroute(i, stopWatch.ElapsedMilliseconds, ""+ pingReply.Address));

                   

                    if (pingReply.Status == IPStatus.Success)
                    {
                       break;
                    }
                    pingOptions.Ttl++;
                }
            }
            return result;
        }

    }
}
