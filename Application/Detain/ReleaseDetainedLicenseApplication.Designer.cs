namespace DVLD
{
    partial class ReleaseDetainedLicenseApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpDetain = new System.Windows.Forms.GroupBox();
            this.LabApplicationID = new System.Windows.Forms.Label();
            this.LabTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabApplicationFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabFineFees = new System.Windows.Forms.Label();
            this.LabLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabCreatedByUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabDetainDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LlShowLicHistory = new System.Windows.Forms.LinkLabel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRelease = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.CtrlDriverLicenseInfoWithFilter();
            this.gpDetain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(72, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(870, 39);
            this.lblTitle.TabIndex = 187;
            this.lblTitle.Text = "Release Detained License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpDetain
            // 
            this.gpDetain.Controls.Add(this.LabApplicationID);
            this.gpDetain.Controls.Add(this.LabTotalFees);
            this.gpDetain.Controls.Add(this.label8);
            this.gpDetain.Controls.Add(this.label7);
            this.gpDetain.Controls.Add(this.LabApplicationFees);
            this.gpDetain.Controls.Add(this.label6);
            this.gpDetain.Controls.Add(this.LabFineFees);
            this.gpDetain.Controls.Add(this.LabLicenseID);
            this.gpDetain.Controls.Add(this.label10);
            this.gpDetain.Controls.Add(this.label1);
            this.gpDetain.Controls.Add(this.LabCreatedByUser);
            this.gpDetain.Controls.Add(this.label2);
            this.gpDetain.Controls.Add(this.LabDetainDate);
            this.gpDetain.Controls.Add(this.label5);
            this.gpDetain.Controls.Add(this.LabDetainID);
            this.gpDetain.Controls.Add(this.label4);
            this.gpDetain.Location = new System.Drawing.Point(12, 578);
            this.gpDetain.Name = "gpDetain";
            this.gpDetain.Size = new System.Drawing.Size(980, 135);
            this.gpDetain.TabIndex = 189;
            this.gpDetain.TabStop = false;
            this.gpDetain.Text = "Detain Info";
            // 
            // LabApplicationID
            // 
            this.LabApplicationID.AutoSize = true;
            this.LabApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabApplicationID.Location = new System.Drawing.Point(571, 56);
            this.LabApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabApplicationID.Name = "LabApplicationID";
            this.LabApplicationID.Size = new System.Drawing.Size(74, 25);
            this.LabApplicationID.TabIndex = 202;
            this.LabApplicationID.Text = "[????]";
            // 
            // LabTotalFees
            // 
            this.LabTotalFees.AutoSize = true;
            this.LabTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalFees.Location = new System.Drawing.Point(867, 66);
            this.LabTotalFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTotalFees.Name = "LabTotalFees";
            this.LabTotalFees.Size = new System.Drawing.Size(74, 25);
            this.LabTotalFees.TabIndex = 202;
            this.LabTotalFees.Text = "[$$$$]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 200;
            this.label8.Text = "Application ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 200;
            this.label7.Text = "Total Fees:";
            // 
            // LabApplicationFees
            // 
            this.LabApplicationFees.AutoSize = true;
            this.LabApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabApplicationFees.Location = new System.Drawing.Point(204, 94);
            this.LabApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabApplicationFees.Name = "LabApplicationFees";
            this.LabApplicationFees.Size = new System.Drawing.Size(74, 25);
            this.LabApplicationFees.TabIndex = 199;
            this.LabApplicationFees.Text = "[$$$$]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 197;
            this.label6.Text = "Application Fees:";
            // 
            // LabFineFees
            // 
            this.LabFineFees.AutoSize = true;
            this.LabFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFineFees.Location = new System.Drawing.Point(867, 24);
            this.LabFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabFineFees.Name = "LabFineFees";
            this.LabFineFees.Size = new System.Drawing.Size(74, 25);
            this.LabFineFees.TabIndex = 196;
            this.LabFineFees.Text = "[$$$$]";
            // 
            // LabLicenseID
            // 
            this.LabLicenseID.AutoSize = true;
            this.LabLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLicenseID.Location = new System.Drawing.Point(571, 24);
            this.LabLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabLicenseID.Name = "LabLicenseID";
            this.LabLicenseID.Size = new System.Drawing.Size(62, 25);
            this.LabLicenseID.TabIndex = 191;
            this.LabLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 190;
            this.label10.Text = "License ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 181;
            this.label1.Text = "Created By:";
            // 
            // LabCreatedByUser
            // 
            this.LabCreatedByUser.AutoSize = true;
            this.LabCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCreatedByUser.Location = new System.Drawing.Point(571, 94);
            this.LabCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabCreatedByUser.Name = "LabCreatedByUser";
            this.LabCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.LabCreatedByUser.TabIndex = 180;
            this.LabCreatedByUser.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 177;
            this.label2.Text = "Fine Fees:";
            // 
            // LabDetainDate
            // 
            this.LabDetainDate.AutoSize = true;
            this.LabDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDetainDate.Location = new System.Drawing.Point(204, 56);
            this.LabDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabDetainDate.Name = "LabDetainDate";
            this.LabDetainDate.Size = new System.Drawing.Size(136, 25);
            this.LabDetainDate.TabIndex = 176;
            this.LabDetainDate.Text = "[??/??/????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 174;
            this.label5.Text = "Detain Date:";
            // 
            // LabDetainID
            // 
            this.LabDetainID.AutoSize = true;
            this.LabDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDetainID.Location = new System.Drawing.Point(204, 24);
            this.LabDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabDetainID.Name = "LabDetainID";
            this.LabDetainID.Size = new System.Drawing.Size(62, 25);
            this.LabDetainID.TabIndex = 173;
            this.LabDetainID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 172;
            this.label4.Text = "Detain ID:";
            // 
            // LlShowLicHistory
            // 
            this.LlShowLicHistory.AutoSize = true;
            this.LlShowLicHistory.Enabled = false;
            this.LlShowLicHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlShowLicHistory.Location = new System.Drawing.Point(7, 728);
            this.LlShowLicHistory.Name = "LlShowLicHistory";
            this.LlShowLicHistory.Size = new System.Drawing.Size(200, 25);
            this.LlShowLicHistory.TabIndex = 194;
            this.LlShowLicHistory.TabStop = true;
            this.LlShowLicHistory.Text = "Show License History";
            this.LlShowLicHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlShowLicHistory_LinkClicked);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(696, 719);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 44);
            this.BtnClose.TabIndex = 193;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRelease
            // 
            this.BtnRelease.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRelease.Enabled = false;
            this.BtnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelease.Location = new System.Drawing.Point(884, 719);
            this.BtnRelease.Name = "BtnRelease";
            this.BtnRelease.Size = new System.Drawing.Size(108, 44);
            this.BtnRelease.TabIndex = 195;
            this.BtnRelease.Text = "Release";
            this.BtnRelease.UseVisualStyleBackColor = true;
            this.BtnRelease.Click += new System.EventHandler(this.BtnRelease_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 73);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(980, 499);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 196;
            // 
            // ReleaseDetainedLicenseApplication
            // 
            this.AcceptButton = this.BtnRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1011, 766);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.BtnRelease);
            this.Controls.Add(this.LlShowLicHistory);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.gpDetain);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReleaseDetainedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReleaseDetainedLicenseApplication";
            this.Activated += new System.EventHandler(this.ReleaseDetainedLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.ReleaseDetainedLicenseApplication_Load);
            this.gpDetain.ResumeLayout(false);
            this.gpDetain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpDetain;
        private System.Windows.Forms.Label LabApplicationID;
        private System.Windows.Forms.Label LabTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabApplicationFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabFineFees;
        private System.Windows.Forms.Label LabLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabCreatedByUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabDetainDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LlShowLicHistory;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnRelease;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CtrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}