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
          //  if (ValidateChildren())
           /// {
             

            ((DataRowView) hardwaresBindingSource.Current)["id_parent"] =
                Convert.ToInt32(id_parentComboBox.SelectedValue);

            Boolean chiled = false;
            //var a
            int currObj = (int) ((DataRowView) hardwaresBindingSource.Current)["id"];
            int parentId = Convert.IsDBNull(((DataRowView)hardwaresBindingSource.Current)["id_parent"]) ? 0 : (int) ((DataRowView)hardwaresBindingSource.Current)["id_parent"]
            ;
            monitorDataSet.hardwaresRow row = monitorDataSet.hardwares.Where(b => b.id == parentId).First();
            while (row.id_parent != null || !Convert.IsDBNull(row.id_parent))
            {
                int currParent = !Convert.IsDBNull(row.id_parent) ? row.id_parent : 0;

                if (monitorDataSet.hardwares.Where(b => b.id == currParent).Count() == 0)
                {
                    break;
                }

                row = monitorDataSet.hardwares.Where(b => b.id == currParent).First();
                if (row.id == parentId || row.id == currObj)
                {
                    chiled = true;
                    break;
                }
            }
            ;



            if (chiled)
            {
                MessageBox.Show("Ошибка при связывание. Закольцованность связей");
                return;
            }

            //id_parentComboBox.SelectedItem.


                is_snmpTextBox.Text = "False";
                this.hardwaresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.monitorDataSet);



                if (!fMain.newHard.ContainsKey(dns_nameTextBox.Text))
                fMain.newHard.Add(dns_nameTextBox.Text,1);
            //}
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
