using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMonitor.views
{
    public partial class FMonitor : Form
    {
        private object softwareTableAdapter;

        public FMonitor()
        {
            InitializeComponent();
        }

        private void monitoringBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void FMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.vmon' table. You can move, or remove it, as needed.
            this.vmonTableAdapter.Fill(this.monitorDataSet.vmon);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Report.generate(monitorDataSet.monitoring);
        }

        private void monitoringDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.vmonTableAdapter.Fill(this.monitorDataSet.vmon);
        }

        private void vmonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
