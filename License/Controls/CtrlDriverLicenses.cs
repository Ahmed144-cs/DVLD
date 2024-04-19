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
    public partial class CtrlDriverLicenses : UserControl
    {
        public CtrlDriverLicenses()
        {
            InitializeComponent();
        }

        int _DriverID;

        private DriverLogic _Driver;

        private DataTable _DtDriverLocalLicensesHistory;
        private DataTable _DtDriverInternationalLicensesHistory;

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = DriverLogic.FindByDriverID(DriverID);

            _LoadLocalLicenseInfo();
            _LoadInterLicenseInfo();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = DriverLogic.FindByPersonID(PersonID);
            if (_Driver != null)
            {
                _DriverID = DriverLogic.FindByPersonID(PersonID).DriverID;
            }

            _LoadLocalLicenseInfo();
            _LoadInterLicenseInfo();
        }

        private void _LoadLocalLicenseInfo()
        {
            _DtDriverLocalLicensesHistory = DriverLogic.GetLicenses(_DriverID);

            DgvLocalLicenses.DataSource = _DtDriverLocalLicensesHistory;
            LabLocLicRecords.Text = DgvLocalLicenses.Rows.Count.ToString();

            if (DgvLocalLicenses.Rows.Count == 0)
                return;

            DgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";

            DgvLocalLicenses.Columns[1].HeaderText = "App.ID";

            DgvLocalLicenses.Columns[2].HeaderText = "Class Name";

            DgvLocalLicenses.Columns[3].HeaderText = "Issue Date";

            DgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";

            DgvLocalLicenses.Columns[5].HeaderText = "Is Active";
        }

        private void _LoadInterLicenseInfo()
        {
            _DtDriverInternationalLicensesHistory = DriverLogic.GetInternationalLicenses(_DriverID);

            DgvInternationalLic.DataSource = _DtDriverInternationalLicensesHistory;
            LabInterRecords.Text = DgvInternationalLic.Rows.Count.ToString();

            if (DgvInternationalLic.Rows.Count == 0)
                return;

            DgvInternationalLic.Columns[0].HeaderText = "Int.License ID";

            DgvInternationalLic.Columns[1].HeaderText = "Application ID";

            DgvInternationalLic.Columns[2].HeaderText = "Driver ID";

            DgvInternationalLic.Columns[3].HeaderText = "L.License ID";

            DgvInternationalLic.Columns[4].HeaderText = "Issue Date";

            DgvInternationalLic.Columns[5].HeaderText = "Expiration Date";

            DgvInternationalLic.Columns[6].HeaderText = "Is Active";
        }

        private void GbDriverLicense_Enter(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            _DtDriverLocalLicensesHistory.Clear();
            _DtDriverInternationalLicensesHistory.Clear();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicense frm = new ShowLicense((int)DgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails frm = new InternationalLicenseDetails((int)DgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
