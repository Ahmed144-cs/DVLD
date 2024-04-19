namespace DVLD
{
    partial class InternationalDrivLicenseApp
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
            this.DgvIntDrivLicApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PbAdd = new System.Windows.Forms.PictureBox();
            this.CbIsReleased = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntDrivLicApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(144, 665);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 25;
            this.labelCountRecord.Text = "???";
            this.labelCountRecord.Click += new System.EventHandler(this.labelCountRecord_Click);
            // 
            // TbFiltorInput
            // 
            this.TbFiltorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFiltorInput.Location = new System.Drawing.Point(299, 170);
            this.TbFiltorInput.Name = "TbFiltorInput";
            this.TbFiltorInput.Size = new System.Drawing.Size(196, 30);
            this.TbFiltorInput.TabIndex = 24;
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
            "International License ID",
            "Driver ID",
            "Application ID",
            "Local License ID",
            "Is Active"});
            this.CbFiltorBy.Location = new System.Drawing.Point(137, 170);
            this.CbFiltorBy.Name = "CbFiltorBy";
            this.CbFiltorBy.Size = new System.Drawing.Size(156, 33);
            this.CbFiltorBy.TabIndex = 23;
            this.CbFiltorBy.SelectedIndexChanged += new System.EventHandler(this.CbFiltorBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filtor by : ";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(14, 665);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 21;
            this.labelRecords.Text = "Recordes:";
            // 
            // BtnCloas
            // 
            this.BtnCloas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.ForeColor = System.Drawing.Color.Black;
            this.BtnCloas.Location = new System.Drawing.Point(953, 658);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 47);
            this.BtnCloas.TabIndex = 20;
            this.BtnCloas.Text = "Close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            this.BtnCloas.Click += new System.EventHandler(this.BtnCloas_Click);
            // 
            // DgvIntDrivLicApp
            // 
            this.DgvIntDrivLicApp.AllowUserToAddRows = false;
            this.DgvIntDrivLicApp.AllowUserToDeleteRows = false;
            this.DgvIntDrivLicApp.AllowUserToOrderColumns = true;
            this.DgvIntDrivLicApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIntDrivLicApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvIntDrivLicApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIntDrivLicApp.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvIntDrivLicApp.Location = new System.Drawing.Point(19, 219);
            this.DgvIntDrivLicApp.Name = "DgvIntDrivLicApp";
            this.DgvIntDrivLicApp.ReadOnly = true;
            this.DgvIntDrivLicApp.RowHeadersWidth = 51;
            this.DgvIntDrivLicApp.RowTemplate.Height = 24;
            this.DgvIntDrivLicApp.Size = new System.Drawing.Size(1089, 421);
            this.DgvIntDrivLicApp.TabIndex = 19;
            this.DgvIntDrivLicApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIntDrivLicApp_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.showPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonToolStripMenuItem.Text = "Show Person";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "International Driving License Application";
            // 
            // PbAdd
            // 
            this.PbAdd.Image = global::DVLD.Properties.Resources.Icons8_Windows_8_Users_Add_User_512;
            this.PbAdd.Location = new System.Drawing.Point(1044, 170);
            this.PbAdd.Name = "PbAdd";
            this.PbAdd.Size = new System.Drawing.Size(64, 39);
            this.PbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAdd.TabIndex = 27;
            this.PbAdd.TabStop = false;
            this.PbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // CbIsReleased
            // 
            this.CbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsReleased.FormattingEnabled = true;
            this.CbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.CbIsReleased.Location = new System.Drawing.Point(299, 170);
            this.CbIsReleased.Name = "CbIsReleased";
            this.CbIsReleased.Size = new System.Drawing.Size(121, 30);
            this.CbIsReleased.TabIndex = 164;
            this.CbIsReleased.Visible = false;
            this.CbIsReleased.SelectedIndexChanged += new System.EventHandler(this.CbIsReleased_SelectedIndexChanged);
            // 
            // InternationalDrivLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(1124, 712);
            this.Controls.Add(this.CbIsReleased);
            this.Controls.Add(this.PbAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.TbFiltorInput);
            this.Controls.Add(this.CbFiltorBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.BtnCloas);
            this.Controls.Add(this.DgvIntDrivLicApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InternationalDrivLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Driv License App";
            this.Load += new System.EventHandler(this.InternationalDrivLicenseApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIntDrivLicApp)).EndInit();
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
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Button BtnCloas;
        private System.Windows.Forms.DataGridView DgvIntDrivLicApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ComboBox CbIsReleased;
    }
}