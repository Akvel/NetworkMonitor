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


            ITypedList typedList = hardwaresBindingSource as ITypedList;

 
            PropertyDescriptorCollection props;

            if (typedList != null) // obtain the PropertyDescriptors from the list
            {
                props = typedList.GetItemProperties(null);
            }
            else // use the TypeDescriptor on the first element of the list
            {
                props = TypeDescriptor.GetProperties(hardwaresBindingSource[0]);
            }


           //ardwaresBindingSource.Position = hardwaresBindingSource.Find("id", deviceId);

        }

        public void ShowDialog(int deviceID)
        {
            deviceId = deviceID;
            //hardwaresBindingSource.Position = this.bindingSource)
            hardwaresBindingSource.Position = hardwaresBindingSource.Find("id", deviceId);
            this.ShowDialog();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }
    }
}
