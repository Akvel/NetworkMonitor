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
        private int deviceId;


        public FHard()
        {
            InitializeComponent();
        }

        private void hardwaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.hardwaresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.monitorDataSet);
            }

        }

        private void FHard_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'monitorDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.monitorDataSet.rooms);
            // TODO: This line of code loads data into the 'monitorDataSet.hardwares' table. You can move, or remove it, as needed.
           // this.hardwaresTableAdapter.Fill(this.monitorDataSet.hardwares);


           


          // hardwaresBindingSource.Position = hardwaresBindingSource.Find("id", deviceId);

        }

        public void ShowDialog(int deviceID)
        {
            deviceId = deviceID;
            //hardwaresBindingSource.Position = this.bindingSource)
            //hardwaresBindingSource.Current

            this.hardwaresTableAdapter.Fill(this.monitorDataSet.hardwares);
            hardwaresBindingSource.Position = hardwaresBindingSource.Find("Id", deviceId);
            this.ShowDialog();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
