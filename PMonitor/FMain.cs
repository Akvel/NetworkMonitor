using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMonitor.views;

namespace PMonitor
{
    public partial class fMain : Form
    {
        FUser fUser = new FUser();

        public fMain()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fUser.ShowDialog();
        }
    }
}
