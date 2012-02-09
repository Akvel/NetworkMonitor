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
    public partial class FAudit : Form
    {
        public FAudit()
        {
            InitializeComponent();
        }

        private void auditBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.auditBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.monitorDataSet);

        }

        private void FAudit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDataSet.vaudit' table. You can move, or remove it, as needed.
            this.vauditTableAdapter.Fill(this.monitorDataSet.vaudit);
            // TODO: This line of code loads data into the 'monitorDataSet.audit' table. You can move, or remove it, as needed.
            this.auditTableAdapter.Fill(this.monitorDataSet.audit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FAudit_Activated(object sender, EventArgs e)
        {
            this.vauditTableAdapter.Fill(this.monitorDataSet.vaudit);
        }
    }
}
