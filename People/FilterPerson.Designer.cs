namespace DVLD
{
    partial class FilterPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbSearchBy = new System.Windows.Forms.ComboBox();
            this.TbSearchInput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            this.PbAdd = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbFilter = new System.Windows.Forms.GroupBox();
            this.personInfoUC1 = new DVLD.PersonInfoUC();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.GbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // CbSearchBy
            // 
            this.CbSearchBy.AutoCompleteCustomSource.AddRange(new string[] {
            "National No",
            "Person ID"});
            this.CbSearchBy.FormattingEnabled = true;
            this.CbSearchBy.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.CbSearchBy.Location = new System.Drawing.Point(85, 33);
            this.CbSearchBy.Name = "CbSearchBy";
            this.CbSearchBy.Size = new System.Drawing.Size(121, 24);
            this.CbSearchBy.TabIndex = 1;
            this.CbSearchBy.SelectedIndexChanged += new System.EventHandler(this.CbSearchBy_SelectedIndexChanged);
            // 
            // TbSearchInput
            // 
            this.TbSearchInput.Location = new System.Drawing.Point(222, 33);
            this.TbSearchInput.Name = "TbSearchInput";
            this.TbSearchInput.Size = new System.Drawing.Size(129, 22);
            this.TbSearchInput.TabIndex = 2;
            this.TbSearchInput.TextChanged += new System.EventHandler(this.TbSearchInput_TextChanged);
            this.TbSearchInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearchInput_KeyPress);
            this.TbSearchInput.Validating += new System.ComponentModel.CancelEventHandler(this.TbSearchInput_Validating);
            // 
            // PbSearch
            // 
            this.PbSearch.Image = global::DVLD.Properties.Resources.search;
            this.PbSearch.Location = new System.Drawing.Point(373, 33);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(37, 24);
            this.PbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbSearch.TabIndex = 3;
            this.PbSearch.TabStop = false;
            this.PbSearch.Click += new System.EventHandler(this.PbSearch_Click);
            // 
            // PbAdd
            // 
            this.PbAdd.Image = global::DVLD.Properties.Resources.Icons8_Windows_8_Users_Add_User_512;
            this.PbAdd.Location = new System.Drawing.Point(432, 33);
            this.PbAdd.Name = "PbAdd";
            this.PbAdd.Size = new System.Drawing.Size(37, 24);
            this.PbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAdd.TabIndex = 4;
            this.PbAdd.TabStop = false;
            this.PbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GbFilter
            // 
            this.GbFilter.Controls.Add(this.CbSearchBy);
            this.GbFilter.Controls.Add(this.label1);
            this.GbFilter.Controls.Add(this.PbAdd);
            this.GbFilter.Controls.Add(this.TbSearchInput);
            this.GbFilter.Controls.Add(this.PbSearch);
            this.GbFilter.Location = new System.Drawing.Point(15, 16);
            this.GbFilter.Name = "GbFilter";
            this.GbFilter.Size = new System.Drawing.Size(672, 74);
            this.GbFilter.TabIndex = 6;
            this.GbFilter.TabStop = false;
            this.GbFilter.Text = "Filter";
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personInfoUC1.Location = new System.Drawing.Point(15, 96);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(672, 215);
            this.personInfoUC1.TabIndex = 5;
            // 
            // FilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbFilter);
            this.Controls.Add(this.personInfoUC1);
            this.Name = "FilterPerson";
            this.Size = new System.Drawing.Size(726, 325);
            this.Load += new System.EventHandler(this.FilterPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.GbFilter.ResumeLayout(false);
            this.GbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSearchBy;
        private System.Windows.Forms.TextBox TbSearchInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox PbSearch;
        private System.Windows.Forms.PictureBox PbAdd;
        private PersonInfoUC personInfoUC1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox GbFilter;
    }
}
