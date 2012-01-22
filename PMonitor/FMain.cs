using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PData.data;
using PData.monitorDataSetTableAdapters;
using PMonitor.views;

namespace PMonitor
{
    public partial class fMain : Form
    {
        private FUser fUser = new FUser();
        private FScan fScan = new FScan();
        private FHard fHard = new FHard();


        private readonly Dictionary<string, Hardware> treeHardware = new Dictionary<string, Hardware>();

        public fMain()
        {
            InitializeComponent();
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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fHard.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter();

            hardwaresTableAdapter.Fill(mset1.hardwares);
            //DataTable hardware = mset1.hardwares..Tables["hardwares"];

           // DataRow[] rows = hardware.Select();
           

            lbLog.Items.Add(">>" +  mset1.Tables["hardwares"].Rows.Count);

            foreach (DataTable VARIABLE in mset1.Tables)
            {
                lbLog.Items.Add(">>" + VARIABLE.Rows.Count);
            }

            var hArr =from myRow in mset1.hardwares.AsEnumerable()
                //where myRow.Field<int>("RowNo") == 1
                select myRow;


            lbLog.Items.Add(">>" + hArr + " " + hArr.Count());
            treeHardware.Clear();
            ;

            foreach (DataRow h in mset1.hardwares.Rows)
            {
                //lbLog.Items.Add(">>>>>>>" + h["ip"] + " " + h[0]);

                Hardware hard = new Hardware();
                hard.ip = ""  + h[3];
                hard.desc = (string) h[4];
                hard.hostname = "" + h[1];
                hard.device_id = "" + h[0];

                tvTopolog.Nodes.Add("" + hard);

                treeHardware.Add("" + hard, hard);
            }

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mset1.software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mset1.software);

        }

        private void tvTopolog_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvTopolog.SelectedNode == null) return;

            Hardware hh = treeHardware[tvTopolog.SelectedNode.Text];

            lbLog.Items.Add(tvTopolog.SelectedNode.ToString() + "  " + hh);

            this.softwareBindingSource.Filter = "id_device = " + hh.device_id;
        }
    }
}
