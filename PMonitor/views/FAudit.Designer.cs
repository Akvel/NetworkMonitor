namespace PMonitor.views
{
    partial class FAudit
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
            this.components = new System.ComponentModel.Container();
            this.monitorDataSet = new PMonitor.monitorDataSet();
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditTableAdapter = new PMonitor.monitorDataSetTableAdapters.auditTableAdapter();
            this.tableAdapterManager = new PMonitor.monitorDataSetTableAdapters.TableAdapterManager();
            this.vauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vauditTableAdapter = new PMonitor.monitorDataSetTableAdapters.vauditTableAdapter();
            this.vauditDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vauditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vauditDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monitorDataSet
            // 
            this.monitorDataSet.DataSetName = "monitorDataSet";
            this.monitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataMember = "audit";
            this.auditBindingSource.DataSource = this.monitorDataSet;
            // 
            // auditTableAdapter
            // 
            this.auditTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.action_typesTableAdapter = null;
            this.tableAdapterManager.auditTableAdapter = this.auditTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.check_typesTableAdapter = null;
            this.tableAdapterManager.floorsTableAdapter = null;
            this.tableAdapterManager.hardware_mail_listTableAdapter = null;
            this.tableAdapterManager.hardwaresTableAdapter = null;
            this.tableAdapterManager.monitoringTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.software_mail_listTableAdapter = null;
            this.tableAdapterManager.softwareTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMonitor.monitorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // vauditBindingSource
            // 
            this.vauditBindingSource.DataMember = "vaudit";
            this.vauditBindingSource.DataSource = this.monitorDataSet;
            // 
            // vauditTableAdapter
            // 
            this.vauditTableAdapter.ClearBeforeFill = true;
            // 
            // vauditDataGridView
            // 
            this.vauditDataGridView.AllowUserToAddRows = false;
            this.vauditDataGridView.AllowUserToDeleteRows = false;
            this.vauditDataGridView.AutoGenerateColumns = false;
            this.vauditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vauditDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.vauditDataGridView.DataSource = this.vauditBindingSource;
            this.vauditDataGridView.Location = new System.Drawing.Point(2, 38);
            this.vauditDataGridView.Name = "vauditDataGridView";
            this.vauditDataGridView.ReadOnly = true;
            this.vauditDataGridView.Size = new System.Drawing.Size(715, 420);
            this.vauditDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть журнал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nick";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vauditDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAudit";
            this.Text = "Системный журнал";
            this.Activated += new System.EventHandler(this.FAudit_Activated);
            this.Load += new System.EventHandler(this.FAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vauditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vauditDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private monitorDataSet monitorDataSet;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private monitorDataSetTableAdapters.auditTableAdapter auditTableAdapter;
        private monitorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vauditBindingSource;
        private monitorDataSetTableAdapters.vauditTableAdapter vauditTableAdapter;
        private System.Windows.Forms.DataGridView vauditDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}