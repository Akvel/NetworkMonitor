using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using PService.data;

namespace PService.tests
{
    public class TWMIRam : ITest
    {
        private readonly String address;
        private readonly String login;
        private readonly String password;

        public TWMIRam(String host, String login, String password)
        {
            address = host;
            this.login = login;
            this.password = password;
        }

        public PResult getTest()
        {
            getTotal();

            return null;
        }



        private static DMemory getTotal()
        {
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;

            ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);                
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("Capacity: {0}", queryObj["Capacity"]);
                System.Console.WriteLine("MemoryType: {0}", queryObj["MemoryType"]);
                System.Diagnostics.Debug.WriteLine("MemoryType: {0}", queryObj["MemoryType"]);

                //return queryObj;
            }

            return null;
        }
    }
}
