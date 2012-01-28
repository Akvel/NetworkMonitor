using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PService
{
    public partial class FMain : Form
    {
        private readonly PTask task;

        public FMain()
        {
            InitializeComponent();

            task = new PTask(this);
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
               new Thread(task.scan).Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task.needStop = true;

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
