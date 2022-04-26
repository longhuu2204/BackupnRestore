namespace N18DCCN109_BACKUP_RESTORE
{
    partial class mainForm
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
            this.dataGridBackup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCSDL = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenDevice = new System.Windows.Forms.TextBox();
            this.lvDatabaseList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thamSốTheoThờiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoDeviceSaoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBackup)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBackup
            // 
            this.dataGridBackup.AutoGenerateColumns = false;
            this.dataGridBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridBackup.DataSource = this.backupBindingSource1;
            this.dataGridBackup.Location = new System.Drawing.Point(232, 57);
            this.dataGridBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridBackup.Name = "dataGridBackup";
            this.dataGridBackup.ReadOnly = true;
            this.dataGridBackup.RowHeadersWidth = 51;
            this.dataGridBackup.RowTemplate.Height = 24;
            this.dataGridBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBackup.Size = new System.Drawing.Size(482, 375);
            this.dataGridBackup.TabIndex = 8;
            this.dataGridBackup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBackup_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên CSDL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Device: ";
            // 
            // txtTenCSDL
            // 
            this.txtTenCSDL.Location = new System.Drawing.Point(290, 9);
            this.txtTenCSDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenCSDL.Name = "txtTenCSDL";
            this.txtTenCSDL.Size = new System.Drawing.Size(124, 20);
            this.txtTenCSDL.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(464, 9);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(38, 20);
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtTenDevice
            // 
            this.txtTenDevice.Location = new System.Drawing.Point(562, 9);
            this.txtTenDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDevice.Name = "txtTenDevice";
            this.txtTenDevice.Size = new System.Drawing.Size(144, 20);
            this.txtTenDevice.TabIndex = 14;
            // 
            // lvDatabaseList
            // 
            this.lvDatabaseList.FullRowSelect = true;
            this.lvDatabaseList.GridLines = true;
            this.lvDatabaseList.HideSelection = false;
            this.lvDatabaseList.Location = new System.Drawing.Point(11, 27);
            this.lvDatabaseList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvDatabaseList.MultiSelect = false;
            this.lvDatabaseList.Name = "lvDatabaseList";
            this.lvDatabaseList.ShowItemToolTips = true;
            this.lvDatabaseList.Size = new System.Drawing.Size(208, 390);
            this.lvDatabaseList.TabIndex = 15;
            this.lvDatabaseList.UseCompatibleStateImageBehavior = false;
            this.lvDatabaseList.View = System.Windows.Forms.View.List;
            this.lvDatabaseList.Click += new System.EventHandler(this.lvDatabaseList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh sách CSDL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phụcHồiToolStripMenuItem,
            this.thamSốTheoThờiGianToolStripMenuItem,
            this.tạoDeviceSaoLưuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.phụcHồiToolStripMenuItem.Text = "Phục hồi";
            this.phụcHồiToolStripMenuItem.Click += new System.EventHandler(this.phụcHồiToolStripMenuItem_Click);
            // 
            // thamSốTheoThờiGianToolStripMenuItem
            // 
            this.thamSốTheoThờiGianToolStripMenuItem.Name = "thamSốTheoThờiGianToolStripMenuItem";
            this.thamSốTheoThờiGianToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.thamSốTheoThờiGianToolStripMenuItem.Text = "Tham số theo thời gian";
            // 
            // tạoDeviceSaoLưuToolStripMenuItem
            // 
            this.tạoDeviceSaoLưuToolStripMenuItem.Name = "tạoDeviceSaoLưuToolStripMenuItem";
            this.tạoDeviceSaoLưuToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tạoDeviceSaoLưuToolStripMenuItem.Text = "Tạo Device sao lưu";
            this.tạoDeviceSaoLưuToolStripMenuItem.Click += new System.EventHandler(this.tạoDeviceSaoLưuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenDevice);
            this.panel1.Controls.Add(this.lvDatabaseList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenCSDL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 418);
            this.panel1.TabIndex = 18;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "STT";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên bản backup";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backupBindingSource1
            // 
            this.backupBindingSource1.DataSource = typeof(N18DCCN109_BACKUP_RESTORE.DTO.Backup);
            // 
            // backupBindingSource
            // 
            this.backupBindingSource.DataSource = typeof(N18DCCN109_BACKUP_RESTORE.DTO.Backup);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.dataGridBackup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "Backup and Restore";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBackup)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCSDL;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenDevice;
        private System.Windows.Forms.ListView lvDatabaseList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thamSốTheoThờiGianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoDeviceSaoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource backupBindingSource;
        private System.Windows.Forms.BindingSource backupBindingSource1;
    }
}