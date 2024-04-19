using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_LogicAccess.LicenseLogic;

namespace DVLD
{
    public partial class ReplacementLastOrDamagedLicApp : Form
    {
        public ReplacementLastOrDamagedLicApp()
        {
            InitializeComponent();
        }

        private int _NewLicID;

        private void ReplacementLastOrDamagedLicApp_Load(object sender, EventArgs e)
        {
            RbDamagedLic.Checked = true;

            LabAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            LabCreateBy.Text = clsGlobal.CurrUser.UserName;

            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;
        }

        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (RbDamagedLic.Checked)

                return (int)clsApplicationLogic.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplicationLogic.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (RbDamagedLic.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }

        private void RbDamagedLic_CheckedChanged(object sender, EventArgs e)
        {
            LabAppFees.Text = ManageAppTypesLogic.Find(_GetApplicationTypeID()).Fees.ToString();
            LabFormTitle.Text = "Replacement for Damaged License";
            this.Text = LabFormTitle.Text;
        }
      
        private void RbLastLic_CheckedChanged(object sender, EventArgs e)
        {
            LabAppFees.Text = ManageAppTypesLogic.Find(_GetApplicationTypeID()).Fees.ToString();
            LabFormTitle.Text = "Replacement for Lost License";
            this.Text = LabFormTitle.Text;
        }

        private void OnLicenseSelected(int  licenseID)
        {
            LabLicID.Text = licenseID.ToString();
            LlShowLicHistory.Enabled = (licenseID != -1);

            if (licenseID == -1)
                return;

            //check the license is not Expired.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                BtnIssue.Enabled = false;
                return;
            }

            BtnIssue.Enabled = true;
        }

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            LicenseLogic NewLicense = ctrlDriverLicenseInfoWithFilter1.
                                        SelectedLicenseInfo.ReplaceLastOrDamagedLic(
                                                          _GetIssueReason(),
                                                          clsGlobal.CurrUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Lab_D_L_AppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicID = NewLicense.LicenseID;

            LabNewLicenseID.Text = _NewLicID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnIssue.Enabled = false;

            RbDamagedLic.Enabled = false;
            RbLastLic.Enabled = false;  

            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            LlShowNewLicenseInfo.Enabled = true;
        }

        private void LlShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense licInfo = new ShowLicense(_NewLicID);
            licInfo.ShowDialog();
        }

        private void LlShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licHistory = new LicenseHistory(this.ctrlDriverLicenseInfoWithFilter1
                                                     .SelectedLicenseInfo.DriverInfo.PersonID);
            licHistory.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        private void LabNewLicenseID_Click(object sender, EventArgs e)
        {
        }

        private void LabAppFees_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void ReplacementLastOrDamagedLicApp_Activated(object sender, EventArgs e)
        {
            this.ctrlDriverLicenseInfoWithFilter1.TbFocus();
        }
    }
}
