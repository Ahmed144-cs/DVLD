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
    public partial class UserInfo : Form
    {
        public UserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private int _UserID;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            this.userCardControl1.LoadUserInfo(_UserID);
        }
    }
}
