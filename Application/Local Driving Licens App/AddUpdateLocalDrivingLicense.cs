using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddUpdateLocalDrivingLicense : Form
    {  
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;

        LocalDrivingLicenseApplicationLogic _LocalDrivingLicenseApplication;

        public void ClosePersonFilter(bool value)
        {
            this.filterPerson1.FilterEnabled = value;
        }

        public AddUpdateLocalDrivingLicense()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public AddUpdateLocalDrivingLicense(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void NewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            this.filterPerson1.OnPersonSelected += _OnPersonSelected;

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillLicenseClassesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                LabFormText.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new LocalDrivingLicenseApplicationLogic();
                this.filterPerson1.FilterFocus();
                tabAppInfo.Enabled = false;

                CbLicenseClass.SelectedIndex = 2;
                LabAppFees.Text = ManageAppTypesLogic.Find(
                                            (int)clsApplicationLogic.enApplicationType.NewDrivingLicense).Fees.ToString();
                LabAppData.Text = DateTime.Now.ToShortDateString();
                LabCreatedBy.Text = clsGlobal.CurrUser.UserName;
            }
            else
            {
                LabFormText.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";

                tabAppInfo.Enabled = true;
                BtnSave.Enabled = true;
            }
        }

        private void _FillLicenseClassesInComoboBox()
        {
            DataTable dtLicenseClasses = LicenseClassLogic.GetLicenseClassData();
            dtLicenseClasses.Columns.Remove("LicenseClassID");

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                CbLicenseClass.Items.Add(row["ClassName"]);
            }
        }

        private void _LoadData()
        {
            this.filterPerson1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            this.filterPerson1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            LabDrvLicAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LabAppData.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString("dd/MMM/yyyy");
            CbLicenseClass.SelectedIndex = CbLicenseClass.FindString(LicenseClassLogic.Find(
                                                _LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            LabAppFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            LabCreatedBy.Text = UserLogic.FindUser(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                BtnSave.Enabled = true;
                tabAppInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabAppInfo"];
                return;
            }

            //incase of add new mode.
            if (this.filterPerson1.PersonID != -1)
            {
                BtnSave.Enabled = true;
                tabAppInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabAppInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.filterPerson1.FilterFocus();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseClassID = LicenseClassLogic.Find(CbLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplicationLogic.GetActiveAppIDForLicenseClass(
                                          _SelectedPersonID, clsApplicationLogic.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbLicenseClass.Focus();
                return;
            }

            if (LicenseLogic.IsLicenseExistByPersonID(this.filterPerson1.PersonID, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = this.filterPerson1.PersonID; ;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = (int)clsApplicationLogic.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplicationLogic.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(LabAppFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            if (_LocalDrivingLicenseApplication.Save())
            {
                LabDrvLicAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                LabFormText.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _OnPersonSelected(int PersonID)
        {
            _SelectedPersonID = PersonID;
        }

        #region
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {

        }

        private void LabDrvLicAppID_Click(object sender, EventArgs e)
        {

        }

        private void LabAppData_Click(object sender, EventArgs e)
        {

        }

        private void CbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabAppFees_Click(object sender, EventArgs e)
        {

        }

        private void LabCreatedBy_Click(object sender, EventArgs e)
        {

        }
        private void tabAppInfo_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
