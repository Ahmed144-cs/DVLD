namespace DVLD
{
    partial class LocalDrivingLicenseApplications
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
            this.labelCountRecord = new System.Windows.Forms.Label();
            this.TbFiltorInput = new System.Windows.Forms.TextBox();
            this.CbFiltorBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.BtnCloas = new System.Windows.Forms.Button();
            this.DgvLocalDrivLicApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalDrivLicApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(144, 707);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 17;
            this.labelCountRecord.Text = "???";
            this.labelCountRecord.Click += new System.EventHandler(this.labelCountRecord_Click);
            // 
            // TbFiltorInput
            // 
            this.TbFiltorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFiltorInput.Location = new System.Drawing.Point(294, 192);
            this.TbFiltorInput.Name = "TbFiltorInput";
            this.TbFiltorInput.Size = new System.Drawing.Size(196, 30);
            this.TbFiltorInput.TabIndex = 16;
            this.TbFiltorInput.Visible = false;
            this.TbFiltorInput.TextChanged += new System.EventHandler(this.TbFiltorInput_TextChanged);
            this.TbFiltorInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFiltorInput_KeyPress);
            // 
            // CbFiltorBy
            // 
            this.CbFiltorBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltorBy.FormattingEnabled = true;
            this.CbFiltorBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "Name",
            "National No",
            "Status"});
            this.CbFiltorBy.Location = new System.Drawing.Point(132, 192);
            this.CbFiltorBy.Name = "CbFiltorBy";
            this.CbFiltorBy.Size = new System.Drawing.Size(156, 33);
            this.CbFiltorBy.TabIndex = 15;
            this.CbFiltorBy.SelectedIndexChanged += new System.EventHandler(this.CbFiltorBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtor by : ";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(14, 704);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 12;
            this.labelRecords.Text = "Recordes:";
            // 
            // BtnCloas
            // 
            this.BtnCloas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.Location = new System.Drawing.Point(1070, 697);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 43);
            this.BtnCloas.TabIndex = 11;
            this.BtnCloas.Text = "close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            this.BtnCloas.Click += new System.EventHandler(this.BtnCloas_Click);
            // 
            // DgvLocalDrivLicApp
            // 
            this.DgvLocalDrivLicApp.AllowUserToAddRows = false;
            this.DgvLocalDrivLicApp.AllowUserToDeleteRows = false;
            this.DgvLocalDrivLicApp.AllowUserToOrderColumns = true;
            this.DgvLocalDrivLicApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLocalDrivLicApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLocalDrivLicApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalDrivLicApp.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvLocalDrivLicApp.Location = new System.Drawing.Point(14, 237);
            this.DgvLocalDrivLicApp.Name = "DgvLocalDrivLicApp";
            this.DgvLocalDrivLicApp.ReadOnly = true;
            this.DgvLocalDrivLicApp.RowHeadersWidth = 51;
            this.DgvLocalDrivLicApp.RowTemplate.Height = 24;
            this.DgvLocalDrivLicApp.Size = new System.Drawing.Size(1211, 447);
            this.DgvLocalDrivLicApp.TabIndex = 10;
            this.DgvLocalDrivLicApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalDrivLicApp_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplcationToolStripMenuItem,
            this.sechduleTestToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 196);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplcationToolStripMenuItem
            // 
            this.cancelApplcationToolStripMenuItem.Name = "cancelApplcationToolStripMenuItem";
            this.cancelApplcationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.cancelApplcationToolStripMenuItem.Text = "Cancel Applcation";
            this.cancelApplcationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplcationToolStripMenuItem_Click);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.sToolStripMenuItem1,
            this.sToolStripMenuItem2});
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.sechduleTestToolStripMenuItem.Text = "Sechdule Test";
            this.sechduleTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleTestToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sToolStripMenuItem.Text = "Sechdule Vision Test";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.sToolStripMenuItem1.Text = "Sechdule Written Test";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.sToolStripMenuItem1_Click);
            // 
            // sToolStripMenuItem2
            // 
            this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            this.sToolStripMenuItem2.Size = new System.Drawing.Size(235, 26);
            this.sToolStripMenuItem2.Text = "Sechdule Street Test";
            this.sToolStripMenuItem2.Click += new System.EventHandler(this.sToolStripMenuItem2_Click);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(384, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Local Driving License Application";
            // 
            // PbAdd
            // 
            this.PbAdd.Image = global::DVLD.Properties.Resources.Icons8_Windows_8_Users_Add_User_512;
            this.PbAdd.Location = new System.Drawing.Point(1161, 192);
            this.PbAdd.Name = "PbAdd";
            this.PbAdd.Size = new System.Drawing.Size(64, 39);
            this.PbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAdd.TabIndex = 13;
            this.PbAdd.TabStop = false;
            this.PbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // LocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(1235, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.TbFiltorInput);
            this.Controls.Add(this.CbFiltorBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbAdd);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.BtnCloas);
            this.Controls.Add(this.DgvLocalDrivLicApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalDrivLicApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCountRecord;
        private System.Windows.Forms.TextBox TbFiltorInput;
        private System.Windows.Forms.ComboBox CbFiltorBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbAdd;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Button BtnCloas;
        private System.Windows.Forms.DataGridView DgvLocalDrivLicApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplcationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}