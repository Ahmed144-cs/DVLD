namespace DVLD
{
    partial class ListTestAppointment
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
            this.PbAddSechdule = new System.Windows.Forms.PictureBox();
            this.DgvAppointmentTest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCountRecord = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.BtnCloas = new System.Windows.Forms.Button();
            this.LabFormText = new System.Windows.Forms.Label();
            this.ctrlDrivLicAppInfo1 = new DVLD.ctrlDrivLicAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddSechdule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentTest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Appointment :";
            // 
            // PbAddSechdule
            // 
            this.PbAddSechdule.Image = global::DVLD.Properties.Resources.Hopstarter_Button_Button_Add_256;
            this.PbAddSechdule.Location = new System.Drawing.Point(863, 512);
            this.PbAddSechdule.Name = "PbAddSechdule";
            this.PbAddSechdule.Size = new System.Drawing.Size(51, 35);
            this.PbAddSechdule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAddSechdule.TabIndex = 8;
            this.PbAddSechdule.TabStop = false;
            this.PbAddSechdule.Click += new System.EventHandler(this.PbAddSechdule_Click);
            // 
            // DgvAppointmentTest
            // 
            this.DgvAppointmentTest.AllowUserToAddRows = false;
            this.DgvAppointmentTest.AllowUserToDeleteRows = false;
            this.DgvAppointmentTest.AllowUserToOrderColumns = true;
            this.DgvAppointmentTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAppointmentTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAppointmentTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppointmentTest.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvAppointmentTest.Location = new System.Drawing.Point(12, 553);
            this.DgvAppointmentTest.Name = "DgvAppointmentTest";
            this.DgvAppointmentTest.ReadOnly = true;
            this.DgvAppointmentTest.RowHeadersWidth = 51;
            this.DgvAppointmentTest.RowTemplate.Height = 24;
            this.DgvAppointmentTest.Size = new System.Drawing.Size(902, 170);
            this.DgvAppointmentTest.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.Location = new System.Drawing.Point(126, 740);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(49, 29);
            this.labelCountRecord.TabIndex = 19;
            this.labelCountRecord.Text = "???";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(7, 739);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(124, 29);
            this.labelRecords.TabIndex = 18;
            this.labelRecords.Text = "Recordes:";
            // 
            // BtnCloas
            // 
            this.BtnCloas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloas.Location = new System.Drawing.Point(759, 729);
            this.BtnCloas.Name = "BtnCloas";
            this.BtnCloas.Size = new System.Drawing.Size(155, 39);
            this.BtnCloas.TabIndex = 20;
            this.BtnCloas.Text = "close";
            this.BtnCloas.UseVisualStyleBackColor = true;
            // 
            // LabFormText
            // 
            this.LabFormText.AutoSize = true;
            this.LabFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFormText.ForeColor = System.Drawing.Color.Red;
            this.LabFormText.Location = new System.Drawing.Point(380, 19);
            this.LabFormText.Name = "LabFormText";
            this.LabFormText.Size = new System.Drawing.Size(166, 32);
            this.LabFormText.TabIndex = 21;
            this.LabFormText.Text = "Vision Test";
            // 
            // ctrlDrivLicAppInfo1
            // 
            this.ctrlDrivLicAppInfo1.Location = new System.Drawing.Point(12, 73);
            this.ctrlDrivLicAppInfo1.Name = "ctrlDrivLicAppInfo1";
            this.ctrlDrivLicAppInfo1.Size = new System.Drawing.Size(902, 436);
            this.ctrlDrivLicAppInfo1.TabIndex = 13;
            // 
            // ListTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCloas;
            this.ClientSize = new System.Drawing.Size(926, 776);
            this.Controls.Add(this.LabFormText);
            this.Controls.Add(this.BtnCloas);
            this.Controls.Add(this.labelCountRecord);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.ctrlDrivLicAppInfo1);
            this.Controls.Add(this.DgvAppointmentTest);
            this.Controls.Add(this.PbAddSechdule);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Test Appointment";
            this.Load += new System.EventHandler(this.ListTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbAddSechdule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentTest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbAddSechdule;
        private System.Windows.Forms.DataGridView DgvAppointmentTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private ctrlDrivLicAppInfo ctrlDrivLicAppInfo1;
        private System.Windows.Forms.Label labelCountRecord;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Button BtnCloas;
        private System.Windows.Forms.Label LabFormText;
    }
}