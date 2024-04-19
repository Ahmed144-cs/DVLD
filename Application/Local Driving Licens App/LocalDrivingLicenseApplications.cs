using DVLD_LogicAccess;
using System;
using System.CodeDom;
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
    public partial class LocalDrivingLicenseApplications : Form
    {
        public LocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private DataTable _dtLocalDrivLicenseApp;


        private void LocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtLocalDrivLicenseApp = LocalDrivingLicenseApplicationLogic.GetAllLocalDrivingLicenseApplications();
            DgvLocalDrivLicApp.DataSource = _dtLocalDrivLicenseApp;

            if (DgvLocalDrivLicApp.Rows.Count == 0)
                return;

            DgvLocalDrivLicApp.Columns[0].HeaderText = "L.D.L.AppID";
            DgvLocalDrivLicApp.Columns[1].HeaderText = "Driving Class";
            DgvLocalDrivLicApp.Columns[2].HeaderText = "Application Date";
            DgvLocalDrivLicApp.Columns[3].HeaderText = "National No.";
            DgvLocalDrivLicApp.Columns[4].HeaderText = "Full Name";
            DgvLocalDrivLicApp.Columns[5].HeaderText = "Passed Test Count"; 
            DgvLocalDrivLicApp.Columns[6].HeaderText = "Status";

            _CountRecord();
            CbFiltorBy.SelectedItem = "None";
        }

        private void _loadData()
        {
        }

        private void _CountRecord()
        {
            labelCountRecord.Text = DgvLocalDrivLicApp.RowCount.ToString();
        }

        private void BtnCloas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            AddUpdateLocalDrivingLicense newLDrivLicApp = new AddUpdateLocalDrivingLicense();
            newLDrivLicApp.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void CbFiltorBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbFiltorInput.Visible = (CbFiltorBy.Text != "None");

            if (TbFiltorInput.Visible)
            {
                TbFiltorInput.Text = "";
                TbFiltorInput.Focus();
            }

            _dtLocalDrivLicenseApp.DefaultView.RowFilter = "";
            _CountRecord();
        }

        private void TbFiltorInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFiltorBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseID";
                    break;

                case "National No":
                    FilterColumn = "NationalOn";
                    break;

                case "Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "GendorCaption";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbFiltorInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtLocalDrivLicenseApp.DefaultView.RowFilter = "";
                _CountRecord();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseID")
                //in this case we deal with integer not string.
                _dtLocalDrivLicenseApp.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TbFiltorInput.Text.Trim());
            else
                _dtLocalDrivLicenseApp.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TbFiltorInput.Text.Trim());

            _CountRecord();
        }

        private void TbFiltorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFiltorBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateLocalDrivingLicense addUpdateLocalDrivingLicense = new AddUpdateLocalDrivingLicense((int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value);
            addUpdateLocalDrivingLicense.ClosePersonFilter(false); // false to close person filter 
            addUpdateLocalDrivingLicense.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void cancelApplcationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value;

            LocalDrivingLicenseApplicationLogic LocalDrivingLicenseApplication =
                LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    LocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            LocalDrivingLicenseApplicationLogic LocalDrivingLicenseApplication = 
                                         LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(
                                                           (int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value);

            int TotalPassedTests = (int)DgvLocalDrivLicApp.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            cancelApplcationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus 
                                                            == clsApplicationLogic.enApplicationStatus.New);

            deleteApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus
                                                            == clsApplicationLogic.enApplicationStatus.New);


            //Enabled only if person passed all tests and Does not have license. 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = LicenseExists;

            editApplicationToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplicationLogic.enApplicationStatus.New);

            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(ManageTestTypeLogic.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(ManageTestTypeLogic.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(ManageTestTypeLogic.enTestType.StreetTest);

            sechduleTestToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest)
                                                    && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplicationLogic.enApplicationStatus.New);

            sechduleTestToolStripMenuItem.Enabled = !LicenseExists;

            if (sechduleTestToolStripMenuItem.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                sToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                sToolStripMenuItem1.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                sToolStripMenuItem2.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }

        private void _ScheduleTest(ManageTestTypeLogic.enTestType TestType)
        {
            ListTestAppointment frm = new ListTestAppointment((int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value, TestType);
            frm.ShowDialog();
            //refresh
            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(ManageTestTypeLogic.enTestType.VisionTest);
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _ScheduleTest(ManageTestTypeLogic.enTestType.WrittenTest);
        }

        private void sToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _ScheduleTest(ManageTestTypeLogic.enTestType.StreetTest);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseFirstTime licence = new IssueDrivingLicenseFirstTime((int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value); 
            licence.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value;

            int LicenseID = LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(
                                    LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if(LicenseID != -1)
            {
                ShowLicense showLic = new ShowLicense(LicenseID);
                showLic.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value;

            LocalDrivingLicenseApplicationLogic LocalDrivingLicenseApplication =
                LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    LocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory personHistory = new LicenseHistory(PersonLogic.Find((string)DgvLocalDrivLicApp.CurrentRow.Cells["NationalOn"].Value).PersonID);
            personHistory.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        #region
        private void DgvLocalDrivLicApp_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void sechduleTestToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void labelCountRecord_Click(object sender, EventArgs e) { }
        #endregion

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationInfo DrivLicAppInfo = new LocalDrivingLicenseApplicationInfo((int)DgvLocalDrivLicApp.CurrentRow.Cells[0].Value);
            DrivLicAppInfo.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }
    }
}
