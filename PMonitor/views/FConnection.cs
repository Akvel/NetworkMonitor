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
    public partial class FConnection : Form
    {
        private fMain fm;

        public FConnection(fMain pf)
        {
            InitializeComponent();
            fm = pf;
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fm.mset1.users.Where(a => a.nick.Equals(textBox2.Text) && a.pwd.Equals(textBox1.Text)).Count() > 0)
            {
                // TODO: This line of code loads data into the 'mset1.audit' table. You can move, or remove it, as needed.
                fm.auditTableAdapter.Fill(fm.mset1.audit);


                /*monitorDataSet.auditRow row = fm.mset1.audit.NewauditRow();
                row.description = "Успешный вход в систему";
                row.id_action_type = 1;
                row.id_user = ;
                row.dt = ;

              
    
                    fm.mset1.audit.Rows.Add(row);
                    fm.tableAdapterManager.UpdateAll(fm.mset1);*/

                PMonitor.monitorDataSetTableAdapters.auditTableAdapter hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.auditTableAdapter();
                hardwaresTableAdapter.Insert("Успешный вход в систему", 1, fm.mset1.users.Where(
                    a => a.nick.Equals(textBox2.Text) && a.pwd.Equals(textBox1.Text)).First().id, DateTime.Now);
                


                fm.tableAdapterManager.UpdateAll(fm.mset1);
                Close();
            }else
            {

                

                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }}
