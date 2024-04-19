namespace DVLD
{
    partial class PeopleForm
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
            this.labelManagePeople = new System.Windows.Forms.Label();
            this.DgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloas = new System.Windows.Forms.Button();
            this.labelRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbFiltorBy = new System.Windows.Forms.ComboBox();
            this.TbFiltorInput = new System.Windows.Forms.TextBox();
            this.labelCountRecord = new System.Windows.Forms.Label();
            this.PbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManagePeople
            // 
            this.labelManagePeople.AutoSize = true;
            this.labelManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePeople.Location = new System.Drawing.Point(510, 189);
            this.labelManagePeople.Name = "labelManagePeople";
            this.labelManagePeople.Size = new System.Drawing.Size(214, 32);
            this.labelManagePeople.TabIndex = 1;
            this.labelManagePeople.Text = "Manage People";
            // 
            // DgvPeople
            // 
            this.DgvPeople.AllowUserToAddRows = false;
            this.DgvPeople.AllowUserToDeleteRows = false;
            this.DgvPeople.AllowUserToOrderColumns = true;
            this.DgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvPeople.Location = new System.Drawing.Point(12, 293);
            this.DgvPeople.Name = "DgvPeople";
            this.DgvPeople.ReadOnly = true;
            this.DgvPeople.RowHeadersWidth = 51;
            this.DgvPeople.RowTemplate.Height = 24;
            this.DgvPeople.Size = new System.Drawing.Size(1211, 413);
            this.DgvPeople.TabIndex = 2;
            this.DgvPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeople_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.showToolStripMenuItem.Text = "show details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // BtnCloas
            // 
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.Location = new System.Drawing.Point(1068, 714);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 43);
            this.BtnCloas.TabIndex = 3;
            this.BtnCloas.Text = "Close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            this.BtnCloas.Click += new System.EventHandler(this.BtnCloas_Click);
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(12, 718);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 4;
            this.labelRecords.Text = "Recordes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtor by : ";
            // 
            // CbFiltorBy
            // 
            this.CbFiltorBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltorBy.FormattingEnabled = true;
            this.CbFiltorBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.CbFiltorBy.Location = new System.Drawing.Point(130, 241);
            this.CbFiltorBy.Name = "CbFiltorBy";
            this.CbFiltorBy.Size = new System.Drawing.Size(156, 33);
            this.CbFiltorBy.TabIndex = 7;
            this.CbFiltorBy.SelectedIndexChanged += new System.EventHandler(this.CbFiltorBy_SelectedIndexChanged);
            // 
            // TbFiltorInput
            // 
            this.TbFiltorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFiltorInput.Location = new System.Drawing.Point(292, 241);
            this.TbFiltorInput.Name = "TbFiltorInput";
            this.TbFiltorInput.Size = new System.Drawing.Size(196, 30);
            this.TbFiltorInput.TabIndex = 8;
            this.TbFiltorInput.Visible = false;
            this.TbFiltorInput.TextChanged += new System.EventHandler(this.TbFiltorInput_TextChanged);
            this.TbFiltorInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFiltorInput_KeyPress);
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(142, 721);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 9;
            this.labelCountRecord.Text = "???";
            this.labelCountRecord.Click += new System.EventHandler(this.labelCountRecord_Click);
            // 
            // PbAdd
            // 
            this.PbAdd.Image = global::DVLD.Properties.Resources.Icons8_Windows_8_Users_Add_User_512;
            this.PbAdd.Location = new System.Drawing.Point(1159, 231);
            this.PbAdd.Name = "PbAdd";
            this.PbAdd.Size = new System.Drawing.Size(64, 39);
            this.PbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAdd.TabIndex = 5;
            this.PbAdd.TabStop = false;
            this.PbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Arturo_Wibawa_Akar_People_group_512;
            this.pictureBox1.Location = new System.Drawing.Point(516, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(1235, 764);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.TbFiltorInput);
            this.Controls.Add(this.CbFiltorBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbAdd);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.BtnCloas);
            this.Controls.Add(this.DgvPeople);
            this.Controls.Add(this.labelManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelManagePeople;
        private System.Windows.Forms.DataGridView DgvPeople;
        private System.Windows.Forms.Button BtnCloas;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.PictureBox PbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFiltorBy;
        private System.Windows.Forms.TextBox TbFiltorInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label labelCountRecord;
    }
}