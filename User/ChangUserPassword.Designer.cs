namespace DVLD
{
    partial class ChangUserPassword
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
            this.TbConfrmPass = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfrmPassword = new System.Windows.Forms.Label();
            this.TbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.userCardControl1 = new DVLD.UserCardControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbConfrmPass
            // 
            this.TbConfrmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbConfrmPass.Location = new System.Drawing.Point(199, 489);
            this.TbConfrmPass.Name = "TbConfrmPass";
            this.TbConfrmPass.Size = new System.Drawing.Size(212, 30);
            this.TbConfrmPass.TabIndex = 21;
            this.TbConfrmPass.TextChanged += new System.EventHandler(this.TbConfrmPass_TextChanged);
            this.TbConfrmPass.Validating += new System.ComponentModel.CancelEventHandler(this.TbConfrmPass_Validating);
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(199, 425);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(212, 30);
            this.TbPassword.TabIndex = 23;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            this.TbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TbPassword_Validating);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(15, 425);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 25);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password :";
            // 
            // labelConfrmPassword
            // 
            this.labelConfrmPassword.AutoSize = true;
            this.labelConfrmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfrmPassword.Location = new System.Drawing.Point(15, 489);
            this.labelConfrmPassword.Name = "labelConfrmPassword";
            this.labelConfrmPassword.Size = new System.Drawing.Size(178, 25);
            this.labelConfrmPassword.TabIndex = 18;
            this.labelConfrmPassword.Text = "Confrm Password :";
            // 
            // TbCurrentPassword
            // 
            this.TbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCurrentPassword.Location = new System.Drawing.Point(199, 361);
            this.TbCurrentPassword.Name = "TbCurrentPassword";
            this.TbCurrentPassword.Size = new System.Drawing.Size(212, 30);
            this.TbCurrentPassword.TabIndex = 20;
            this.TbCurrentPassword.TextChanged += new System.EventHandler(this.TbCurrentPassword_TextChanged);
            this.TbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TbCurrentPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current Password :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 50;
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(593, 578);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(128, 50);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(425, 578);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(128, 50);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // userCardControl1
            // 
            this.userCardControl1.Location = new System.Drawing.Point(12, 12);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(694, 333);
            this.userCardControl1.TabIndex = 26;
            // 
            // ChangUserPassword
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(737, 643);
            this.Controls.Add(this.userCardControl1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbCurrentPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbConfrmPass);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelConfrmPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chang User Password";
            this.Load += new System.EventHandler(this.ChangUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbConfrmPass;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfrmPassword;
        private System.Windows.Forms.TextBox TbCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private UserCardControl userCardControl1;
    }
}