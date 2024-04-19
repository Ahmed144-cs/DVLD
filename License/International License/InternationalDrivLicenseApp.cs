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
    public partial class InternationalDrivLicenseApp : Form
    {
        public InternationalDrivLicenseApp()
        {
            InitializeComponent();
        }

        private DataTable _InternationalDrivLicense;


        private void InternationalDrivLicenseApp_Load(object sender, EventArgs e)
        {
            _InternationalDrivLicense = InternationalLicenseLogic.GetAllInternationalLicenses();

            DgvIntDrivLicApp.DataSource = _InternationalDrivLicense;
            labelCountRecord.Text = DgvIntDrivLicApp.RowCount.ToString();

            CbFiltorBy.SelectedIndex = 0;

            if (DgvIntDrivLicApp.Rows.Count == 0)
                return;

            DgvIntDrivLicApp.Columns[0].HeaderText = "Int.License ID";

            DgvIntDrivLicApp.Columns[1].HeaderText = "Application ID";

            DgvIntDrivLicApp.Columns[2].HeaderText = "Driver ID";

            DgvIntDrivLicApp.Columns[3].HeaderText = "L.License ID";

            DgvIntDrivLicApp.Columns[4].HeaderText = "Issue Date";

            DgvIntDrivLicApp.Columns[5].HeaderText = "Expiration Date";

            DgvIntDrivLicApp.Columns[6].HeaderText = "Is Active";
        }

        private void CbFiltorBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFiltorBy.Text == "Is Active")
            {
                TbFiltorInput.Visible = false;
                CbIsReleased.Visible = true;
                CbIsReleased.Focus();
                CbIsReleased.SelectedIndex = 0;
            }
            else if(CbFiltorBy.Text != "None")
            {
                CbIsReleased.Visible = false;
                TbFiltorInput.Visible = true;
                TbFiltorInput.Focus();
                TbFiltorInput.Text = "";
            }
            else
            {
                CbIsReleased.Visible = false;
                TbFiltorInput.Visible = false;
            }
        }

        private void TbFiltorInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFiltorBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;

                case "Application ID":
                    FilterColumn = "ApplicationsID";
                    break;

                case "Driver ID":
                    FilterColumn = "DriversID";
                    break;

                case "Local License ID":
                    FilterColumn = "LocalLicensesID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbFiltorInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _InternationalDrivLicense.DefaultView.RowFilter = "";
                labelCountRecord.Text = DgvIntDrivLicApp.Rows.Count.ToString();
                return;
            }

            _InternationalDrivLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TbFiltorInput.Text.Trim());

            labelCountRecord.Text = _InternationalDrivLicense.Rows.Count.ToString();

        }

        private void TbFiltorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = CbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;

                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _InternationalDrivLicense.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _InternationalDrivLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", FilterValue);

            labelCountRecord.Text = _InternationalDrivLicense.Rows.Count.ToString();
        }

        #region
        private void DgvIntDrivLicApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void labelCountRecord_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory licHistory = new LicenseHistory(DriverLogic.FindByDriverID((int)DgvIntDrivLicApp.CurrentRow.Cells[2].Value).PersonID);
            licHistory.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails licDetails = new InternationalLicenseDetails((int)DgvIntDrivLicApp.CurrentRow.Cells[0].Value);
            licDetails.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoDetails personInfo = new PersoDetails(DriverLogic.FindByDriverID((int)DgvIntDrivLicApp.CurrentRow.Cells[2].Value).PersonID);
            personInfo.ShowDialog();
        }

        private void BtnCloas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApp internationalLicense = new NewInternationalLicenseApp();
            internationalLicense.ShowDialog();

            InternationalDrivLicenseApp_Load(null, null);
        }

  
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (DgvIntDrivLicApp.Rows.Count == 0);
        }    
    }
}
