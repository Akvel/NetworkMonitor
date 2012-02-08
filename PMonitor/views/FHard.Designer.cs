namespace PMonitor.views
{
    partial class FHard
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
            System.Windows.Forms.Label dns_nameLabel;
            System.Windows.Forms.Label is_snmpLabel;
            System.Windows.Forms.Label ip_addressLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label id_roomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHard));
            System.Windows.Forms.Label id_parentLabel;
            this.monitorDataSet = new PMonitor.monitorDataSet();
            this.hardwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter();
            this.tableAdapterManager = new PMonitor.monitorDataSetTableAdapters.TableAdapterManager();
            this.roomsTableAdapter = new PMonitor.monitorDataSetTableAdapters.roomsTableAdapter();
            this.hardwaresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hardwaresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.dns_nameTextBox = new System.Windows.Forms.TextBox();
            this.is_snmpTextBox = new System.Windows.Forms.TextBox();
            this.ip_addressTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.id_roomComboBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.id_parentComboBox = new System.Windows.Forms.ComboBox();
            this.monitorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwaresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardwaresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            dns_nameLabel = new System.Windows.Forms.Label();
            is_snmpLabel = new System.Windows.Forms.Label();
            ip_addressLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            id_roomLabel = new System.Windows.Forms.Label();
            id_parentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingNavigator)).BeginInit();
            this.hardwaresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dns_nameLabel
            // 
            dns_nameLabel.AutoSize = true;
            dns_nameLabel.Location = new System.Drawing.Point(12, 43);
            dns_nameLabel.Name = "dns_nameLabel";
            dns_nameLabel.Size = new System.Drawing.Size(72, 13);
            dns_nameLabel.TabIndex = 3;
            dns_nameLabel.Text = "Сетевое имя";
            // 
            // is_snmpLabel
            // 
            is_snmpLabel.AutoSize = true;
            is_snmpLabel.Location = new System.Drawing.Point(39, 169);
            is_snmpLabel.Name = "is_snmpLabel";
            is_snmpLabel.Size = new System.Drawing.Size(45, 13);
            is_snmpLabel.TabIndex = 5;
            is_snmpLabel.Text = "is snmp:";
            is_snmpLabel.Visible = false;
            // 
            // ip_addressLabel
            // 
            ip_addressLabel.AutoSize = true;
            ip_addressLabel.Location = new System.Drawing.Point(12, 76);
            ip_addressLabel.Name = "ip_addressLabel";
            ip_addressLabel.Size = new System.Drawing.Size(50, 13);
            ip_addressLabel.TabIndex = 7;
            ip_addressLabel.Text = "IP адрес";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 143);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(57, 13);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Описание";
            // 
            // id_roomLabel
            // 
            id_roomLabel.AutoSize = true;
            id_roomLabel.Location = new System.Drawing.Point(12, 108);
            id_roomLabel.Name = "id_roomLabel";
            id_roomLabel.Size = new System.Drawing.Size(82, 13);
            id_roomLabel.TabIndex = 11;
            id_roomLabel.Text = "Расположение";
            // 
            // monitorDataSet
            // 
            this.monitorDataSet.DataSetName = "monitorDataSet";
            this.monitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hardwaresBindingSource
            // 
            this.hardwaresBindingSource.DataMember = "hardwares";
            this.hardwaresBindingSource.DataSource = this.monitorDataSet;
            // 
            // hardwaresTableAdapter
            // 
            this.hardwaresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.action_typesTableAdapter = null;
            this.tableAdapterManager.auditTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.check_typesTableAdapter = null;
            this.tableAdapterManager.floorsTableAdapter = null;
            this.tableAdapterManager.hardware_mail_listTableAdapter = null;
            this.tableAdapterManager.hardwaresTableAdapter = this.hardwaresTableAdapter;
            this.tableAdapterManager.monitoringTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.software_mail_listTableAdapter = null;
            this.tableAdapterManager.softwareTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMonitor.monitorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // hardwaresBindingNavigator
            // 
            this.hardwaresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hardwaresBindingNavigator.BindingSource = this.hardwaresBindingSource;
            this.hardwaresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hardwaresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hardwaresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hardwaresBindingNavigatorSaveItem});
            this.hardwaresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hardwaresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hardwaresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hardwaresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hardwaresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hardwaresBindingNavigator.Name = "hardwaresBindingNavigator";
            this.hardwaresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hardwaresBindingNavigator.Size = new System.Drawing.Size(301, 25);
            this.hardwaresBindingNavigator.TabIndex = 0;
            this.hardwaresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hardwaresBindingNavigatorSaveItem
            // 
            this.hardwaresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hardwaresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hardwaresBindingNavigatorSaveItem.Image")));
            this.hardwaresBindingNavigatorSaveItem.Name = "hardwaresBindingNavigatorSaveItem";
            this.hardwaresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hardwaresBindingNavigatorSaveItem.Text = "Save Data";
            this.hardwaresBindingNavigatorSaveItem.Click += new System.EventHandler(this.hardwaresBindingNavigatorSaveItem_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hardwaresBindingSource, "id", true));
            this.idLabel1.Location = new System.Drawing.Point(7, 20);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(77, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            this.idLabel1.Visible = false;
            // 
            // dns_nameTextBox
            // 
            this.dns_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hardwaresBindingSource, "dns_name", true));
            this.dns_nameTextBox.Location = new System.Drawing.Point(95, 40);
            this.dns_nameTextBox.Name = "dns_nameTextBox";
            this.dns_nameTextBox.Size = new System.Drawing.Size(185, 20);
            this.dns_nameTextBox.TabIndex = 4;
            // 
            // is_snmpTextBox
            // 
            this.is_snmpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hardwaresBindingSource, "is_snmp", true));
            this.is_snmpTextBox.Location = new System.Drawing.Point(95, 166);
            this.is_snmpTextBox.Name = "is_snmpTextBox";
            this.is_snmpTextBox.Size = new System.Drawing.Size(0, 20);
            this.is_snmpTextBox.TabIndex = 6;
            this.is_snmpTextBox.Text = "False";
            // 
            // ip_addressTextBox
            // 
            this.ip_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hardwaresBindingSource, "ip_address", true));
            this.ip_addressTextBox.Location = new System.Drawing.Point(95, 73);
            this.ip_addressTextBox.Name = "ip_addressTextBox";
            this.ip_addressTextBox.Size = new System.Drawing.Size(185, 20);
            this.ip_addressTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hardwaresBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(95, 140);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(185, 20);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // id_roomComboBox
            // 
            this.id_roomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "name", true));
            this.id_roomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hardwaresBindingSource, "id_room", true));
            this.id_roomComboBox.DataSource = this.roomsBindingSource1;
            this.id_roomComboBox.DisplayMember = "name";
            this.id_roomComboBox.FormattingEnabled = true;
            this.id_roomComboBox.Location = new System.Drawing.Point(95, 105);
            this.id_roomComboBox.Name = "id_roomComboBox";
            this.id_roomComboBox.Size = new System.Drawing.Size(185, 21);
            this.id_roomComboBox.TabIndex = 12;
            this.id_roomComboBox.ValueMember = "id";
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "rooms";
            this.roomsBindingSource1.DataSource = this.monitorDataSet;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.monitorDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_parentLabel
            // 
            id_parentLabel.AutoSize = true;
            id_parentLabel.Location = new System.Drawing.Point(38, 182);
            id_parentLabel.Name = "id_parentLabel";
            id_parentLabel.Size = new System.Drawing.Size(51, 13);
            id_parentLabel.TabIndex = 13;
            id_parentLabel.Text = "id parent:";
            // 
            // id_parentComboBox
            // 
            this.id_parentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hardwaresBindingSource, "id_parent", true));
            this.id_parentComboBox.DataSource = this.hardwaresBindingSource2;
            this.id_parentComboBox.DisplayMember = "dns_name";
            this.id_parentComboBox.FormattingEnabled = true;
            this.id_parentComboBox.Location = new System.Drawing.Point(95, 179);
            this.id_parentComboBox.Name = "id_parentComboBox";
            this.id_parentComboBox.Size = new System.Drawing.Size(185, 21);
            this.id_parentComboBox.TabIndex = 14;
            this.id_parentComboBox.ValueMember = "id";
            // 
            // monitorDataSetBindingSource
            // 
            this.monitorDataSetBindingSource.DataSource = this.monitorDataSet;
            this.monitorDataSetBindingSource.Position = 0;
            // 
            // hardwaresBindingSource1
            // 
            this.hardwaresBindingSource1.DataMember = "hardwares";
            this.hardwaresBindingSource1.DataSource = this.monitorDataSetBindingSource;
            // 
            // hardwaresBindingSource2
            // 
            this.hardwaresBindingSource2.DataMember = "hardwares";
            this.hardwaresBindingSource2.DataSource = this.monitorDataSet;
            // 
            // FHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(id_parentLabel);
            this.Controls.Add(this.id_parentComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(dns_nameLabel);
            this.Controls.Add(this.dns_nameTextBox);
            this.Controls.Add(is_snmpLabel);
            this.Controls.Add(this.is_snmpTextBox);
            this.Controls.Add(ip_addressLabel);
            this.Controls.Add(this.ip_addressTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(id_roomLabel);
            this.Controls.Add(this.id_roomComboBox);
            this.Controls.Add(this.hardwaresBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "FHard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование";
            this.Load += new System.EventHandler(this.FHard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingNavigator)).EndInit();
            this.hardwaresBindingNavigator.ResumeLayout(false);
            this.hardwaresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwaresBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private monitorDataSet monitorDataSet;
        private System.Windows.Forms.BindingSource hardwaresBindingSource;
        private monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter;
        private monitorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hardwaresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hardwaresBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox dns_nameTextBox;
        private System.Windows.Forms.TextBox is_snmpTextBox;
        private System.Windows.Forms.TextBox ip_addressTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox id_roomComboBox;
        private monitorDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox id_parentComboBox;
        private System.Windows.Forms.BindingSource hardwaresBindingSource1;
        private System.Windows.Forms.BindingSource monitorDataSetBindingSource;
        private System.Windows.Forms.BindingSource hardwaresBindingSource2;
    }
}