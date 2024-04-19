namespace DVLD
{
    partial class LocalDrivingLicenseApplicationInfo
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
            this.BtnCloas = new System.Windows.Forms.Button();
            this.ctrlDrivLicAppInfo1 = new DVLD.ctrlDrivLicAppInfo();
            this.SuspendLayout();
            // 
            // BtnCloas
            // 
            this.BtnCloas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.Location = new System.Drawing.Point(745, 455);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 47);
            this.BtnCloas.TabIndex = 12;
            this.BtnCloas.Text = "Close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            this.BtnCloas.Click += new System.EventHandler(this.BtnCloas_Click);
            // 
            // ctrlDrivLicAppInfo1
            // 
            this.ctrlDrivLicAppInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivLicAppInfo1.Name = "ctrlDrivLicAppInfo1";
            this.ctrlDrivLicAppInfo1.Size = new System.Drawing.Size(887, 436);
            this.ctrlDrivLicAppInfo1.TabIndex = 13;
            // 
            // LocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(915, 508);
            this.Controls.Add(this.ctrlDrivLicAppInfo1);
            this.Controls.Add(this.BtnCloas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCloas;
        private ctrlDrivLicAppInfo ctrlDrivLicAppInfo1;
    }
}