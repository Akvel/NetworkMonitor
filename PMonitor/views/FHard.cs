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
    public partial class FHard : Form
    {
        public FHard()
        {
            InitializeComponent();
        }

        private void hardwaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hardwaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FHard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.monitorDataSet.rooms);
            // TODO: This line of code loads data into the 'monitorDataSet.hardwares' table. You can move, or remove it, as needed.
            this.hardwaresTableAdapter.Fill(this.monitorDataSet.hardwares);

        }
    }
}
