namespace DVLD
{
    partial class FrnTakeTest
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
            this.TbResultNoat = new System.Windows.Forms.TextBox();
            this.RbPass = new System.Windows.Forms.RadioButton();
            this.RbFail = new System.Windows.Forms.RadioButton();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ctrlSecheduledTestResult1 = new DVLD.ctrlSecheduledTestResult();
            this.SuspendLayout();
            // 
            // TbResultNoat
            // 
            this.TbResultNoat.Location = new System.Drawing.Point(12, 449);
            this.TbResultNoat.Multiline = true;
            this.TbResultNoat.Name = "TbResultNoat";
            this.TbResultNoat.Size = new System.Drawing.Size(414, 120);
            this.TbResultNoat.TabIndex = 31;
            this.TbResultNoat.TextChanged += new System.EventHandler(this.TbResultNoat_TextChanged);
            // 
            // RbPass
            // 
            this.RbPass.AutoSize = true;
            this.RbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPass.Location = new System.Drawing.Point(12, 590);
            this.RbPass.Name = "RbPass";
            this.RbPass.Size = new System.Drawing.Size(71, 26);
            this.RbPass.TabIndex = 32;
            this.RbPass.TabStop = true;
            this.RbPass.Text = "Pass";
            this.RbPass.UseVisualStyleBackColor = true;
            this.RbPass.CheckedChanged += new System.EventHandler(this.RbPass_CheckedChanged);
            // 
            // RbFail
            // 
            this.RbFail.AutoSize = true;
            this.RbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFail.ForeColor = System.Drawing.Color.Black;
            this.RbFail.Location = new System.Drawing.Point(118, 590);
            this.RbFail.Name = "RbFail";
            this.RbFail.Size = new System.Drawing.Size(60, 26);
            this.RbFail.TabIndex = 33;
            this.RbFail.TabStop = true;
            this.RbFail.Text = "Fail";
            this.RbFail.UseVisualStyleBackColor = true;
            this.RbFail.CheckedChanged += new System.EventHandler(this.RbFail_CheckedChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(233, 579);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(89, 45);
            this.BtnClose.TabIndex = 34;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(337, 579);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(89, 45);
            this.BtnSave.TabIndex = 35;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ctrlSecheduledTestResult1
            // 
            this.ctrlSecheduledTestResult1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSecheduledTestResult1.Name = "ctrlSecheduledTestResult1";
            this.ctrlSecheduledTestResult1.Size = new System.Drawing.Size(414, 420);
            this.ctrlSecheduledTestResult1.TabIndex = 36;
            this.ctrlSecheduledTestResult1.TestTypeID = DVLD_LogicAccess.ManageTestTypeLogic.enTestType.VisionTest;
            // 
            // FrnTakeTest
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(440, 636);
            this.Controls.Add(this.ctrlSecheduledTestResult1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.RbFail);
            this.Controls.Add(this.RbPass);
            this.Controls.Add(this.TbResultNoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrnTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.FrnTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbResultNoat;
        private System.Windows.Forms.RadioButton RbPass;
        private System.Windows.Forms.RadioButton RbFail;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private ctrlSecheduledTestResult ctrlSecheduledTestResult1;
    }
}