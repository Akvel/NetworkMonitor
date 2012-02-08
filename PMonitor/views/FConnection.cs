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
            fm = pf;
        }


        public FConnection()
        {
            InitializeComponent();
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
                Close();
            }else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }}
