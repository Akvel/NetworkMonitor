using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using PService;
using PService.data;
using PService.sender;
using PService.tests;

namespace PConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TPing ping = new TPing("192.168.1.1");
            //PResult result = ping.getTest();
            //PingReply rep = (PingReply) result.result;

            //Console.WriteLine("Address: {0}", rep.Address.ToString());
            ///Console.WriteLine("RoundTrip time: {0}", rep.RoundtripTime);
            //Console.WriteLine("Time to live: {0}", rep.Options.Ttl);
            //Console.WriteLine("Don't fragment: {0}", rep.Options.DontFragment);
            //Console.WriteLine("Buffer size: {0}", rep.Buffer.Length);
            Console.WriteLine("----------------------------------");

           // TTracert tracert = new TTracert("ya.ru");
            //PResult tresult = tracert.getTest();
           // List<Dtraceroute> rep1 = (List<Dtraceroute>)tresult.result;
            //foreach (Dtraceroute ipAddress in rep1)
            //{
            //    Console.WriteLine(ipAddress);
            //}
            Console.WriteLine("----------------------------------");

            //Console.WriteLine(Traceroute.Traceroute1("ya.ru"));//test
            Console.WriteLine("----------------------------------");


           // TWMIRam r  = new TWMIRam("localhost", "test", "testtest");
            //r.getTest();

            Console.WriteLine("----------------------------------");
            //TWMIDriver d = new TWMIDriver("192.168.1.41", "akvel", "testtest");
            //d.getTest();


            //TSql tSql = new TSql("127.0.0.1",1433);

            //Console.WriteLine(tSql.getTest());


             //  TPort port =  new TPort("127.0.0.1", 2034);
              // Console.WriteLine(">>>>" + port.getTest());

            SGmail mail = new SGmail();
            mail.send("Test");


            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
