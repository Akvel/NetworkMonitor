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
    public partial class FHMail : Form
    {
        public FHMail()
        {
            InitializeComponent();
        }

        private void hardware_mail_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hardware_mail_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FHMail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.hardwares' table. You can move, or remove it, as needed.
            this.hardwaresTableAdapter.Fill(this.monitorDataSet.hardwares);
            // TODO: This line of code loads data into the 'monitorDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.monitorDataSet.users);
            // TODO: This line of code loads data into the 'monitorDataSet.hardware_mail_list' table. You can move, or remove it, as needed.
            this.hardware_mail_listTableAdapter.Fill(this.monitorDataSet.hardware_mail_list);

        }
    }
}
