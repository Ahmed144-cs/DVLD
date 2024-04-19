using DVLD.Properties;
using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private int _InternationalLicenseID;
        private InternationalLicenseLogic _InternationalLicenseInfo;

        public int InternationalLicenseID { get { return _InternationalLicenseID; } }
        public InternationalLicenseLogic SelectedInterNationalLicInfo { get { return _InternationalLicenseInfo; } }

        private void ctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int InternationalLicenseInfo)
        {
            _InternationalLicenseID = InternationalLicenseInfo;

            _InternationalLicenseInfo = InternationalLicenseLogic.Find(_InternationalLicenseID);
            if( _InternationalLicenseInfo == null )
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            LabName.Text = _InternationalLicenseInfo.DriverInfo.PersonInfo.FullName;
            LabI_D_L_AppID.Text = _InternationalLicenseInfo.ApplicationID.ToString();
            LabIsActive.Text = _InternationalLicenseInfo.IsActive ? "true" : "false";
            LabIssuedDate.Text = clsFormat.DateToShort(_InternationalLicenseInfo.IssueDate);
            LavDateOfBirth.Text = clsFormat.DateToShort(_InternationalLicenseInfo.DriverInfo.PersonInfo.DateOfBirth);
            LabNationalNo.Text = _InternationalLicenseInfo.DriverInfo.PersonInfo.NationalOn;
            LabIntLicID.Text = _InternationalLicenseID.ToString();
            LabLocLicenseID.Text = _InternationalLicenseInfo.LocalLicenseID.ToString();
            LabExpirationDate.Text = clsFormat.DateToShort(_InternationalLicenseInfo.ExpirationDate);
            LabDriverID.Text = _InternationalLicenseInfo.DriverID.ToString();
            LabGendor.Text = _InternationalLicenseInfo.DriverInfo.PersonInfo.Gender == 0 ? "Female" : "Male";

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_InternationalLicenseInfo.DriverInfo.PersonInfo.Gender == 0)
                PbPersonImage.Image = Resources.admin_female;
            else
                PbPersonImage.Image = Resources.admin;

            string ImagePath = _InternationalLicenseInfo.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    PbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
