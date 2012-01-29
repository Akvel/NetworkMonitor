using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace PService.tests
{
    public class TWMIDriver : ITest
    {
        private readonly String host;
        private readonly String login;
        private readonly String password;

        public TWMIDriver(String host, String login, String password)
        {
            this.host = host;
            this.login = login;
            this.password = password;
        }

        public PResult getTest()
        {
            try
            {
                // Get all the disk drives
                List<string> cmbHdd = new List<string>();


                ConnectionOptions oConn = new ConnectionOptions();
                oConn.Username = login;
                oConn.Password = password;
                oConn.Impersonation = ImpersonationLevel.Impersonate;
                oConn.EnablePrivileges = true;

                // Connect to the remote machine's WMI repository

                System.Management.ManagementScope oMs;


                oMs = new ManagementScope("\\\\" + host + "\\root\\cimv2", oConn);


                oMs.Connect();



                ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(oMs,
                                                                                 new ObjectQuery(
                                                                                     "SELECT * FROM Win32_DiskDrive"));

                // Loop through each object (disk) retrieved by WMI

                foreach (ManagementObject moDisk in mosDisks.Get())
                {
                    // Add the HDD to the list (use the Model field as the item's caption)


                    cmbHdd.Add(moDisk["Model"].ToString());
                }

                ManagementObjectSearcher colItems = new ManagementObjectSearcher(oMs,
                                                                                 new ObjectQuery(
                                                                                     "Select * from Win32_LogicalDisk"));
                foreach (ManagementObject objItem in colItems.Get())
                {


                    Console.WriteLine("FreeSpace: " + Convert.ToInt64(objItem["FreeSpace"])/(1024*1024));

                    Console.WriteLine("Size: " + Convert.ToInt64(objItem["Size"])/(1024*1024));

                    if (Convert.ToInt64(objItem["FreeSpace"])/(1024*1024) < 1000)
                    {
                        PResult result = new PResult();
                        result.errCode = 1;
                        result.message = "Сводобное место:" + Convert.ToInt64(objItem["FreeSpace"])/(1024*1024);
                        return result;
                    }

                }

                PResult result1 = new PResult();
                result1.errCode = 0;
                result1.message = "ok";
                return result1;
            }catch(Exception e)
            {
                PResult result1 = new PResult();
                result1.errCode = -1;
                result1.message = e.Message;
                result1.exception = e;
                return result1;
            }
        }



        

    }
}
