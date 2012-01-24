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
        private FScan fScan ;
        private FHard fHard = new FHard();
        private FMonitor fMon = new FMonitor();


        private readonly Dictionary<string, Hardware> treeHardware = new Dictionary<string, Hardware>();

        public fMain()
        {
            InitializeComponent();


            fScan = new FScan(this);
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
            fHard.ShowDialog(getCurrentDeviceId());
            toolStripButton3_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter();

            hardwaresTableAdapter.Fill(mset1.hardwares);
            var hArr =from myRow in mset1.hardwares.AsEnumerable()
                select myRow;

            treeHardware.Clear();
            tvTopolog.Nodes.Clear();

            foreach (DataRow h in mset1.hardwares.Rows)
            {
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
            // TODO: This line of code loads data into the 'mset1.check_types' table. You can move, or remove it, as needed.
            this.check_typesTableAdapter.Fill(this.mset1.check_types);
            // TODO: This line of code loads data into the 'mset1.software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mset1.software);


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
            //lbLog.Items.Clear();
            //lbLog.Items.Add(">>" + tvTopolog.SelectedNode);

            if (tvTopolog.SelectedNode == null) return;

            Hardware hh = treeHardware[tvTopolog.SelectedNode.Text];

            //lbLog.Items.Add(tvTopolog.SelectedNode.ToString() + "  " + hh.device_id);

            this.softwareBindingSource.Filter = "id_device = " + hh.device_id;
            // this.softwareBindingSource.
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.softwareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mset1);
        }

        private void softwareDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            softwareDataGridView[5, e.RowIndex].Value = getCurrentDeviceId();
            //if (softwareDataGridView[5, e.RowIndex].Value == DBNull.Value)
            //{
            //    dgv.Rows[e.RowIndex].ErrorText = "You must enter a value for this field!";

            // Tell the DataGridView not to accept this row
            //   e.Cancel = true;
            //}

        }



        public int getCurrentDeviceId()
        {
            return int.Parse(treeHardware[tvTopolog.SelectedNode.Text].device_id);
        }
    }
}
