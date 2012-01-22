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
        public FMonitor()
        {
            InitializeComponent();
        }

        private void monitoringBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monitoringBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.monitoring' table. You can move, or remove it, as needed.
            this.monitoringTableAdapter.Fill(this.monitorDataSet.monitoring);

        }
    }
}
