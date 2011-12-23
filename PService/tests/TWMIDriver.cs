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
            // Get all the disk drives
            List<string> cmbHdd = new List<string>();


            ConnectionOptions oConn = new ConnectionOptions();
            oConn.Username = login;
            oConn.Password = password;
            oConn.Impersonation = ImpersonationLevel.Impersonate;
            oConn.EnablePrivileges = true;

            // Connect to the remote machine's WMI repository

            System.Management.ManagementScope oMs ;

           // if (host == Environment.MachineName)
            //    oMs = new ManagementScope("\\\\" + host + "\\root\\cimv2");
            //else
                oMs = new ManagementScope("\\\\" + host + "\\root\\cimv2", oConn);


            // connect it
            oMs.Connect();

            

            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(oMs, new ObjectQuery("SELECT * FROM Win32_DiskDrive"));

            // Loop through each object (disk) retrieved by WMI

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                // Add the HDD to the list (use the Model field as the item's caption)

              
                cmbHdd.Add(moDisk["Model"].ToString());
            }


            //Set objWMIService = GetObject("winmgmts:\\" + strComputer + "\root\cimv2")
            ManagementObjectSearcher colItems = new ManagementObjectSearcher(oMs, new ObjectQuery("Select * from Win32_LogicalDisk"));
            foreach (ManagementObject objItem in colItems.Get())
            {

                Console.WriteLine(
                    "Access: " + objItem["Access"]);
                /*Wscript.Echo "Availability: " + objItem.Availability
                Wscript.Echo "BlockSize: " + objItem.BlockSize
                Wscript.Echo "Caption: " + objItem.Caption
                Wscript.Echo "Compressed: " + objItem.Compressed
                Wscript.Echo "ConfigManagerErrorCode: " + objItem.ConfigManagerErrorCode
                Wscript.Echo "ConfigManagerUserConfig: " + objItem.ConfigManagerUserConfig
                Wscript.Echo "CreationClassName: " + objItem.CreationClassName
                Wscript.Echo "Description: " + objItem.Description
                Wscript.Echo "DeviceID: " + objItem.DeviceID
                Wscript.Echo "DriveType: " + objItem.DriveType
                Wscript.Echo "ErrorCleared: " + objItem.ErrorCleared
                Wscript.Echo "ErrorDescription: " + objItem.ErrorDescription
                Wscript.Echo "ErrorMethodology: " + objItem.ErrorMethodology
                Wscript.Echo "FileSystem: " + objItem.FileSystem
                Wscript.Echo "FreeSpace: " + objItem.FreeSpace*/
                Console.WriteLine("FreeSpace: " + Convert.ToInt64(objItem["FreeSpace"]) / (1024 * 1024));
                /*Wscript.Echo "InstallDate: " + objItem.InstallDate
                Wscript.Echo "LastErrorCode: " + objItem.LastErrorCode
                Wscript.Echo "MaximumComponentLength: " + objItem.MaximumComponentLength
                Wscript.Echo "MediaType: " + objItem.MediaType
                Wscript.Echo "Name: " + objItem.Name
                Wscript.Echo "NumberOfBlocks: " + objItem.NumberOfBlocks
                Wscript.Echo "PNPDeviceID: " + objItem.PNPDeviceID
                Wscript.Echo "PowerManagementCapabilities: " + objItem.PowerManagementCapabilities
                Wscript.Echo "PowerManagementSupported: " + objItem.PowerManagementSupported
                Wscript.Echo "ProviderName: " + objItem.ProviderName
                Wscript.Echo "Purpose: " + objItem.Purpose*/

                Console.WriteLine("Size: " + Convert.ToInt64(objItem["Size"]) / (1024 * 1024));
                /*Wscript.Echo "Status: " + objItem.Status
                Wscript.Echo "StatusInfo: " + objItem.StatusInfo
                Wscript.Echo "SupportsFileBasedCompression: " + objItem.SupportsFileBasedCompression
                Wscript.Echo "SystemCreationClassName: " + objItem.SystemCreationClassName
                Wscript.Echo "SystemName: " + objItem.SystemName
                Wscript.Echo "VolumeName: " + objItem.VolumeName
                Wscript.Echo "VolumeSerialNumber: " + objItem.VolumeSerialNumber*/
            }
            return null;
        }



        

    }
}
