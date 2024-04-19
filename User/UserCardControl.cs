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
    public partial class UserCardControl : UserControl
    {
        public UserCardControl()
        {
            InitializeComponent();
        }

        private UserLogic _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public void LoadUserInfo(int UserID)
        {
            _User = UserLogic.FindUser(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            this.personInfoUC1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();

            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }

        private void _ResetPersonInfo()
        {

            this.personInfoUC1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

        #region
        private void UserCardControl_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
