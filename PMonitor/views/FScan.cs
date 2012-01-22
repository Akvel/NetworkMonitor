using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PData.data;
using PService;
using PService.tests;

namespace PMonitor.views
{
    public partial class FScan : Form
    {
        public FScan()
        {
            InitializeComponent();
        }

        private void bScan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbStart.Text + "--" + tbStop.Text);
            lbLog.Items.Clear();
            cbFind.Items.Clear();
            ;

            String[] ipStart = tbStart.Text.Split(new Char[] {'.'});
            String[] ipStop = tbStop.Text.Split(new Char[] { '.' });

           

            for (int i1 = Convert.ToInt32(ipStart[0]); i1 <= Convert.ToInt32(ipStop[0]); i1++)
            {
                for (int i2 = Convert.ToInt32(ipStart[1]); i2 <= Convert.ToInt32(ipStop[1]); i2++)
                {
                    for (int i3 = Convert.ToInt32(ipStart[2]); i3 <= Convert.ToInt32(ipStop[2]); i3++)
                    {
                        for (int i4 = Convert.ToInt32(ipStart[3]); i4 <= Convert.ToInt32(ipStop[3]); i4++)
                        {
                            String ip = i1 + "." + i2 + "." + i3 + "." + i4;
                            String hostname = "-";
                            TPing ping = new TPing(ip,3);

                            PResult result = ping.getTest();

                            if (result.errCode ==0)
                            {
                                try
                                {
                                    hostname = Dns.GetHostEntry(ip).HostName;
                                }catch(Exception e12)
                                {
                                    hostname = String.Empty;
                                }

                                Hardware h = new Hardware();
                                h.ip = ip;
                                h.hostname = hostname;
                                cbFind.Items.Add(h);
                            }

                            lbLog.Items.Add(ip + " " + hostname + " " + result.errCode);
                            Thread.CurrentThread.Interrupt();
                        }
                    }
                }
            }
        }






    }


   

}
