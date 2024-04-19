namespace DVLD
{
    partial class ManageDrivers
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvDriversTest = new System.Windows.Forms.DataGridView();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCountRecord = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbFiltorInput = new System.Windows.Forms.TextBox();
            this.CbFiltorBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDriversTest)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 78;
            this.label1.Text = "Manage Drivers";
            // 
            // DgvDriversTest
            // 
            this.DgvDriversTest.AllowUserToAddRows = false;
            this.DgvDriversTest.AllowUserToDeleteRows = false;
            this.DgvDriversTest.AllowUserToOrderColumns = true;
            this.DgvDriversTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDriversTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDriversTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDriversTest.ContextMenuStrip = this.cmsDrivers;
            this.DgvDriversTest.Location = new System.Drawing.Point(12, 219);
            this.DgvDriversTest.Name = "DgvDriversTest";
            this.DgvDriversTest.ReadOnly = true;
            this.DgvDriversTest.RowHeadersWidth = 51;
            this.DgvDriversTest.RowTemplate.Height = 24;
            this.DgvDriversTest.Size = new System.Drawing.Size(851, 320);
            this.DgvDriversTest.TabIndex = 79;
            this.DgvDriversTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDriversTest_CellContentClick);
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsDrivers.Name = "contextMenuStrip1";
            this.cmsDrivers.Size = new System.Drawing.Size(265, 58);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(137, 553);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 82;
            this.labelCountRecord.Text = "???";
            this.labelCountRecord.Click += new System.EventHandler(this.labelCountRecord_Click);
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(7, 550);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 81;
            this.labelRecords.Text = "Recordes:";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(762, 545);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 40);
            this.BtnClose.TabIndex = 80;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TbFiltorInput
            // 
            this.TbFiltorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFiltorInput.Location = new System.Drawing.Point(292, 176);
            this.TbFiltorInput.Name = "TbFiltorInput";
            this.TbFiltorInput.Size = new System.Drawing.Size(196, 30);
            this.TbFiltorInput.TabIndex = 85;
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
            "Drivers ID",
            "Person ID",
            "National No",
            "Name"});
            this.CbFiltorBy.Location = new System.Drawing.Point(130, 176);
            this.CbFiltorBy.Name = "CbFiltorBy";
            this.CbFiltorBy.Size = new System.Drawing.Size(156, 33);
            this.CbFiltorBy.TabIndex = 84;
            this.CbFiltorBy.SelectedIndexChanged += new System.EventHandler(this.CbFiltorBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = "Filter by : ";
            // 
            // ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(875, 593);
            this.Controls.Add(this.TbFiltorInput);
            this.Controls.Add(this.CbFiltorBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvDriversTest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDriversTest)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDriversTest;
        private System.Windows.Forms.Label labelCountRecord;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TbFiltorInput;
        private System.Windows.Forms.ComboBox CbFiltorBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}