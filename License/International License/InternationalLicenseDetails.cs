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
    public partial class InternationalLicenseDetails : Form
    {
        public InternationalLicenseDetails(int internationalLicInfo)
        {
            InitializeComponent();
            _internationalLicInfo = internationalLicInfo;
        }

        private int _internationalLicInfo;

        private void InternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            this.ctrlInternationalLicenseInfo1.LoadInfo(_internationalLicInfo);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
