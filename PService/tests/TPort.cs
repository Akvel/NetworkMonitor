using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace PService.tests
{
    public class TPort : ITest
    {
        private String ip;
        private int port;

        public TPort(String ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }


        public PResult getTest()
        {
            try
            {
                Socket soc = new Socket(AddressFamily.InterNetwork,
           SocketType.Stream,
           ProtocolType.Tcp);
                soc.Connect(ip, port);


                soc.Close();

                PResult result = new PResult();
                result.errCode = 1;
                result.message = "Ok";
                result.result = null;

                return result;
            }
            catch (Exception e)
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
