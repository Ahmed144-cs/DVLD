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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD
{
    public partial class LoginScrean : Form
    {
        public LoginScrean()
        {
            InitializeComponent();

            TbPassword.PasswordChar = '*';
            TbPassword.MaxLength = 64;
            TbUserName.MaxLength = 20;

            ErrorHandlingLogic.SubscribeToErrors(clsErrorLogger.HandleError);
        }

        private void LoginScrean_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                TbUserName.Text = UserName;
                TbPassword.Text = Password;
                CbRememberMe.Checked = true;
            }
            else
            {
                CbRememberMe.Checked = false;
                TbUserName.Clear();
                TbPassword.Clear();
            }
        }
     
        #region

        private void lFormText_Click(object sender, EventArgs e)
        {

        }

        private void TbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (_SerError())
                return;

            UserLogic user = UserLogic.FindByUsernameAndPassword(TbUserName.Text.Trim(), (TbPassword.Text.Trim().Length != 64) ? clsFormat.ComputeHash(TbPassword.Text.Trim()) : TbPassword.Text.Trim());

            if (user != null)
            {
                if (!user.IsActive)
                {
                    MessageBox.Show("This user is inactive", "User Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(CbRememberMe.Checked)
                {
                    if(!clsGlobal.SaveDataToRememberMeRegistry(TbUserName.Text.Trim(), clsFormat.ComputeHash(TbPassword.Text.Trim())))
                    {
                        MessageBox.Show("Connection failed", "Error: Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    clsGlobal.SaveDataToRememberMeRegistry("","");
                }

                clsGlobal.CurrUser = user;
                Form1 openProject = new Form1();
                openProject.ShowDialog();

                LoginScrean_Load(null, null);
            }
            else
            {
                TbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _SerError()
        {
            if(TbUserName.Text.Trim() == "")
            {
                errorProvider1.SetError(TbUserName, "Full the User name field");
                return true;
            }

            if (TbPassword.Text.Trim() == "")
            {
                errorProvider1.SetError(TbPassword, "Full the User name field");
                return true;
            }

            return false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
