using System.Linq;

namespace PMonitor.views
{
    partial class FMonitor
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
            this.vmonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vmonTableAdapter = new PMonitor.monitorDataSetTableAdapters.vmonTableAdapter();
            this.vmonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vmon_groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vmon_groupTableAdapter = new PMonitor.monitorDataSetTableAdapters.vmon_groupTableAdapter();
            this.tableAdapterManager = new PMonitor.monitorDataSetTableAdapters.TableAdapterManager();
            this.vmon_groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vmon_groupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmonDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitorDataSet
            // 
            this.monitorDataSet.DataSetName = "monitorDataSet";
            this.monitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vmonBindingSource
            // 
            this.vmonBindingSource.DataMember = "vmon";
            this.vmonBindingSource.DataSource = this.monitorDataSet;
            // 
            // vmonTableAdapter
            // 
            this.vmonTableAdapter.ClearBeforeFill = true;
            // 
            // vmonDataGridView
            // 
            this.vmonDataGridView.AllowUserToAddRows = false;
            this.vmonDataGridView.AllowUserToDeleteRows = false;
            this.vmonDataGridView.AutoGenerateColumns = false;
            this.vmonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vmonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.vmonDataGridView.DataSource = this.vmonBindingSource;
            this.vmonDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vmonDataGridView.Location = new System.Drawing.Point(0, 275);
            this.vmonDataGridView.Name = "vmonDataGridView";
            this.vmonDataGridView.ReadOnly = true;
            this.vmonDataGridView.Size = new System.Drawing.Size(847, 237);
            this.vmonDataGridView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.vmonDataGridView, "Сводная талица по всем событиям");
            this.vmonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vmonDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dns_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ip_address";
            this.dataGridViewTextBoxColumn4.HeaderText = "IP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Expr2";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Событие";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valuee";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn5.HeaderText = "description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Кабинет";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_room";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_room";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 43);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.toolTip1.SetToolTip(this.button1, "Нажмите чтобы закрыть окно");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vmon_groupBindingSource
            // 
            this.vmon_groupBindingSource.DataSource = this.monitorDataSet;
            this.vmon_groupBindingSource.Position = 0;
            // 
            // vmon_groupTableAdapter
            // 
            this.vmon_groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.action_typesTableAdapter = null;
            this.tableAdapterManager.auditTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.check_typesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // vmon_groupBindingSource1
            // 
            this.vmon_groupBindingSource1.DataMember = "vmon_group";
            this.vmon_groupBindingSource1.DataSource = this.monitorDataSet;
            // 
            // vmon_groupDataGridView
            // 
            this.vmon_groupDataGridView.AllowUserToAddRows = false;
            this.vmon_groupDataGridView.AllowUserToDeleteRows = false;
            this.vmon_groupDataGridView.AutoGenerateColumns = false;
            this.vmon_groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vmon_groupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16});
            this.vmon_groupDataGridView.DataSource = this.vmon_groupBindingSource1;
            this.vmon_groupDataGridView.Location = new System.Drawing.Point(0, 41);
            this.vmon_groupDataGridView.Name = "vmon_groupDataGridView";
            this.vmon_groupDataGridView.ReadOnly = true;
            this.vmon_groupDataGridView.Size = new System.Drawing.Size(847, 198);
            this.vmon_groupDataGridView.TabIndex = 2;
            this.toolTip1.SetToolTip(this.vmon_groupDataGridView, "Аналитическая таблица по оборудованию");
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "dns_name";
            this.dataGridViewTextBoxColumn15.HeaderText = "Хост";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Тест";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn12.HeaderText = "Результат";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "what_to_do";
            this.dataGridViewTextBoxColumn13.HeaderText = "Действия";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "dt";
            this.dataGridViewTextBoxColumn14.HeaderText = "Дата(макс.)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn16.HeaderText = "Общее количество ошибок";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 24);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сводная талица по всем событиям";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Аналитическая таблица по оборудованию";
            // 
            // FMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vmon_groupDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vmonDataGridView);
            this.Name = "FMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг";
            this.Load += new System.EventHandler(this.FMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmonDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmon_groupDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private monitorDataSet monitorDataSet;
        private System.Windows.Forms.BindingSource vmonBindingSource;
        private monitorDataSetTableAdapters.vmonTableAdapter vmonTableAdapter;
        private System.Windows.Forms.DataGridView vmonDataGridView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vmon_groupBindingSource;
        private monitorDataSetTableAdapters.vmon_groupTableAdapter vmon_groupTableAdapter;
        private monitorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vmon_groupBindingSource1;
        private System.Windows.Forms.DataGridView vmon_groupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}