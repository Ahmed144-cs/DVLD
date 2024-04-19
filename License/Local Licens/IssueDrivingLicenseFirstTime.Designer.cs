namespace DVLD
{
    partial class IssueDrivingLicenseFirstTime
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
            this.TbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIssue = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ctrlDrivLicAppInfo1 = new DVLD.ctrlDrivLicAppInfo();
            this.SuspendLayout();
            // 
            // TbNote
            // 
            this.TbNote.Location = new System.Drawing.Point(12, 512);
            this.TbNote.Multiline = true;
            this.TbNote.Name = "TbNote";
            this.TbNote.Size = new System.Drawing.Size(902, 106);
            this.TbNote.TabIndex = 2;
            this.TbNote.TextChanged += new System.EventHandler(this.TbNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note :";
            // 
            // BtnIssue
            // 
            this.BtnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssue.Location = new System.Drawing.Point(828, 624);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Size = new System.Drawing.Size(86, 40);
            this.BtnIssue.TabIndex = 73;
            this.BtnIssue.Text = "Issue";
            this.BtnIssue.UseVisualStyleBackColor = true;
            this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(702, 624);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 40);
            this.BtnClose.TabIndex = 72;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ctrlDrivLicAppInfo1
            // 
            this.ctrlDrivLicAppInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivLicAppInfo1.Name = "ctrlDrivLicAppInfo1";
            this.ctrlDrivLicAppInfo1.Size = new System.Drawing.Size(902, 436);
            this.ctrlDrivLicAppInfo1.TabIndex = 74;
            // 
            // IssueDrivingLicenseFirstTime
            // 
            this.AcceptButton = this.BtnIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(924, 673);
            this.Controls.Add(this.ctrlDrivLicAppInfo1);
            this.Controls.Add(this.BtnIssue);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IssueDrivingLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License First Time";
            this.Load += new System.EventHandler(this.IssueDrivingLicenseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIssue;
        private System.Windows.Forms.Button BtnClose;
        private ctrlDrivLicAppInfo ctrlDrivLicAppInfo1;
    }
}