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
        }

        private void button1_Click(object sender, EventArgs e)
        {
               new Thread(task.scan).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task.needStop = true;
        }
    }
}
