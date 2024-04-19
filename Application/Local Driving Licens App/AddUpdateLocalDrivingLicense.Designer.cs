namespace DVLD
{
    partial class AddUpdateLocalDrivingLicense
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterPerson1 = new DVLD.FilterPerson();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tabAppInfo = new System.Windows.Forms.TabPage();
            this.CbLicenseClass = new System.Windows.Forms.ComboBox();
            this.LabCreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lab = new System.Windows.Forms.Label();
            this.LabAppFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabAppData = new System.Windows.Forms.Label();
            this.LabDrvLicAppID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LabFormText = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabAppInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterPerson1);
            this.tabPage1.Controls.Add(this.BtnNext);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // filterPerson1
            // 
            this.filterPerson1.FilterEnabled = true;
            this.filterPerson1.Location = new System.Drawing.Point(18, 16);
            this.filterPerson1.Name = "filterPerson1";
            this.filterPerson1.ShowAddPerson = true;
            this.filterPerson1.Size = new System.Drawing.Size(726, 325);
            this.filterPerson1.TabIndex = 3;
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(655, 353);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(89, 45);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tabAppInfo
            // 
            this.tabAppInfo.Controls.Add(this.CbLicenseClass);
            this.tabAppInfo.Controls.Add(this.LabCreatedBy);
            this.tabAppInfo.Controls.Add(this.label9);
            this.tabAppInfo.Controls.Add(this.Lab);
            this.tabAppInfo.Controls.Add(this.LabAppFees);
            this.tabAppInfo.Controls.Add(this.label6);
            this.tabAppInfo.Controls.Add(this.label5);
            this.tabAppInfo.Controls.Add(this.LabAppData);
            this.tabAppInfo.Controls.Add(this.LabDrvLicAppID);
            this.tabAppInfo.Controls.Add(this.label2);
            this.tabAppInfo.Location = new System.Drawing.Point(4, 34);
            this.tabAppInfo.Name = "tabAppInfo";
            this.tabAppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppInfo.Size = new System.Drawing.Size(774, 418);
            this.tabAppInfo.TabIndex = 1;
            this.tabAppInfo.Text = "Application Info";
            this.tabAppInfo.UseVisualStyleBackColor = true;
            this.tabAppInfo.Click += new System.EventHandler(this.tabAppInfo_Click);
            // 
            // CbLicenseClass
            // 
            this.CbLicenseClass.FormattingEnabled = true;
            this.CbLicenseClass.Location = new System.Drawing.Point(210, 171);
            this.CbLicenseClass.Name = "CbLicenseClass";
            this.CbLicenseClass.Size = new System.Drawing.Size(348, 33);
            this.CbLicenseClass.TabIndex = 10;
            this.CbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.CbLicenseClass_SelectedIndexChanged);
            // 
            // LabCreatedBy
            // 
            this.LabCreatedBy.AutoSize = true;
            this.LabCreatedBy.Location = new System.Drawing.Point(205, 306);
            this.LabCreatedBy.Name = "LabCreatedBy";
            this.LabCreatedBy.Size = new System.Drawing.Size(59, 25);
            this.LabCreatedBy.TabIndex = 8;
            this.LabCreatedBy.Text = "{???}";
            this.LabCreatedBy.Click += new System.EventHandler(this.LabCreatedBy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Created By :";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(31, 240);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(157, 25);
            this.Lab.TabIndex = 6;
            this.Lab.Text = "Appliction Fees :";
            // 
            // LabAppFees
            // 
            this.LabAppFees.AutoSize = true;
            this.LabAppFees.Location = new System.Drawing.Point(205, 240);
            this.LabAppFees.Name = "LabAppFees";
            this.LabAppFees.Size = new System.Drawing.Size(34, 25);
            this.LabAppFees.TabIndex = 5;
            this.LabAppFees.Text = "15";
            this.LabAppFees.Click += new System.EventHandler(this.LabAppFees_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Appliction Data :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "License Class :";
            // 
            // LabAppData
            // 
            this.LabAppData.AutoSize = true;
            this.LabAppData.Location = new System.Drawing.Point(205, 108);
            this.LabAppData.Name = "LabAppData";
            this.LabAppData.Size = new System.Drawing.Size(59, 25);
            this.LabAppData.TabIndex = 2;
            this.LabAppData.Text = "{???}";
            this.LabAppData.Click += new System.EventHandler(this.LabAppData_Click);
            // 
            // LabDrvLicAppID
            // 
            this.LabDrvLicAppID.AutoSize = true;
            this.LabDrvLicAppID.Location = new System.Drawing.Point(205, 42);
            this.LabDrvLicAppID.Name = "LabDrvLicAppID";
            this.LabDrvLicAppID.Size = new System.Drawing.Size(59, 25);
            this.LabDrvLicAppID.TabIndex = 1;
            this.LabDrvLicAppID.Text = "{???}";
            this.LabDrvLicAppID.Click += new System.EventHandler(this.LabDrvLicAppID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.App.ID :";
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(702, 572);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(99, 51);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(559, 572);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(99, 51);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LabFormText
            // 
            this.LabFormText.AutoSize = true;
            this.LabFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFormText.ForeColor = System.Drawing.Color.Red;
            this.LabFormText.Location = new System.Drawing.Point(192, 26);
            this.LabFormText.Name = "LabFormText";
            this.LabFormText.Size = new System.Drawing.Size(452, 32);
            this.LabFormText.TabIndex = 7;
            this.LabFormText.Text = "New Driving License Application";
            // 
            // AddUpdateLocalDrivingLicense
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(825, 629);
            this.Controls.Add(this.LabFormText);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUpdateLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabAppInfo.ResumeLayout(false);
            this.tabAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabAppInfo;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CbLicenseClass;
        private System.Windows.Forms.Label LabCreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lab;
        private System.Windows.Forms.Label LabAppFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabAppData;
        private System.Windows.Forms.Label LabDrvLicAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FilterPerson filterPerson1;
        private System.Windows.Forms.Label LabFormText;
    }
}