namespace DVLD
{
    partial class CtrlDriverLicenseInfoWithFilter
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
            this.GbFilters = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TbLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.driverLicenseInfo1 = new DVLD.DriverLicenseInfo();
            this.GbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFilters
            // 
            this.GbFilters.Controls.Add(this.BtnSearch);
            this.GbFilters.Controls.Add(this.TbLicenseID);
            this.GbFilters.Controls.Add(this.label1);
            this.GbFilters.Location = new System.Drawing.Point(12, 0);
            this.GbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.GbFilters.Name = "GbFilters";
            this.GbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.GbFilters.Size = new System.Drawing.Size(951, 104);
            this.GbFilters.TabIndex = 18;
            this.GbFilters.TabStop = false;
            this.GbFilters.Text = "Filter";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::DVLD.Properties.Resources.search;
            this.BtnSearch.Location = new System.Drawing.Point(483, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(95, 87);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbLicenseID
            // 
            this.TbLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLicenseID.Location = new System.Drawing.Point(145, 34);
            this.TbLicenseID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TbLicenseID.Name = "TbLicenseID";
            this.TbLicenseID.Size = new System.Drawing.Size(285, 22);
            this.TbLicenseID.TabIndex = 17;
            this.TbLicenseID.TextChanged += new System.EventHandler(this.TbLicenseID_TextChanged);
            this.TbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLicenseID_KeyPress);
            this.TbLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.TbLicenseID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "LicenseID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // driverLicenseInfo1
            // 
            this.driverLicenseInfo1.Location = new System.Drawing.Point(12, 111);
            this.driverLicenseInfo1.Name = "driverLicenseInfo1";
            this.driverLicenseInfo1.Size = new System.Drawing.Size(951, 382);
            this.driverLicenseInfo1.TabIndex = 0;
            // 
            // CtrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbFilters);
            this.Controls.Add(this.driverLicenseInfo1);
            this.Name = "CtrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(980, 499);
            this.Load += new System.EventHandler(this.CtrlDriverLicenseInfoWithFilter_Load);
            this.GbFilters.ResumeLayout(false);
            this.GbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DriverLicenseInfo driverLicenseInfo1;
        private System.Windows.Forms.GroupBox GbFilters;
        private System.Windows.Forms.TextBox TbLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnSearch;
    }
}
