using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PData.data;
using PData.monitorDataSetTableAdapters;
using PMonitor.views;
using PService.tests;

namespace PMonitor
{
    public partial class fMain : Form
    {
        private FUser fUser = new FUser();
        private FScan fScan ;
        private FHard fHard = new FHard();
        private FMonitor fMon = new FMonitor();
        private FSMail fMail = new FSMail();


        public static  Dictionary<string, int> newHard = new Dictionary<string, int>();


        private readonly Dictionary<string, Hardware> treeHardware = new Dictionary<string, Hardware>();
        private Thread tt;
        private readonly object syncRoot = new object();

        private FConnection log;
        public fMain()
        {
            InitializeComponent();

            tt = new Thread(scan);
            fScan = new FScan(this);

            log = new FConnection(this);
            

            tt.Start();


            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fUser.ShowDialog();
        }

        private void bShowScan_Click(object sender, EventArgs e)
        {
            fScan.ShowDialog();
            fScan.mustStop = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fHard.ShowDialog(getCurrentDeviceId());
            toolStripButton3_Click(null, null);
        }


        private Dictionary<string, TreeNode> ipToNode = new Dictionary<string, TreeNode>();

        


        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter();

            hardwaresTableAdapter.Fill(mset1.hardwares);
            var hArr =from myRow in mset1.hardwares.AsEnumerable()
                select myRow;
            tvTopolog.BeginUpdate();
            treeHardware.Clear();
            tvTopolog.Nodes.Clear();

            lock (syncRoot)
            {
                ipToNode.Clear();
            }

            Dictionary<string, Hardware> idToName = new Dictionary<string, Hardware>();
            Dictionary<Hardware, string> NameToId = new Dictionary<Hardware, string>();
            Dictionary<string, string> idToParent = new Dictionary<string, string>();
            List<Hardware> hosts = new List<Hardware>();
             foreach (monitorDataSet.hardwaresRow h in mset1.hardwares.Rows)
             {
                 Hardware hard = new Hardware();
                hard.ip = ""  + h.ip_address;
                hard.desc = (string) h.description;
                hard.hostname = "" + h.dns_name;
                hard.device_id = "" + h.id;
                hard.id_parent = (!h.Isid_parentNull() ? "" + h.id_parent : "");

                 idToName.Add(""  +h.id, hard);
                 NameToId.Add(hard, ""  +h.id);
                 hosts.Add(hard);

                

                treeHardware.Add("" + hard, hard);
             }
           

            while (hosts.Count > 0)
            {
                List<Hardware> newHost = new List<Hardware>();
                foreach (Hardware hard in hosts)
                {
                    if (hard.device_id.Equals(hard.id_parent) || "".Equals(hard.id_parent) || !idToName.ContainsKey(hard.id_parent))
                    {
                         TreeNode mynode = tvTopolog.Nodes.Add("" + hard);
                         if (!ipToNode.ContainsKey(hard.ip))
                         {
                             lock (syncRoot)
                             {
                                 ipToNode.Add(hard.ip, mynode);
                             }
                         }
                        if (newHard.ContainsKey(hard.hostname))
                                mynode.BackColor = Color.Yellow;
                    }else
                    {
                         TreeNode exists = null;

                            foreach (TreeNode node in tvTopolog.Nodes)
                            {
                                TreeNode test = NodeExists(node, "" + idToName[hard.id_parent]);
                                if (test  != null)
                                {
                                    exists = test;
                                    break;
                                }
                                    
                            }


                            if (exists != null)
                        {

                            TreeNode mynode = exists.Nodes.Add("" + hard);
                             if (newHard.ContainsKey(hard.hostname))
                                mynode.BackColor = Color.Yellow;
                             if (!ipToNode.ContainsKey(hard.ip))
                             {
                                 lock (syncRoot)
                                 {
                                     ipToNode.Add(hard.ip, mynode);
                                 }
                             }
                        }else
                        {
                            newHost.Add(hard);
                        }
                        
                    }
                }
                hosts = newHost;
            }
            ;

            lAll.Text = @"Общее количество: " + idToName.Count;
           // lInNet.Text = @"Количество в сети:";


            /*foreach (DataRow h in mset1.hardwares.Rows)
            {
                Hardware hard = new Hardware();
                hard.ip = ""  + h[3];
                hard.desc = (string) h[4];
                hard.hostname = "" + h[1];
                hard.device_id = "" + h[0];
             
                TreeNode mynode = tvTopolog.Nodes.Add("" + hard);

                
                

                tvTopolog.Nodes.Find()
                
            }*/
           
            tvTopolog.EndUpdate();
            tvTopolog.ExpandAll();
            tt.Interrupt();

            
        }




        private void scan()
        {
            while (true)
            {

                try
                { 
                Dictionary<string, TreeNode> copy;
                lock (syncRoot)
                {
                   copy = new Dictionary<string, TreeNode>(ipToNode);
                }

                Invoke(new MethodInvoker(
                      delegate
                          {
                              this.lCount.Text = "0";
                          }
                      ));


                    int count = 0;

                foreach (string ip in copy.Keys)
                {
                    TPing ping = new TPing(ip);


                   

                         Invoke(new MethodInvoker(
                           delegate { this.Text = "Монитор производительности : проверка " + ip;
                           }
                           ));

                    if (ping.getTest().errCode ==0)
                    {
                        if (ipToNode[ip].BackColor != Color.Yellow)
                        {
                             count++;

                            Invoke(new MethodInvoker(
                           delegate { ipToNode[ip].BackColor = Color.GreenYellow;
                                        lCount.Text = "" + count;
                           }
                           ));
        }
                        }
                    }
                
                Invoke(new MethodInvoker(
                           delegate { 
                                        this.Text = "Монитор производительности";
                           }
                           ));
                Thread.Sleep(new TimeSpan(0,5,0));}
                catch(Exception e)
                {
                }
            }
        }

        private TreeNode NodeExists(TreeNode node, string key)
        {
            if (node.Text.Equals(key))
            {
                return node;
            }

            foreach (TreeNode subNode in node.Nodes)
            {
                if (subNode.Text.Equals(key))
                {
                    return subNode;
                }
                if (subNode.Nodes.Count > 0)
                {
                    TreeNode rr =  NodeExists(subNode, key);
                    if (rr != null)
                    {
                        return rr;
                    } 
                }
            }
            return null;
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mset1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mset1.users);
            // TODO: This line of code loads data into the 'mset1.vmon' table. You can move, or remove it, as needed.
            this.vmonTableAdapter.Fill(this.mset1.vmon);
            // TODO: This line of code loads data into the 'mset1.check_types' table. You can move, or remove it, as needed.
            this.check_typesTableAdapter.Fill(this.mset1.check_types);
            // TODO: This line of code loads data into the 'mset1.software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mset1.software);


            //log.ShowDialog();

            toolStripButton3_Click(null, null);
            
            //softwareDataGridView.Dock = DockStyle.Fill;

        }

        private void tvTopolog_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

        private void softwareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            fMon.ShowDialog();
        }

        private void tvTopolog_Click(object sender, EventArgs e)
        {
            
        }

        private void tvTopolog_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void tvTopolog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvTopolog.SelectedNode == null) return;
            Hardware hh = treeHardware[tvTopolog.SelectedNode.Text];
            this.softwareBindingSource.Filter = "id_device = " + hh.device_id;

            this.vmonBindingSource.Filter = "id_device = " + hh.device_id;

            softwareDataGridView.Enabled = true;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.softwareBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mset1);
            }
        }

        private void softwareDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            softwareDataGridView.Rows[e.RowIndex].ErrorText = "";
            softwareDataGridView[9, e.RowIndex].Value = getCurrentDeviceId();

            if (softwareDataGridView[0, e.RowIndex].Value == DBNull.Value)
            {
                softwareDataGridView[0, e.RowIndex].Value = false;
            }


            if (softwareDataGridView == null || softwareDataGridView[1, e.RowIndex] == null || softwareDataGridView[1, e.RowIndex].Value == null)
            {
                e.Cancel = true;
                return;
            }

            if (softwareDataGridView[1, e.RowIndex].Value == DBNull.Value)
            {
                softwareDataGridView.Rows[e.RowIndex].ErrorText = "Вы должны задать тип проверки";
                e.Cancel = true;
                return;
            }

            if ((int.Parse("" + softwareDataGridView[1, e.RowIndex].Value) > 2))
            {

                if (softwareDataGridView[2, e.RowIndex].Value == DBNull.Value)
                {
                    softwareDataGridView.Rows[e.RowIndex].ErrorText = "Вы должны задать порт";
                    e.Cancel = true;
                    return;
                }


                int port;
                bool isNum = int.TryParse("" + softwareDataGridView[2, e.RowIndex].Value, out port);

                if (!isNum || port < 0 || port > 65000)
                {
                    softwareDataGridView.Rows[e.RowIndex].ErrorText = "Неверный номер порта";
                    e.Cancel = true;
                    return;
                }



                if (int.Parse("" + softwareDataGridView[1, e.RowIndex].Value) == 3 ||
                    int.Parse("" + softwareDataGridView[1, e.RowIndex].Value) == 4 ||
                    int.Parse("" + softwareDataGridView[1, e.RowIndex].Value) == 6)
                {

                    if (softwareDataGridView[4, e.RowIndex].Value == DBNull.Value)
                    {
                        softwareDataGridView.Rows[e.RowIndex].ErrorText = "Укажите логин";
                        e.Cancel = true;
                        return;
                    }

                    if (softwareDataGridView[5, e.RowIndex].Value == DBNull.Value)
                    {
                        softwareDataGridView.Rows[e.RowIndex].ErrorText = "Укажите пароль";
                        e.Cancel = true;
                        return;
                    }



                    if (int.Parse("" + softwareDataGridView[1, e.RowIndex].Value) == 6)
                    {
                        if (softwareDataGridView[6, e.RowIndex].Value == DBNull.Value)
                        {
                            softwareDataGridView.Rows[e.RowIndex].ErrorText = "Укажите в опциях имя базы данных";
                            e.Cancel = true;
                            return;
                        }
                    }



                }
            }
            else
            {
                softwareDataGridView[2, e.RowIndex].Value = 0;
            }


            if (softwareDataGridView[3, e.RowIndex].Value == DBNull.Value)
                {
                    softwareDataGridView.Rows[e.RowIndex].ErrorText = "Введите интервал";
                    e.Cancel = true;
                    return;
                }


                int inter;
                bool isInter = int.TryParse("" + softwareDataGridView[3, e.RowIndex].Value, out inter);

                if (!isInter || inter < 10 || inter > 65000)
                {
                    softwareDataGridView.Rows[e.RowIndex].ErrorText = "Неверный интервал. Введите 10 сек. и более";
                    e.Cancel = true;
                    return;
                }

            }
           

        

        public int getCurrentDeviceId()
        {
            if (tvTopolog.SelectedNode != null)
            return int.Parse(treeHardware[tvTopolog.SelectedNode.Text].device_id);

            return -1;
        }

        private void softwareDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fMail.ShowDialog();
        }

        private void softwareDataGridView_Validating(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //softwareDataGridView.Rows.Remove(softwareDataGridView.CurrentRow);
        }

        private void tvTopolog_DoubleClick(object sender, EventArgs e)
        {
            fHard.ShowDialog(getCurrentDeviceId());
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tvTopolog_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
           
                e.Graphics.DrawString(e.Node.Text,
                        e.Node.TreeView.Font,
                        Brushes.Red,
                        e.Bounds);
            
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
