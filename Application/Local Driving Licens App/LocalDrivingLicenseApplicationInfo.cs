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
    public partial class LocalDrivingLicenseApplicationInfo : Form
    {
        public LocalDrivingLicenseApplicationInfo(int DrivingLicAppID)
        {
            InitializeComponent();

            _LocalDrivingLicAppID = DrivingLicAppID;
        }

        private int _LocalDrivingLicAppID = -1;

        private void LocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            this.ctrlDrivLicAppInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicAppID);
        }

        private void BtnCloas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
