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
    public partial class FSMail : Form
    {
        public FSMail()
        {
            InitializeComponent();
        }

        private void software_mail_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.software_mail_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FSMail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.monitorDataSet.software);
            // TODO: This line of code loads data into the 'monitorDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.monitorDataSet.users);
            // TODO: This line of code loads data into the 'monitorDataSet.software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.monitorDataSet.software);
            // TODO: This line of code loads data into the 'monitorDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.monitorDataSet.users);
            // TODO: This line of code loads data into the 'monitorDataSet.software_mail_list' table. You can move, or remove it, as needed.
            this.software_mail_listTableAdapter.Fill(this.monitorDataSet.software_mail_list);

        }
    }
}
