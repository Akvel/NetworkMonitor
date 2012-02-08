namespace PMonitor.views
{
    partial class FScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bScan = new System.Windows.Forms.Button();
            this.cbFind = new System.Windows.Forms.CheckedListBox();
            this.tbStart = new System.Windows.Forms.MaskedTextBox();
            this.tbStop = new System.Windows.Forms.MaskedTextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bScan
            // 
            this.bScan.Location = new System.Drawing.Point(226, 23);
            this.bScan.Name = "bScan";
            this.bScan.Size = new System.Drawing.Size(133, 38);
            this.bScan.TabIndex = 2;
            this.bScan.Text = "Сканировать";
            this.bScan.UseVisualStyleBackColor = true;
            this.bScan.Click += new System.EventHandler(this.bScan_Click);
            // 
            // cbFind
            // 
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Location = new System.Drawing.Point(0, 87);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(614, 214);
            this.cbFind.TabIndex = 3;
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(13, 23);
            this.tbStart.Mask = "990\\.990\\.990\\.990";
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 20);
            this.tbStart.TabIndex = 4;
            this.tbStart.Text = "192168001001";
            this.tbStart.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbStart_MaskInputRejected);
            this.tbStart.Validating += new System.ComponentModel.CancelEventHandler(this.tbStart_Validating);
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(120, 23);
            this.tbStop.Mask = "990\\.990\\.990\\.990";
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(100, 20);
            this.tbStop.TabIndex = 5;
            this.tbStop.Text = "192168001254";
            this.tbStop.Validating += new System.ComponentModel.CancelEventHandler(this.tbStart_Validating);
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(0, 303);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(615, 69);
            this.lbLog.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Внести выделенные устройства";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Результат поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Диапазон IP адресов для сканирования";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.cbFind);
            this.Controls.Add(this.bScan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск нового оборудования";
            this.Load += new System.EventHandler(this.FScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bScan;
        private System.Windows.Forms.CheckedListBox cbFind;
        private System.Windows.Forms.MaskedTextBox tbStart;
        public System.Windows.Forms.MaskedTextBox tbStop;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}