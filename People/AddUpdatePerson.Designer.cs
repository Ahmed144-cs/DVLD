namespace DVLD
{
    partial class AddUpdatePerson
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelPersonID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelRemoveImage = new System.Windows.Forms.LinkLabel();
            this.linkLabelSetImage = new System.Windows.Forms.LinkLabel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PbPersonImage = new System.Windows.Forms.PictureBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbCountry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.labelGendor = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TbNational = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbSecondName = new System.Windows.Forms.TextBox();
            this.TbThirdName = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPersonID
            // 
            this.labelPersonID.AutoSize = true;
            this.labelPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonID.Location = new System.Drawing.Point(134, 66);
            this.labelPersonID.Name = "labelPersonID";
            this.labelPersonID.Size = new System.Drawing.Size(49, 29);
            this.labelPersonID.TabIndex = 3;
            this.labelPersonID.Text = "???";
            this.labelPersonID.Click += new System.EventHandler(this.labelPersonID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelRemoveImage);
            this.groupBox1.Controls.Add(this.linkLabelSetImage);
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.PbPersonImage);
            this.groupBox1.Controls.Add(this.TbAddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CbCountry);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TbEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RbFemale);
            this.groupBox1.Controls.Add(this.RbMale);
            this.groupBox1.Controls.Add(this.labelGendor);
            this.groupBox1.Controls.Add(this.TbPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DtpDateOfBirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbNational);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TbLastName);
            this.groupBox1.Controls.Add(this.TbSecondName);
            this.groupBox1.Controls.Add(this.TbThirdName);
            this.groupBox1.Controls.Add(this.TbFirstName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // linkLabelRemoveImage
            // 
            this.linkLabelRemoveImage.AutoSize = true;
            this.linkLabelRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRemoveImage.Location = new System.Drawing.Point(559, 193);
            this.linkLabelRemoveImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRemoveImage.Name = "linkLabelRemoveImage";
            this.linkLabelRemoveImage.Size = new System.Drawing.Size(120, 20);
            this.linkLabelRemoveImage.TabIndex = 50;
            this.linkLabelRemoveImage.TabStop = true;
            this.linkLabelRemoveImage.Text = "Remove Image";
            this.linkLabelRemoveImage.Visible = false;
            this.linkLabelRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRemoveImage_LinkClicked);
            // 
            // linkLabelSetImage
            // 
            this.linkLabelSetImage.AutoSize = true;
            this.linkLabelSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSetImage.Location = new System.Drawing.Point(580, 169);
            this.linkLabelSetImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelSetImage.Name = "linkLabelSetImage";
            this.linkLabelSetImage.Size = new System.Drawing.Size(84, 20);
            this.linkLabelSetImage.TabIndex = 45;
            this.linkLabelSetImage.TabStop = true;
            this.linkLabelSetImage.Text = "Set Image";
            this.linkLabelSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetImage_LinkClicked);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(647, 236);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 34);
            this.BtnClose.TabIndex = 48;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(554, 236);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(60, 34);
            this.BtnSave.TabIndex = 46;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(596, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Set Image";
            // 
            // PbPersonImage
            // 
            this.PbPersonImage.Image = global::DVLD.Properties.Resources.admin;
            this.PbPersonImage.Location = new System.Drawing.Point(554, 40);
            this.PbPersonImage.Margin = new System.Windows.Forms.Padding(2);
            this.PbPersonImage.Name = "PbPersonImage";
            this.PbPersonImage.Size = new System.Drawing.Size(153, 107);
            this.PbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPersonImage.TabIndex = 54;
            this.PbPersonImage.TabStop = false;
            // 
            // TbAddress
            // 
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddress.Location = new System.Drawing.Point(123, 208);
            this.TbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TbAddress.Multiline = true;
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(376, 76);
            this.TbAddress.TabIndex = 43;
            this.TbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Address";
            // 
            // CbCountry
            // 
            this.CbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCountry.FormattingEnabled = true;
            this.CbCountry.Location = new System.Drawing.Point(358, 172);
            this.CbCountry.Margin = new System.Windows.Forms.Padding(2);
            this.CbCountry.Name = "CbCountry";
            this.CbCountry.Size = new System.Drawing.Size(126, 28);
            this.CbCountry.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Country";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(123, 172);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(118, 27);
            this.TbEmail.TabIndex = 41;
            this.TbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmail_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Email";
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFemale.Location = new System.Drawing.Point(446, 133);
            this.RbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(85, 24);
            this.RbFemale.TabIndex = 39;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            this.RbFemale.Click += new System.EventHandler(this.RbFemale_Click);
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMale.Location = new System.Drawing.Point(358, 135);
            this.RbMale.Margin = new System.Windows.Forms.Padding(2);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(66, 24);
            this.RbMale.TabIndex = 38;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            this.RbMale.Click += new System.EventHandler(this.RbMale_Click);
            // 
            // labelGendor
            // 
            this.labelGendor.AutoSize = true;
            this.labelGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGendor.Location = new System.Drawing.Point(285, 135);
            this.labelGendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGendor.Name = "labelGendor";
            this.labelGendor.Size = new System.Drawing.Size(64, 20);
            this.labelGendor.TabIndex = 49;
            this.labelGendor.Text = "Gendor";
            // 
            // TbPhone
            // 
            this.TbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPhone.Location = new System.Drawing.Point(358, 88);
            this.TbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(128, 27);
            this.TbPhone.TabIndex = 33;
            this.TbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Phone";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CustomFormat = "dd/M/yyyy";
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(123, 127);
            this.DtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(118, 27);
            this.DtpDateOfBirth.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Date of Birth";
            // 
            // TbNational
            // 
            this.TbNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNational.Location = new System.Drawing.Point(123, 88);
            this.TbNational.Margin = new System.Windows.Forms.Padding(2);
            this.TbNational.Name = "TbNational";
            this.TbNational.Size = new System.Drawing.Size(118, 27);
            this.TbNational.TabIndex = 31;
            this.TbNational.Validating += new System.ComponentModel.CancelEventHandler(this.TbNational_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "National No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "third";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Second";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "First";
            // 
            // TbLastName
            // 
            this.TbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLastName.Location = new System.Drawing.Point(449, 40);
            this.TbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(82, 27);
            this.TbLastName.TabIndex = 30;
            this.TbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // TbSecondName
            // 
            this.TbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSecondName.Location = new System.Drawing.Point(231, 44);
            this.TbSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.TbSecondName.Name = "TbSecondName";
            this.TbSecondName.Size = new System.Drawing.Size(82, 27);
            this.TbSecondName.TabIndex = 28;
            this.TbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // TbThirdName
            // 
            this.TbThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbThirdName.Location = new System.Drawing.Point(342, 40);
            this.TbThirdName.Margin = new System.Windows.Forms.Padding(2);
            this.TbThirdName.Name = "TbThirdName";
            this.TbThirdName.Size = new System.Drawing.Size(82, 27);
            this.TbThirdName.TabIndex = 29;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFirstName.Location = new System.Drawing.Point(123, 44);
            this.TbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(82, 27);
            this.TbFirstName.TabIndex = 27;
            this.TbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(14, 47);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Name";
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.ForeColor = System.Drawing.Color.Red;
            this.FormLabel.Location = new System.Drawing.Point(265, 16);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(239, 32);
            this.FormLabel.TabIndex = 6;
            this.FormLabel.Text = "Add New Person";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddUpdatePerson
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(768, 399);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPersonID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Or Update Person";
            this.Load += new System.EventHandler(this.AddNewPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPersonID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabelRemoveImage;
        private System.Windows.Forms.LinkLabel linkLabelSetImage;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PbPersonImage;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.Label labelGendor;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbNational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbSecondName;
        private System.Windows.Forms.TextBox TbThirdName;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}