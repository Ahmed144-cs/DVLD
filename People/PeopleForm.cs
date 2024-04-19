using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class PeopleForm : Form
    {

        private static DataTable _dtAllPeople;

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            _getPeopleDataFromLogicAccess();

            CbFiltorBy.SelectedItem = "None";
            TbFiltorInput.MaxLength = 70;

            if (DgvPeople.Rows.Count > 0)
            {
                DgvPeople.Columns[0].HeaderText = "Person ID";
                DgvPeople.Columns[1].HeaderText = "National No.";
                DgvPeople.Columns[2].HeaderText = "First Name";
                DgvPeople.Columns[3].HeaderText = "Second Name";
                DgvPeople.Columns[4].HeaderText = "Third Name";
                DgvPeople.Columns[5].HeaderText = "Last Name";
                DgvPeople.Columns[6].HeaderText = "Gendor";
                DgvPeople.Columns[7].HeaderText = "Date Of Birth";
                DgvPeople.Columns[8].HeaderText = "Nationality";
                DgvPeople.Columns[9].HeaderText = "Phone";
                DgvPeople.Columns[10].HeaderText = "Email";
            }
        }

        private void _getPeopleDataFromLogicAccess()
        {
            _dtAllPeople = PersonLogic.GetPeopleDataFromDataAccess();

            if (_dtAllPeople.Rows.Count > 0)
            {
                _dtAllPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalOn",
                                        "FirstName", "SecondName", "ThirdName", "LastName",
                                        "GendorCaption", "DateOfBirth", "CountryName",
                                        "Phone", "Email");
                DgvPeople.DataSource = _dtAllPeople;
            }
            else
            {
                DgvPeople.DataSource = null;
            }

            _QueryRowCount();
        }

        private void CbFiltorBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbFiltorInput.Visible = (CbFiltorBy.Text != "None");
            if (TbFiltorInput.Visible)
            {
                TbFiltorInput.Text = "";
                TbFiltorInput.Focus();
            }                
        }
        private void PbAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showPerson = new PersoDetails((int)DgvPeople.CurrentRow.Cells[0].Value);
            showPerson.ShowDialog();

            _getPeopleDataFromLogicAccess();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void AddPerson()
        {
            Form addPerson = new AddUpdatePerson();
            addPerson.ShowDialog();
            _getPeopleDataFromLogicAccess();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + 
                DgvPeople.CurrentRow.Cells[0].Value + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            if (PersonLogic.DeletePerson((int)DgvPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _getPeopleDataFromLogicAccess();
            }
            else
                MessageBox.Show("Person was not deleted because it has data linked to it.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCloas_Click(object sender, EventArgs e)
        {
            this.Close();    
        }   

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Edit this record", "Editing",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form editPerson = new AddUpdatePerson((int)DgvPeople.CurrentRow.Cells[0].Value);
                editPerson.ShowDialog();

                _getPeopleDataFromLogicAccess();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (DgvPeople.RowCount == 0) ? true : false;
        }
                   
        private void _QueryRowCount()
        {
            labelCountRecord.Text = DgvPeople.RowCount.ToString();
        }

        #region
        private void DgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TbFiltorInput_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void labelCountRecord_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void TbFiltorInput_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFiltorBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalOn";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbFiltorInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                labelCountRecord.Text = DgvPeople.Rows.Count.ToString();
                return;
            }

            if (_dtAllPeople.Rows.Count == 0)
                return; // to prevant exseption error

            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", 
                                            FilterColumn, TbFiltorInput.Text.Trim());
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",
                                             FilterColumn, TbFiltorInput.Text.Trim());

            labelCountRecord.Text = DgvPeople.Rows.Count.ToString();
        }

        private void TbFiltorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFiltorBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
