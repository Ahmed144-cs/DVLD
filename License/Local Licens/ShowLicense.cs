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
    public partial class ShowLicense : Form
    {
        public ShowLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }


        private int _LicenseID;

        private void ShowLicense_Load(object sender, EventArgs e)
        {
            this.driverLicenseInfo1.LoadInfo(_LicenseID);
        }

        private void driverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
