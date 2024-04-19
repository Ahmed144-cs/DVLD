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

namespace DVLD
{
    public partial class NewInternationalLicenseApp : Form
    {
        public NewInternationalLicenseApp()
        {
            InitializeComponent();
        }

        private int _InternationalLicenseID = -1;

        private void NewInternationalLicenseApp_Load(object sender, EventArgs e)
        {
            LabAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            LabIssuedDate.Text = LabAppDate.Text;

            LabCreateBy.Text = clsGlobal.CurrUser.UserName;

            LabExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));

            LabFees.Text = ManageAppTypesLogic.Find((int)clsApplicationLogic.enApplicationType.NewInternationalLicense).Fees.ToString();

            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;
        }

       
        void OnLicenseSelected(int  licenseID)
        {
            if (licenseID == -1)
                return;

            LlShowLicHistory.Enabled = (licenseID != -1);

            LabLocLicenseID.Text = licenseID.ToString();
            LicenseLogic LicesneInfo = LicenseLogic.Find(licenseID);

            if (LicesneInfo == null)
                return;

            //check the license class, person could not issue international license without having
            //normal license of class 3.

            if (this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternaionalLicenseID = InternationalLicenseLogic.GetActiveInternationalLicenseIDByDriverID(this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LlShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                BtnIssue.Enabled = false;
                return;
            }

            BtnIssue.Enabled = true;
        }

        #region
        private void LabI_D_L_AppID_Click(object sender, EventArgs e)
        {
        }
        private void LabAppDate_Click(object sender, EventArgs e)
        {
        }
        private void LabIssuedDate_Click(object sender, EventArgs e)
        {
        }
        private void LabFees_Click_1(object sender, EventArgs e)
        {
        }
        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            InternationalLicenseLogic InternationalLicense = new InternationalLicenseLogic();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplicationLogic.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = ManageAppTypesLogic.Find((int)clsApplicationLogic.enApplicationType.NewInternationalLicense).Fees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrUser.UserID;


            InternationalLicense.DriverID = this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.LocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            InternationalLicense.CreatedByUserID = clsGlobal.CurrUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LabI_D_L_AppID.Text = InternationalLicense.ApplicationID.ToString();

            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            LabIntLicID.Text = InternationalLicense.InternationalLicenseID.ToString();

            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnIssue.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            LlShowLicenseInfo.Enabled = true;
        }

       
        private void LlShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //InternationalLicenseInfo licensinfo = new InternationalLicenseInfo(_intLicenseID);
            //licensinfo.ShowDialog();
        }

        private void LlShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            licenseHistory.ShowDialog();
        }
    }
}
