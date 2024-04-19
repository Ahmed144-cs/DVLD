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
    public partial class ApplicationBasicInfo : UserControl
    {
        public ApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private clsApplicationLogic _Application;

        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }


        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplicationLogic.FindBaseApplication(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            LabBassLicAppID.Text = "{???}";
            LabStatus.Text = "{???}";
            LabAppType.Text = "{???}";
            LabFees.Text = "{???}";
            LabApplicant.Text = "{???}";
            LabDate.Text = "{???}";
            LabStatusDate.Text = "{???}";
            LabCreateBy.Text = "{???}";
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            LabBassLicAppID.Text = _Application.ApplicationID.ToString();
            LabStatus.Text = _Application.StatusText;
            LabAppType.Text = _Application.ApplicationTypeInfo.Title;
            LabFees.Text = _Application.PaidFees.ToString();
            LabApplicant.Text = _Application.ApplicantFullName;
            LabDate.Text = _Application.ApplicationDate.ToString("dd/MMM/yyyy");
            LabStatusDate.Text = _Application.LastStatusDate.ToString("dd/MMM/yyyy");
            LabCreateBy.Text = _Application.CreatedByUserInfo.UserName;
        }

        private void LlShowPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersoDetails person = new PersoDetails(_Application.ApplicantPersonID);
            person.ShowDialog();

            //Refresh
            LoadApplicationInfo(_ApplicationID);
        }

        private void ApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
