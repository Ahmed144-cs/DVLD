using DVLD.Properties;
using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class DriverLicenseInfo : UserControl
    {
        public DriverLicenseInfo()
        {
            InitializeComponent();
        }

        private int _LicenseID;
        private LicenseLogic _License;

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public LicenseLogic SelectedLicenseInfo
        {
            get { return _License; }
        }

        private void DriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = LicenseLogic.Find(LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            LabClassType.Text = _License.LicenseClassIfo.ClassName;
            LabName.Text = _License.DriverInfo.PersonInfo.FullName;
            LabLicenseID.Text = _LicenseID.ToString();
            LabNationalNo.Text = _License.DriverInfo.PersonInfo.NationalOn;
            LabGendor.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Female" : "Male";
            LabIssuedDate.Text = _License.IssueDate.ToString();
            LabExpirationDate.Text = _License.ExpirationDate.ToString();
            LavDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
            LabIssuedReason.Text = _License.IssueReasonText;
            LabIsActive.Text =  _License.IsActive == Convert.ToBoolean(1) ? "true" : "false";
            LabNote.Text = _License.Notes == "" ? "No Notes" : _License.Notes; ;
            LabDriverID.Text = _License.DriverID.ToString();
            LabIsDetained.Text = (_License.IsDetained == true) ? "Yes" : "No";

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                PbPersonImage.Image = Resources.admin_female;
            else
                PbPersonImage.Image = Resources.admin;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    PbPersonImage.Load(ImagePath);
                }
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        #region
        private void PbPersonImage_Click(object sender, EventArgs e)
        {
        }
        private void LabGendor_Click(object sender, EventArgs e)
        {
        }
        private void LabClassType_Click(object sender, EventArgs e)
        {
        }
        private void LabName_Click(object sender, EventArgs e)
        {
        }
        private void LabLicenseID_Click(object sender, EventArgs e)
        {
        }
        private void LabNationalNo_Click(object sender, EventArgs e)
        {
        }
        private void LabIssuedDate_Click(object sender, EventArgs e)
        {
        }
        private void LabIssuedReason_Click(object sender, EventArgs e)
        {
        }
        private void LabIsActive_Click(object sender, EventArgs e)
        {
        }
        private void LabDriverID_Click(object sender, EventArgs e)
        {
        }
        private void LabExpirationDate_Click(object sender, EventArgs e)
        {
        }
        private void LavDateOfBirth_Click(object sender, EventArgs e)
        {

        }
        private void LabNote_Click(object sender, EventArgs e)
        {

        }
        private void LabIsDetained_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
