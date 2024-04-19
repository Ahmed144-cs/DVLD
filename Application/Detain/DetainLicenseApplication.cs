using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class DetainLicenseApplication : Form
    {
        public DetainLicenseApplication()
        {
            InitializeComponent();
        }

        private int _LicenseID = -1;
        private int _DetainID;

        private void DetainLicenseApplication_Load(object sender, EventArgs e)
        {
            LabDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            LabCreatedByUser.Text = clsGlobal.CurrUser.UserName;

            if (_LicenseID == -1)
                this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            DetainLicenseApplication_Activated(null, null);
        }

        private void OnLicenseSelected(int  licenseID)
        {
            _LicenseID = licenseID;
            LabLicenseID.Text = licenseID.ToString();

            LlShowLicHistory.Enabled = (_LicenseID != -1);

            if (_LicenseID == -1)
                return;

            if (this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TbFineFees.Focus();
            BtnDetain.Enabled = true;
        }

        private void BtnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!TbFineFeesValidating())
                return;

            _DetainID = this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo
                                    .Detain(Convert.ToSingle(TbFineFees.Text), clsGlobal.CurrUser.UserID);

            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LabDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            TbFineFees.Enabled = false;
            LlShowLicHistory.Enabled = true;    
        }

        private void LlShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private bool TbFineFeesValidating()
        {
            if (string.IsNullOrEmpty(TbFineFees.Text.Trim()))
            {
                errorProvider1.SetError(TbFineFees, "Fees cannot be empty!");
                return false;
            }
            else
            {
                errorProvider1.SetError(TbFineFees, null);
            };


            if (!clsValidatoin.IsNumber(TbFineFees.Text))
            {
                errorProvider1.SetError(TbFineFees, "Invalid Number.");
                return false;
            }
            else
            {
                errorProvider1.SetError(TbFineFees, null);
            };

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            this.ctrlDriverLicenseInfoWithFilter1.TbFocus();
        }
    }
}
