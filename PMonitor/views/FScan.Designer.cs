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
            this.SuspendLayout();
            // 
            // bScan
            // 
            this.bScan.Location = new System.Drawing.Point(226, 13);
            this.bScan.Name = "bScan";
            this.bScan.Size = new System.Drawing.Size(133, 20);
            this.bScan.TabIndex = 2;
            this.bScan.Text = "Сканировать";
            this.bScan.UseVisualStyleBackColor = true;
            this.bScan.Click += new System.EventHandler(this.bScan_Click);
            // 
            // cbFind
            // 
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Location = new System.Drawing.Point(0, 57);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(522, 244);
            this.cbFind.TabIndex = 3;
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(13, 12);
            this.tbStart.Mask = "990\\.990\\.990\\.990";
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 20);
            this.tbStart.TabIndex = 4;
            this.tbStart.Text = "192168001000";
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(120, 12);
            this.tbStop.Mask = "990\\.990\\.990\\.990";
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(100, 20);
            this.tbStop.TabIndex = 5;
            this.tbStop.Text = "192168001255";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(0, 303);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(522, 69);
            this.lbLog.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить выбранные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Результат поиска";
            // 
            // FScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 372);
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
            this.Text = "Поиск нового оборудования";
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
    }
}