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
    public partial class ChangUserPassword : Form
    {
        public ChangUserPassword(int userId)
        {
            InitializeComponent();

            _UserId = userId; 
        }

        private int _UserId;
        private UserLogic _User;

        private void ChangUserPassword_Load(object sender, EventArgs e)
        {
            TbCurrentPassword.PasswordChar = '*';
            TbPassword.PasswordChar = '*';
            TbConfrmPass.PasswordChar = '*';

            TbCurrentPassword.MaxLength = 20;
            TbPassword.MaxLength = 20;
            TbConfrmPass.MaxLength = 20;

            _ResetDefualtValues();

            _User = UserLogic.FindUser(_UserId);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserId,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            this.userCardControl1.LoadUserInfo(_UserId);
        }

        private void _ResetDefualtValues()
        {
            TbCurrentPassword.Text = "";
            TbPassword.Text = "";
            TbConfrmPass.Text = "";
            TbCurrentPassword.Focus();
        }

        #region
        private void TbCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbConfrmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {

        }

        private void loginInfo1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = TbPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbCurrentPassword, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(TbCurrentPassword, null);
            };

            if (_User.Password != TbCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TbCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(TbCurrentPassword, null);
            };
        }

        private void TbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbPassword, "New Password cannot be blank");
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
                errorProvider1.SetError(TbConfrmPass, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(TbConfrmPass, null);
            };
        }
    }
}
