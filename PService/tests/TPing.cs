using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace PService.tests
{
    public class TPing : ITest
    {
        private readonly String address;
        private readonly int timeout;

        public TPing(String address)
        {
            this.address = address;
            this.timeout = 120;
        }

        public TPing(String address, int timeout)
        {
            this.address = address;
            this.timeout = timeout;

        }

        public PResult getTest()
        {
            try
            {
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();

                // Use the default Ttl value which is 128,
                // but change the fragmentation behavior.
                options.DontFragment = true;

                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                PingReply reply = pingSender.Send(address, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    PResult result = new PResult();
                    result.errCode = 0;
                    result.result = reply;
                   
                    return result;
                   
                }
                else
                {
                    PResult result = new PResult();
                    result.errCode = 1;
                    result.message = "" + reply.Status;
                    result.result = reply;

                    return result;
                }

            }catch( Exception e)
            {
                PResult rr = new PResult();
                rr.errCode = -1;
                rr.exception = e;
                rr.message = e.Message;

                return rr;
            }

        }

         }
}
