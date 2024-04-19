using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddUbdateUser : Form
    {
        public AddUbdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public AddUbdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        UserLogic _User;

        private void AddUbdateUser_Load(object sender, EventArgs e)
        {
            TbConfrmPass.PasswordChar = '*';
            TbConfrmPass.MaxLength = 20;
            TbPassword.PasswordChar = '*';
            TbPassword.MaxLength = 20;
            TbUserName.MaxLength = 20;

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                //this.Text = "Add New User";
                _User = new UserLogic();

                TabEnterUser.Enabled = false;

                this.filterPerson1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                //this.Text = "Update User";

                TabEnterUser.Enabled = true;
                BtnSave.Enabled = true;
            }

            TbUserName.Text = "";
            TbPassword.Text = "";
            TbConfrmPass.Text = "";
            CbIsActive.Checked = true;
        }

        private void _LoadData()
        {
            _User = UserLogic.FindUser(_UserID);
            this.filterPerson1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            labelUserID.Text = _User.UserID.ToString();
            TbUserName.Text = _User.UserName;
            TbPassword.Text = _User.Password;
            TbConfrmPass.Text = _User.Password;
            CbIsActive.Checked = _User.IsActive;
            this.filterPerson1.LoadPersonInfo(_User.PersonID);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                BtnSave.Enabled = true;
                TabEnterUser.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["TabEnterUser"];
                return;
            }
            //incase of add new mode.
            if (this.filterPerson1.PersonID != -1)
            {
                if (UserLogic.IsUserExistForPersonID(this.filterPerson1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.filterPerson1.FilterFocus();
                }
                else
                {
                    BtnSave.Enabled = true;
                    TabEnterUser.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["TabEnterUser"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.filterPerson1.FilterFocus();
            }
        }
 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = this.filterPerson1.PersonID;
            _User.UserName = TbUserName.Text.Trim();
            _User.Password = TbPassword.Text.Trim();
            _User.IsActive = CbIsActive.Checked;

            if (_User.Save())
            {
                labelUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                //this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }  

        private void TbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(TbPassword, null);
            };
        }

        private void TbConfrmPass_Validating(object sender, CancelEventArgs e)
        {
            if (TbConfrmPass.Text.Trim() != TbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TbConfrmPass, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(TbConfrmPass, null);
            };
        }

        private void TbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(TbUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (UserLogic.IsUserExist(TbUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TbUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(TbUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != TbUserName.Text.Trim())
                {
                    if (UserLogic.IsUserExist(TbUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(TbUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(TbUserName, null);
                    };
                }
            }
        }

        #region
        private void TbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbConfrmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelUserID_Click(object sender, EventArgs e)
        {

        }
        private void tabPageUser_Click(object sender, EventArgs e)
        {

        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void filterPerson1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
