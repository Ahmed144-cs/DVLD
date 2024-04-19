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
    public partial class LicenseHistory : Form
    {
        public LicenseHistory(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            this.filterPerson1.OnPersonSelected += OnPersonSelected;
        }

        int _PersonID;

        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                this.ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
                this.filterPerson1.LoadPersonInfo(_PersonID);
                this.filterPerson1.FilterEnabled = false;
            }
            else
            {
                this.filterPerson1.Enabled = true;
                this.filterPerson1.FilterFocus();
            }
        }

        private void OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
