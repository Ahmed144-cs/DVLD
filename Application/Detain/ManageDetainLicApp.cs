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
    public partial class ManageDetainLicApp : Form
    {
        public ManageDetainLicApp()
        {
            InitializeComponent();
        }

        DataTable _dtDetainedLicenses;

        private void ManageDetainLicApp_Load(object sender, EventArgs e)
        {

            _dtDetainedLicenses = DetainLicenseLogic.GetAllDetainedLicenses();

            DgvDetainLicApp.DataSource = _dtDetainedLicenses;
            labelCountRecord.Text = DgvDetainLicApp.Rows.Count.ToString();

            CbFiltorBy.SelectedIndex = 0;

            if (DgvDetainLicApp.Rows.Count == 0)
                return;

            DgvDetainLicApp.Columns[0].HeaderText = "D.ID";
            DgvDetainLicApp.Columns[1].HeaderText = "L.ID";
            DgvDetainLicApp.Columns[2].HeaderText = "D.Date";
            DgvDetainLicApp.Columns[3].HeaderText = "Is Released";
            DgvDetainLicApp.Columns[4].HeaderText = "Fine Fees";
            DgvDetainLicApp.Columns[5].HeaderText = "Release Date";
            DgvDetainLicApp.Columns[6].HeaderText = "N.No.";
            DgvDetainLicApp.Columns[7].HeaderText = "Full Name";
            DgvDetainLicApp.Columns[8].HeaderText = "Rlease App.ID";
        }

        private void TbFiltorInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFiltorBy.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;

                case "Is Released":
                        FilterColumn = "IsReleased";
                    break;      

                case "National No.":
                    FilterColumn = "NationalOn";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbFiltorInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                labelCountRecord.Text = DgvDetainLicApp.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TbFiltorInput.Text.Trim());
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TbFiltorInput.Text.Trim());

            labelCountRecord.Text = _dtDetainedLicenses.Rows.Count.ToString();
        }

        private void TbFiltorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFiltorBy.Text == "Detain ID" || CbFiltorBy.Text == "Release Application ID")
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
                _dtDetainedLicenses.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsReleased", FilterValue);

            labelCountRecord.Text = _dtDetainedLicenses.Rows.Count.ToString();
        }


        private void BtnCloas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbFiltorBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFiltorBy.Text == "Is Released")
            {
                TbFiltorInput.Visible = false;
                CbIsReleased.SelectedIndex = 0;
                CbIsReleased.Visible = true;
                CbIsReleased.Focus();
            }
            else if(CbFiltorBy.Text != "None")
            {
                CbIsReleased.Visible = false;
                TbFiltorInput.Text = "";
                TbFiltorInput.Visible = true;
                TbFiltorInput.Focus();
            }
            else
            {
                CbIsReleased.Visible = false;
                TbFiltorInput.Text = "";
                CbIsReleased.SelectedIndex = 0;
                CbIsReleased.Visible = false;             
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoDetails frm = new PersoDetails(PersonLogic.Find((string)DgvDetainLicApp.CurrentRow.Cells[6].Value).PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicense licInfo = new ShowLicense(LicenseLogic.Find((int)DgvDetainLicApp.CurrentRow.Cells[1].Value).LicenseID);
            licInfo.ShowDialog();
        }

        private void showPersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(PersonLogic.Find((string)DgvDetainLicApp.CurrentRow.Cells[6].Value).PersonID); 
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (DgvDetainLicApp.RowCount == 0)
                return;

            releaseDetainedLicenseToolStripMenuItem.Enabled = (!(bool)DgvDetainLicApp.CurrentRow.Cells["IsReleased"].Value);
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseApplication releaseLicenses = new ReleaseDetainedLicenseApplication((int)DgvDetainLicApp.CurrentRow.Cells[1].Value);
            releaseLicenses.ShowDialog();

            ManageDetainLicApp_Load(null, null);
        }

        private void PbReleaseLic_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseApplication releaseLicenses = new ReleaseDetainedLicenseApplication();
            releaseLicenses.ShowDialog();

            ManageDetainLicApp_Load(null, null);
        }

        private void PbDetainLic_Click(object sender, EventArgs e)
        {
            DetainLicenseApplication detainLicenses = new DetainLicenseApplication();
            detainLicenses.ShowDialog();

            ManageDetainLicApp_Load(null, null);
        }
    }
}
