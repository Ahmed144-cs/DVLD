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
    public partial class ReleaseDetainedLicenseApplication : Form
    {
        public ReleaseDetainedLicenseApplication()
        {
            InitializeComponent();

            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;
        }

        public ReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();

            _SelectedLicenseID = LicenseID;

            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            this.ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private int _SelectedLicenseID = -1;


        private void ReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {

        }

        private void OnLicenseSelected(int  LicenseID)
        {
            _SelectedLicenseID = LicenseID;

            LabLicenseID.Text = _SelectedLicenseID.ToString();

            LlShowLicHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            //ToDo: make sure the license is not detained already.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LabApplicationFees.Text = ManageAppTypesLogic.Find((int)clsApplicationLogic.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            LabCreatedByUser.Text = clsGlobal.CurrUser.UserName;

            LabDetainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            LabLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            LabCreatedByUser.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            LabDetainDate.Text = clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate);
            LabFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            LabTotalFees.Text = (Convert.ToSingle(LabApplicationFees.Text) + Convert.ToSingle(LabFineFees.Text)).ToString();

            BtnRelease.Enabled = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;


            bool IsReleased = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrUser.UserID, ref ApplicationID); ;

            LabApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void LlShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(
                this.ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void ReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            this.ctrlDriverLicenseInfoWithFilter1.TbFocus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
