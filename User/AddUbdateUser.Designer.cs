namespace DVLD
{
    partial class AddUbdateUser
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
            this.TabEnterPerson = new System.Windows.Forms.TabPage();
            this.filterPerson1 = new DVLD.FilterPerson();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TabEnterUser = new System.Windows.Forms.TabPage();
            this.TbConfrmPass = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.CbIsActive = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfrmPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabEnterPerson.SuspendLayout();
            this.TabEnterUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabEnterPerson);
            this.tabControl1.Controls.Add(this.TabEnterUser);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // TabEnterPerson
            // 
            this.TabEnterPerson.Controls.Add(this.filterPerson1);
            this.TabEnterPerson.Controls.Add(this.BtnNext);
            this.TabEnterPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabEnterPerson.Location = new System.Drawing.Point(4, 34);
            this.TabEnterPerson.Name = "TabEnterPerson";
            this.TabEnterPerson.Padding = new System.Windows.Forms.Padding(3);
            this.TabEnterPerson.Size = new System.Drawing.Size(744, 410);
            this.TabEnterPerson.TabIndex = 0;
            this.TabEnterPerson.Text = "Personal Info";
            this.TabEnterPerson.UseVisualStyleBackColor = true;
            this.TabEnterPerson.Click += new System.EventHandler(this.tabPageUser_Click);
            // 
            // filterPerson1
            // 
            this.filterPerson1.FilterEnabled = true;
            this.filterPerson1.Location = new System.Drawing.Point(6, 6);
            this.filterPerson1.Name = "filterPerson1";
            this.filterPerson1.ShowAddPerson = true;
            this.filterPerson1.Size = new System.Drawing.Size(726, 325);
            this.filterPerson1.TabIndex = 2;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(610, 346);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(122, 47);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TabEnterUser
            // 
            this.TabEnterUser.Controls.Add(this.TbConfrmPass);
            this.TabEnterUser.Controls.Add(this.TbPassword);
            this.TabEnterUser.Controls.Add(this.TbUserName);
            this.TabEnterUser.Controls.Add(this.labelUserID);
            this.TabEnterUser.Controls.Add(this.CbIsActive);
            this.TabEnterUser.Controls.Add(this.labelPassword);
            this.TabEnterUser.Controls.Add(this.labelConfrmPassword);
            this.TabEnterUser.Controls.Add(this.labelUserName);
            this.TabEnterUser.Controls.Add(this.UserID);
            this.TabEnterUser.Location = new System.Drawing.Point(4, 34);
            this.TabEnterUser.Name = "TabEnterUser";
            this.TabEnterUser.Padding = new System.Windows.Forms.Padding(3);
            this.TabEnterUser.Size = new System.Drawing.Size(744, 410);
            this.TabEnterUser.TabIndex = 1;
            this.TabEnterUser.Text = "Login Info";
            this.TabEnterUser.UseVisualStyleBackColor = true;
            this.TabEnterUser.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // TbConfrmPass
            // 
            this.TbConfrmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbConfrmPass.Location = new System.Drawing.Point(228, 238);
            this.TbConfrmPass.Name = "TbConfrmPass";
            this.TbConfrmPass.Size = new System.Drawing.Size(212, 30);
            this.TbConfrmPass.TabIndex = 8;
            this.TbConfrmPass.TextChanged += new System.EventHandler(this.TbConfrmPass_TextChanged);
            this.TbConfrmPass.Validating += new System.ComponentModel.CancelEventHandler(this.TbConfrmPass_Validating);
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(228, 174);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(212, 30);
            this.TbPassword.TabIndex = 7;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            this.TbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TbPassword_Validating);
            // 
            // TbUserName
            // 
            this.TbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUserName.Location = new System.Drawing.Point(228, 110);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(212, 30);
            this.TbUserName.TabIndex = 6;
            this.TbUserName.TextChanged += new System.EventHandler(this.TbUserName_TextChanged);
            this.TbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TbUserName_Validating);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(133, 46);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(59, 25);
            this.labelUserID.TabIndex = 5;
            this.labelUserID.Text = "{???}";
            this.labelUserID.Click += new System.EventHandler(this.labelUserID_Click);
            // 
            // CbIsActive
            // 
            this.CbIsActive.AutoSize = true;
            this.CbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsActive.Location = new System.Drawing.Point(49, 295);
            this.CbIsActive.Name = "CbIsActive";
            this.CbIsActive.Size = new System.Drawing.Size(97, 29);
            this.CbIsActive.TabIndex = 4;
            this.CbIsActive.Text = "Is Activ";
            this.CbIsActive.UseVisualStyleBackColor = true;
            this.CbIsActive.CheckedChanged += new System.EventHandler(this.CbIsActive_CheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(44, 174);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password :";
            // 
            // labelConfrmPassword
            // 
            this.labelConfrmPassword.AutoSize = true;
            this.labelConfrmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfrmPassword.Location = new System.Drawing.Point(44, 238);
            this.labelConfrmPassword.Name = "labelConfrmPassword";
            this.labelConfrmPassword.Size = new System.Drawing.Size(178, 25);
            this.labelConfrmPassword.TabIndex = 2;
            this.labelConfrmPassword.Text = "Confrm Password :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(44, 110);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(121, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name :";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(44, 46);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(83, 25);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "UserID :";
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(657, 561);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 47);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(514, 561);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(106, 47);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 50;
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 59);
            this.lblTitle.TabIndex = 121;
            this.lblTitle.Text = "Edit Application Type";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUbdateUser
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(775, 618);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUbdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add ubdate User";
            this.Load += new System.EventHandler(this.AddUbdateUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabEnterPerson.ResumeLayout(false);
            this.TabEnterUser.ResumeLayout(false);
            this.TabEnterUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabEnterPerson;
        private System.Windows.Forms.TabPage TabEnterUser;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfrmPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.CheckBox CbIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox TbConfrmPass;
        private System.Windows.Forms.TextBox TbPassword;
        private FilterPerson filterPerson1;
        private System.Windows.Forms.Label lblTitle;
    }
}