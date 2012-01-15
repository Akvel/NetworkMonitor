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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.monitorDataSet.roles);
            // TODO: This line of code loads data into the 'monitorDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.monitorDataSet.users);

        }
    }
}
