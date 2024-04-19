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
using static DVLD_LogicAccess.ManageTestTypeLogic;

namespace DVLD
{
    public partial class ctrlSecheduledTestResult : UserControl
    {
        public ctrlSecheduledTestResult()
        {
            InitializeComponent();
        }


        private ManageTestTypeLogic.enTestType _TestTypeID;

        private LocalDrivingLicenseApplicationLogic _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;

        private int _TestAppointmentID = -1;
        private TestAppointmentLogic _TestAppointment;

        private int _TestID = -1;

        public ManageTestTypeLogic.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case ManageTestTypeLogic.enTestType.VisionTest:
                        {
                            GbTestType.Text = "Vision Test";
                            break;
                        }

                    case ManageTestTypeLogic.enTestType.WrittenTest:
                        {
                            GbTestType.Text = "Written Test";
                            break;
                        }

                    case ManageTestTypeLogic.enTestType.StreetTest:
                        {
                            GbTestType.Text = "Street Test";
                            break;
                        }
                }
            }
        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;

            _TestAppointment = TestAppointmentLogic.Find(_TestAppointmentID);

            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplicationLogic.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labLocalDrivLicAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            labDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            labFullName.Text = _LocalDrivingLicenseApplication.PersonFullName;


            //this will show the trials for this test before 
            labTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();

            labDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            labFees.Text = _TestAppointment.PaidFees.ToString();
            labTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();
        }

        private void ctrlSecheduledTestResult_Load(object sender, EventArgs e)
        {

        }

        #region
        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
