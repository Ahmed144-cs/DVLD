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
    public partial class FrmScheduleTest : Form
    {
        public FrmScheduleTest(int localDrivLicAppID, ManageTestTypeLogic.enTestType testType, int appointmentID = -1)
        {
            InitializeComponent();

            _LocalDrivLicAppID = localDrivLicAppID;
            _TestTypeID = testType;
            _AppointmentID = appointmentID;
        }

        private int _LocalDrivLicAppID;
        private ManageTestTypeLogic.enTestType _TestTypeID = ManageTestTypeLogic.enTestType.VisionTest;
        private int _AppointmentID = -1;

        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            this.ctrlScheduleTest1.TestTypeID = _TestTypeID;
            this.ctrlScheduleTest1.LoadInfo(_LocalDrivLicAppID, _AppointmentID);
        }
    }
}
