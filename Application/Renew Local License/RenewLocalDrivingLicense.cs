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
    public partial class RenewLocalDrivingLicense : Form
    {
        public RenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private int _NewLicenseID;

        private void RenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            LabAppDate.Text = clsFormat.DateToShort(DateTime.Now);

            LabCreateBy.Text = clsGlobal.CurrUser.UserName;

            LabIssuedDate.Text = LabAppDate.Text;

            LabAppFees.Text = ManageAppTypesLogic.Find((int)clsApplicationLogic.enApplicationType.RenewDrivingLicense).Fees.ToString();

            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;
        }

        private void OnLicenseSelected(int LicenseID)
        {
            LabLicID.Text = LicenseID.ToString();

            LlShowLicHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
                return;

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            LabExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            LabLicFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            LabTotalFees.Text = (Convert.ToSingle(LabAppFees.Text) + Convert.ToSingle(LabLicFees.Text)).ToString();
            TbNote.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            //check the license is not Expired.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                BtnIssue.Enabled = false;
                return;
            }

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
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            LicenseLogic NewLicense = ctrlDriverLicenseInfoWithFilter1.
                                            SelectedLicenseInfo.RenewLicense(
                                                    TbNote.Text.Trim(),
                                                    clsGlobal.CurrUser.UserID);

            if(NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lab_D_L_AppID.Text = NewLicense.ApplicationID.ToString();
            LabNewLicenseID.Text = NewLicense.LicenseID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            LlShowLicHistory.Enabled = true;
            LlShowNewLicenseInfo.Enabled = true;
            BtnIssue.Enabled = false;

            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense lic = new ShowLicense(_NewLicenseID);
            lic.ShowDialog();
        }

        #region
        private void LabAppDate_Click(object sender, EventArgs e)
        {
        }
        private void LabIssuedDate_Click(object sender, EventArgs e)
        {
        }
        private void LabCreateBy_Click(object sender, EventArgs e)
        {
        }
        private void LabLicID_Click(object sender, EventArgs e)
        {
        }
        private void Lab_D_L_AppID_Click(object sender, EventArgs e)
        {
        }
        private void LabExpirationDate_Click(object sender, EventArgs e)
        {
        }
        private void LabLicFees_Click(object sender, EventArgs e)
        {
        }
        private void LabAppFees_Click(object sender, EventArgs e)
        {
        }
        private void LabTotalFees_Click(object sender, EventArgs e)
        {
        }
        private void TbNote_TextChanged(object sender, EventArgs e)
        {
        }
        private void LabNewLicenseID_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void LlShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(this.ctrlDriverLicenseInfoWithFilter1.
                                                       SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void RenewLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            this.ctrlDriverLicenseInfoWithFilter1.TbFocus();
        }
    }
}
