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
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();
        }

        DataTable _DriversData;

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            _DriversData = DriverLogic.GetAllDrivers();

            DgvDriversTest.DataSource = _DriversData;

            labelCountRecord.Text = DgvDriversTest.Rows.Count.ToString();

            CbFiltorBy.SelectedItem = "None";

            if (DgvDriversTest.Rows.Count <= 0)
                return;

            DgvDriversTest.Columns[0].HeaderText = "Driver ID";
            DgvDriversTest.Columns[1].HeaderText = "Person ID";
            DgvDriversTest.Columns[2].HeaderText = "National No.";
            DgvDriversTest.Columns[3].HeaderText = "Full Name";
            DgvDriversTest.Columns[4].HeaderText = "Date";
            DgvDriversTest.Columns[5].HeaderText = "Active Licenses";
        }


        #region
        private void DgvDriversTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void labelCountRecord_Click(object sender, EventArgs e)
        {
        }
        #endregion


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbFiltorBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbFiltorInput.Visible = (CbFiltorBy.Text != "None");

            if(TbFiltorInput.Visible)
            {
                TbFiltorInput.Text = "";
                TbFiltorInput.Focus();
            }
        }

        private void TbFiltorInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFiltorBy.Text)
            {
                case "Drivers ID":
                    FilterColumn = "DriversID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalOn";
                    break;


                case "Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbFiltorInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _DriversData.DefaultView.RowFilter = "";
                labelCountRecord.Text = DgvDriversTest.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalOn")
                //in this case we deal with numbers not string.
                _DriversData.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TbFiltorInput.Text.Trim());
            else
                _DriversData.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TbFiltorInput.Text.Trim());

            labelCountRecord.Text = DgvDriversTest.Rows.Count.ToString();
        }

        private void TbFiltorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFiltorBy.Text == "Drivers ID" || CbFiltorBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoDetails personInfo = new PersoDetails((int)DgvDriversTest.CurrentRow.Cells[1].Value);
            personInfo.ShowDialog();

            ManageDrivers_Load(null, null);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory((int)DgvDriversTest.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
