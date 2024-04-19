namespace DVLD
{
    partial class ManageDetainLicApp
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
            this.DgvDetainLicApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PbReleaseLic = new System.Windows.Forms.PictureBox();
            this.PbDetainLic = new System.Windows.Forms.PictureBox();
            this.CbIsReleased = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetainLicApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbReleaseLic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDetainLic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(143, 670);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 33;
            this.labelCountRecord.Text = "???";
            // 
            // TbFiltorInput
            // 
            this.TbFiltorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFiltorInput.Location = new System.Drawing.Point(298, 175);
            this.TbFiltorInput.Name = "TbFiltorInput";
            this.TbFiltorInput.Size = new System.Drawing.Size(196, 30);
            this.TbFiltorInput.TabIndex = 32;
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
            "Detain ID",
            "Release Application ID",
            "National No.",
            "Full Name",
            "Is Released"});
            this.CbFiltorBy.Location = new System.Drawing.Point(136, 175);
            this.CbFiltorBy.Name = "CbFiltorBy";
            this.CbFiltorBy.Size = new System.Drawing.Size(156, 33);
            this.CbFiltorBy.TabIndex = 31;
            this.CbFiltorBy.SelectedIndexChanged += new System.EventHandler(this.CbFiltorBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filtor by : ";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(13, 670);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 29;
            this.labelRecords.Text = "Recordes:";
            // 
            // BtnCloas
            // 
            this.BtnCloas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.ForeColor = System.Drawing.Color.Black;
            this.BtnCloas.Location = new System.Drawing.Point(952, 663);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 51);
            this.BtnCloas.TabIndex = 28;
            this.BtnCloas.Text = "Close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            this.BtnCloas.Click += new System.EventHandler(this.BtnCloas_Click);
            // 
            // DgvDetainLicApp
            // 
            this.DgvDetainLicApp.AllowUserToAddRows = false;
            this.DgvDetainLicApp.AllowUserToDeleteRows = false;
            this.DgvDetainLicApp.AllowUserToOrderColumns = true;
            this.DgvDetainLicApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetainLicApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDetainLicApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetainLicApp.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvDetainLicApp.Location = new System.Drawing.Point(18, 224);
            this.DgvDetainLicApp.Name = "DgvDetainLicApp";
            this.DgvDetainLicApp.ReadOnly = true;
            this.DgvDetainLicApp.RowHeadersWidth = 51;
            this.DgvDetainLicApp.RowTemplate.Height = 24;
            this.DgvDetainLicApp.Size = new System.Drawing.Size(1089, 421);
            this.DgvDetainLicApp.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonHistoryToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonHistoryToolStripMenuItem
            // 
            this.showPersonHistoryToolStripMenuItem.Name = "showPersonHistoryToolStripMenuItem";
            this.showPersonHistoryToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.showPersonHistoryToolStripMenuItem.Text = "Show Person History";
            this.showPersonHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonHistoryToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(313, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Detain License Application";
            // 
            // PbReleaseLic
            // 
            this.PbReleaseLic.Image = global::DVLD.Properties.Resources.Designcontest_Outline_Hand_256;
            this.PbReleaseLic.Location = new System.Drawing.Point(941, 167);
            this.PbReleaseLic.Name = "PbReleaseLic";
            this.PbReleaseLic.Size = new System.Drawing.Size(64, 51);
            this.PbReleaseLic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbReleaseLic.TabIndex = 37;
            this.PbReleaseLic.TabStop = false;
            this.PbReleaseLic.Click += new System.EventHandler(this.PbReleaseLic_Click);
            // 
            // PbDetainLic
            // 
            this.PbDetainLic.Image = global::DVLD.Properties.Resources.Steve_Zondicons_Hand_Stop_512;
            this.PbDetainLic.Location = new System.Drawing.Point(1043, 167);
            this.PbDetainLic.Name = "PbDetainLic";
            this.PbDetainLic.Size = new System.Drawing.Size(64, 51);
            this.PbDetainLic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbDetainLic.TabIndex = 36;
            this.PbDetainLic.TabStop = false;
            this.PbDetainLic.Click += new System.EventHandler(this.PbDetainLic_Click);
            // 
            // CbIsReleased
            // 
            this.CbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsReleased.FormattingEnabled = true;
            this.CbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.CbIsReleased.Location = new System.Drawing.Point(298, 176);
            this.CbIsReleased.Name = "CbIsReleased";
            this.CbIsReleased.Size = new System.Drawing.Size(121, 28);
            this.CbIsReleased.TabIndex = 160;
            this.CbIsReleased.Visible = false;
            this.CbIsReleased.SelectedIndexChanged += new System.EventHandler(this.CbIsReleased_SelectedIndexChanged);
            // 
            // ManageDetainLicApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(1121, 720);
            this.Controls.Add(this.CbIsReleased);
            this.Controls.Add(this.PbReleaseLic);
            this.Controls.Add(this.PbDetainLic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.TbFiltorInput);
            this.Controls.Add(this.CbFiltorBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.BtnCloas);
            this.Controls.Add(this.DgvDetainLicApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDetainLicApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detain Lic App";
            this.Load += new System.EventHandler(this.ManageDetainLicApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetainLicApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbReleaseLic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDetainLic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountRecord;
        private System.Windows.Forms.TextBox TbFiltorInput;
        private System.Windows.Forms.ComboBox CbFiltorBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Button BtnCloas;
        private System.Windows.Forms.DataGridView DgvDetainLicApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.PictureBox PbDetainLic;
        private System.Windows.Forms.PictureBox PbReleaseLic;
        private System.Windows.Forms.ComboBox CbIsReleased;
    }
}