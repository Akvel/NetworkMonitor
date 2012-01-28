using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Org.Snmp.Snmp_pp;
using PService;
using SNMPDll;

namespace PService.tests
{
    public class TSNMPcheck : ITest
    {
        private readonly String address;
        private String path = "1.3.6.1.2.1.4.22.1.2.1";
        private List<string> acc;

        public TSNMPcheck(String address, String path, List<string> acc)
        {
            this.address = address;
            if (!String.IsNullOrEmpty(path))
                this.path = path;

            this.acc = acc;
        }


       


     

        public PResult getTest()
        {
           try {
               SNMPAgent agent = new SNMPAgent(address);
               MemoryStream mem = new MemoryStream();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(mem);
                TextWriter tv = Console.Out;
                Console.SetOut(sw);
                agent.walk(new SNMPObject(path));
               Console.SetOut(tv);
               sw.Flush();
               mem.Position = 0;
               TextReader reader = new StreamReader(mem);
                string rr = reader.ReadToEnd();
                string  resu = sw.ToString();
               StringReader strrdr = new StringReader(rr);
                string str;
                Dictionary<string, string> ips = new Dictionary<string, string>();
                while((str = strrdr.ReadLine()) != null) {
            	    string[]  s1 = str.Split(new char[] {' '});
                      if (s1.Length == 2)
                      {
                          string[] s2 = s1[1].Split(new char[] { ',' });
                          if (s2.Length == 3)
                          {
                              string[] s3 = s2[0].Split(new char[] { '.' });
                              string ip = s3[11] + "." + s3[12] + "." + s3[13] + "." + s3[14];
                              SNMPObject s = new SNMPObject(s2[0]);
                              try
                              {
                                  string mac = BitConverter.ToString(
                                      System.Text.Encoding.UTF8.GetBytes(s.getSimpleValue(agent)));

                                  if (!mac.Equals("00-00-00-00-00-00") && !"255".Equals(s3[14]))
                                    ips.Add(ip, mac );

                             

                              }catch(Exception e)
                              {
                              }
                          }
                          ;
                      
                      }
            	   
            	  }

                PResult result = new PResult();
                result.errCode = 0;
                List<string > badIPList = new List<string>();
                foreach (string ip in ips.Keys) 
                {
                    if (!acc.Contains(ip))
                    {
                        badIPList.Add(ip);
                        result.errCode = 1;
                    }
                }
               
                result.errCode = 0;
                result.result = badIPList;

                return result;
            }
            catch(Exception e)
            {
               PResult result = new PResult();
                result.errCode = 1;
               result.result = "Error";
                result.exception = e;

               return result;
           }

        }
    }
}
