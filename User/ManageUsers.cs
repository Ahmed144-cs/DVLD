using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private static DataTable _AllUsers;

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _LoadUsers();
            CbFilterBy.SelectedIndex = 0;

            if (DgvUsers.RowCount == 0)
                return;

            DgvUsers.Columns[0].HeaderText = "User ID";
            DgvUsers.Columns[1].HeaderText = "Person ID";
            DgvUsers.Columns[2].HeaderText = "Full Name";
            DgvUsers.Columns[3].HeaderText = "UserName";
            DgvUsers.Columns[4].HeaderText = "Is Active";
        }

        private void _LoadUsers()
        {
            _AllUsers = UserLogic.GetUserDataFromLogicAccess();
            DgvUsers.DataSource = _AllUsers;

            labelRecordsCount.Text = DgvUsers.RowCount.ToString();
        }

        #region
        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void labelRecordsCount_Click(object sender, EventArgs e)
        {

        }
       
        #endregion

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFilterBy.Text == "is Active")
            {
                TbSearchInput.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
                cbIsActive.Focus();
            }
            else
            {
                TbSearchInput.Visible = (CbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (TbSearchInput.Visible)
                {
                    TbSearchInput.Text = "";
                    TbSearchInput.Focus();
                }
            }
        }

        private void TbSearchInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text == "Person ID" || CbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbSearchInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TbSearchInput.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllUsers.DefaultView.RowFilter = "";
                labelRecordsCount.Text = DgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TbSearchInput.Text.Trim());
            else
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TbSearchInput.Text.Trim());

            labelRecordsCount.Text = DgvUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "isActive";
            string FilterValue = cbIsActive.Text;

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
                _AllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            labelRecordsCount.Text = DgvUsers.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editUser = new AddUbdateUser((int)DgvUsers.CurrentRow.Cells[0].Value);
            editUser.ShowDialog();

            _LoadUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            if (UserLogic.DeleteUser((int)DgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageUsers_Load(null, null);
            }
            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddUser = new AddUbdateUser();
            AddUser.ShowDialog();

            ManageUsers_Load(null, null);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form changPassword = new ChangUserPassword((int)DgvUsers.CurrentRow.Cells[0].Value);
            changPassword.ShowDialog();

            ManageUsers_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo((int)DgvUsers.CurrentRow.Cells[0].Value);
            userInfo.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (DgvUsers.RowCount == 0) ? true : false;        
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbAddUsers_Click(object sender, EventArgs e)
        {
            Form AddUser = new AddUbdateUser();
            AddUser.ShowDialog();

            _LoadUsers();
        }
    }
}
