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
    public partial class IssueDrivingLicenseFirstTime : Form
    {
        public IssueDrivingLicenseFirstTime(int DrivLicAppID)
        {
            InitializeComponent();

            _LocalDrivLicAppID = DrivLicAppID;
            TbNote.MaxLength = 100;
        }

        private int _LocalDrivLicAppID;
        LocalDrivingLicenseApplicationLogic _LocalDrivLicAppLogic;

        private void IssueDrivingLicenseFirstTime_Load(object sender, EventArgs e)
        {
            _LocalDrivLicAppLogic = LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(_LocalDrivLicAppID);

            if(_LocalDrivLicAppLogic == null)
            {
                MessageBox.Show("No Applicaiton with ID=" + _LocalDrivLicAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            TbNote.Focus();

            if (!_LocalDrivLicAppLogic.PassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LocalDrivLicAppLogic.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.ctrlDrivLicAppInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivLicAppID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        private void TbNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void drivingLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int LicenseID = _LocalDrivLicAppLogic.IssueLicenseForTheFirtTime(TbNote.Text.Trim(), clsGlobal.CurrUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
