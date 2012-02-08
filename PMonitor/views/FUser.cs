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

        MaskedTextBox mtb = new MaskedTextBox();

        TextBox passwd = new TextBox();



        

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

        private void usersDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           

        }

        private void usersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void usersDataGridView_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void usersDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            
            TextBox t = e.Control as TextBox;
            if (t != null)
            {
                t.Text = "" + e.CellStyle.Tag;
                t.UseSystemPasswordChar = true;
            }
        }

        private void usersDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                    e.CellStyle.Tag = e.Value;
                    e.Value = new String('*', e.Value.ToString().Length);
            }

      


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
