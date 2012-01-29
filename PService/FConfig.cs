using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PService
{
    public partial class FConfig : Form
    {
        public FConfig()
        {
            InitializeComponent();
        }

        private void FConfig_Load(object sender, EventArgs e)
        {

        }

        private void tbServer_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (((TextBox)sender).Text.Length == 0)
            {
                error = "Поле почтового сервера не может быть пустым";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Properties.Settings.Default.smtp_server = tbServer.Text;
                Properties.Settings.Default.smpt_port = int.Parse(tbPort.Text);
                Properties.Settings.Default.system_mail = tbLogin.Text;
                Properties.Settings.Default.mail_password = tbPassword.Text;

                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void tbPort_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            try
            {
                int.Parse(tbPort.Text);
            }catch(Exception e1)
            {
                error = "Введите число";
                e.Cancel = true;
            }
           
            errorProvider1.SetError((Control)sender, error);
        }
    }
}
