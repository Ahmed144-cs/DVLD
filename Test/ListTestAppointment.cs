using DVLD.Properties;
using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ListTestAppointment : Form
    {
        public ListTestAppointment(int locDrvLicId, ManageTestTypeLogic.enTestType testType)
        {
            InitializeComponent();

            _LocalDrivLicAppID = locDrvLicId;
            _TestType = testType;
        }

        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivLicAppID;
        private ManageTestTypeLogic.enTestType _TestType = ManageTestTypeLogic.enTestType.VisionTest;

        private void ListTestAppointment_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            this.ctrlDrivLicAppInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivLicAppID);

            _dtLicenseTestAppointments = TestAppointmentLogic.GetAppTestAppointmentsPerTestType(
                                                                _LocalDrivLicAppID, _TestType);

            DgvAppointmentTest.DataSource = _dtLicenseTestAppointments;
            labelCountRecord.Text = DgvAppointmentTest.Rows.Count.ToString();

            if (DgvAppointmentTest.Rows.Count == 0)
                return;

            DgvAppointmentTest.Columns[0].HeaderText = "Appointment ID";
            DgvAppointmentTest.Columns[1].HeaderText = "Appointment Date";
            DgvAppointmentTest.Columns[2].HeaderText = "Paid Fees";
            DgvAppointmentTest.Columns[3].HeaderText = "Is Locked";
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case ManageTestTypeLogic.enTestType.VisionTest:
                    {
                        LabFormText.Text = "Vision Test Appointments";
                        this.Text = LabFormText.Text;
                        break;
                    }

                case ManageTestTypeLogic.enTestType.WrittenTest:
                    {
                        LabFormText.Text = "Written Test Appointments";
                        this.Text = LabFormText.Text;
                        break;
                    }

                case ManageTestTypeLogic.enTestType.StreetTest:
                    {
                        LabFormText.Text = "Street Test Appointments";
                        this.Text = LabFormText.Text;
                        break;
                    }
            }
        }



        private void PbAddSechdule_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationLogic localDrivingLicenseApplication = LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(_LocalDrivLicAppID);

            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //---
            TestsResultLogic LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                FrmScheduleTest frm1 = new FrmScheduleTest(_LocalDrivLicAppID, _TestType);
                frm1.ShowDialog();

                ListTestAppointment_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmScheduleTest frm2 = new FrmScheduleTest(
                                LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            ListTestAppointment_Load(null, null);
            //---
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleTest frm = new FrmScheduleTest(_LocalDrivLicAppID, _TestType, (int)DgvAppointmentTest.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            ListTestAppointment_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrnTakeTest takeTest = new FrnTakeTest((int)DgvAppointmentTest.CurrentRow.Cells[0].Value, _TestType);
            takeTest.ShowDialog();

            ListTestAppointment_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(DgvAppointmentTest.RowCount == 0)
            {
                contextMenuStrip1.Items["editToolStripMenuItem"].Enabled = false;
                contextMenuStrip1.Items["takeTestToolStripMenuItem"].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items["editToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["takeTestToolStripMenuItem"].Enabled = true;
            }

            int result = 0;// VisionTestLogic.IsLocked((int)DgvVisionTest.CurrentRow.Cells[0].Value);

            if (result == -1 || result == 1)
            {
                contextMenuStrip1.Items["editToolStripMenuItem"].Enabled = false;
                contextMenuStrip1.Items["takeTestToolStripMenuItem"].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items["editToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["takeTestToolStripMenuItem"].Enabled = true;
            }
        }

        #region
        private void drivingLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }
        private void licenseAppBasicInfo1_Load(object sender, EventArgs e)
        {

        }
        private void DgvVisionTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
