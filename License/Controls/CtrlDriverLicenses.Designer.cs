namespace DVLD
{
    partial class CtrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GbDriverLicense = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TapLocalLicense = new System.Windows.Forms.TabPage();
            this.LabLocLicRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabInterRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvInternationalLic = new System.Windows.Forms.DataGridView();
            this.cmsInterenationalLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InternationalLicenseHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbDriverLicense.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TapLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalLicenses)).BeginInit();
            this.cmsLocalLicenseHistory.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalLic)).BeginInit();
            this.cmsInterenationalLicenseHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDriverLicense
            // 
            this.GbDriverLicense.Controls.Add(this.tabControl1);
            this.GbDriverLicense.Location = new System.Drawing.Point(3, 3);
            this.GbDriverLicense.Name = "GbDriverLicense";
            this.GbDriverLicense.Size = new System.Drawing.Size(1046, 379);
            this.GbDriverLicense.TabIndex = 0;
            this.GbDriverLicense.TabStop = false;
            this.GbDriverLicense.Text = "Driver License";
            this.GbDriverLicense.Enter += new System.EventHandler(this.GbDriverLicense_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TapLocalLicense);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 339);
            this.tabControl1.TabIndex = 1;
            // 
            // TapLocalLicense
            // 
            this.TapLocalLicense.Controls.Add(this.LabLocLicRecords);
            this.TapLocalLicense.Controls.Add(this.label2);
            this.TapLocalLicense.Controls.Add(this.DgvLocalLicenses);
            this.TapLocalLicense.Location = new System.Drawing.Point(4, 29);
            this.TapLocalLicense.Name = "TapLocalLicense";
            this.TapLocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.TapLocalLicense.Size = new System.Drawing.Size(1026, 306);
            this.TapLocalLicense.TabIndex = 0;
            this.TapLocalLicense.Text = "Local License";
            this.TapLocalLicense.UseVisualStyleBackColor = true;
            // 
            // LabLocLicRecords
            // 
            this.LabLocLicRecords.AutoSize = true;
            this.LabLocLicRecords.Location = new System.Drawing.Point(137, 288);
            this.LabLocLicRecords.Name = "LabLocLicRecords";
            this.LabLocLicRecords.Size = new System.Drawing.Size(27, 20);
            this.LabLocLicRecords.TabIndex = 138;
            this.LabLocLicRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 137;
            this.label2.Text = "# Records:";
            // 
            // DgvLocalLicenses
            // 
            this.DgvLocalLicenses.AllowUserToAddRows = false;
            this.DgvLocalLicenses.AllowUserToDeleteRows = false;
            this.DgvLocalLicenses.AllowUserToOrderColumns = true;
            this.DgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLocalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalLicenses.ContextMenuStrip = this.cmsLocalLicenseHistory;
            this.DgvLocalLicenses.Location = new System.Drawing.Point(6, 6);
            this.DgvLocalLicenses.Name = "DgvLocalLicenses";
            this.DgvLocalLicenses.ReadOnly = true;
            this.DgvLocalLicenses.RowHeadersWidth = 51;
            this.DgvLocalLicenses.RowTemplate.Height = 24;
            this.DgvLocalLicenses.Size = new System.Drawing.Size(1014, 272);
            this.DgvLocalLicenses.TabIndex = 73;
            // 
            // cmsLocalLicenseHistory
            // 
            this.cmsLocalLicenseHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenseHistory.Name = "cmsLocalLicenseHistory";
            this.cmsLocalLicenseHistory.Size = new System.Drawing.Size(197, 28);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabInterRecords);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.DgvInternationalLic);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1026, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabInterRecords
            // 
            this.LabInterRecords.AutoSize = true;
            this.LabInterRecords.Location = new System.Drawing.Point(123, 283);
            this.LabInterRecords.Name = "LabInterRecords";
            this.LabInterRecords.Size = new System.Drawing.Size(27, 20);
            this.LabInterRecords.TabIndex = 140;
            this.LabInterRecords.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "# Records:";
            // 
            // DgvInternationalLic
            // 
            this.DgvInternationalLic.AllowUserToAddRows = false;
            this.DgvInternationalLic.AllowUserToDeleteRows = false;
            this.DgvInternationalLic.AllowUserToOrderColumns = true;
            this.DgvInternationalLic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInternationalLic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvInternationalLic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInternationalLic.ContextMenuStrip = this.cmsInterenationalLicenseHistory;
            this.DgvInternationalLic.Location = new System.Drawing.Point(6, 6);
            this.DgvInternationalLic.Name = "DgvInternationalLic";
            this.DgvInternationalLic.ReadOnly = true;
            this.DgvInternationalLic.RowHeadersWidth = 51;
            this.DgvInternationalLic.RowTemplate.Height = 24;
            this.DgvInternationalLic.Size = new System.Drawing.Size(1014, 272);
            this.DgvInternationalLic.TabIndex = 78;
            // 
            // cmsInterenationalLicenseHistory
            // 
            this.cmsInterenationalLicenseHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInterenationalLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InternationalLicenseHistorytoolStripMenuItem});
            this.cmsInterenationalLicenseHistory.Name = "cmsLocalLicenseHistory";
            this.cmsInterenationalLicenseHistory.Size = new System.Drawing.Size(211, 56);
            // 
            // InternationalLicenseHistorytoolStripMenuItem
            // 
            this.InternationalLicenseHistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InternationalLicenseHistorytoolStripMenuItem.Name = "InternationalLicenseHistorytoolStripMenuItem";
            this.InternationalLicenseHistorytoolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.InternationalLicenseHistorytoolStripMenuItem.Text = "Show License Info";
            this.InternationalLicenseHistorytoolStripMenuItem.Click += new System.EventHandler(this.InternationalLicenseHistorytoolStripMenuItem_Click);
            // 
            // CtrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbDriverLicense);
            this.Name = "CtrlDriverLicenses";
            this.Size = new System.Drawing.Size(1050, 376);
            this.GbDriverLicense.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TapLocalLicense.ResumeLayout(false);
            this.TapLocalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalLicenses)).EndInit();
            this.cmsLocalLicenseHistory.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalLic)).EndInit();
            this.cmsInterenationalLicenseHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDriverLicense;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TapLocalLicense;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvLocalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvInternationalLic;
        private System.Windows.Forms.ContextMenuStrip cmsInterenationalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseHistorytoolStripMenuItem;
        private System.Windows.Forms.Label LabLocLicRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabInterRecords;
        private System.Windows.Forms.Label label3;
    }
}
