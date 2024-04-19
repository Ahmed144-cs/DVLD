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
    public partial class PersoDetails : Form
    {
        public PersoDetails(int personID)
        {
            InitializeComponent();
            this.personInfoUC1.LoadPersonInfo(personID);
        }

        public PersoDetails(string NationalNo)
        {
            InitializeComponent();
            this.personInfoUC1.LoadPersonInfo(NationalNo);
        }       

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        private void personInfoUC1_Load_1(object sender, EventArgs e)
        {
        }
        private void PersoDetailscs_Load(object sender, EventArgs e)
        {
        }
        public void personInfoUC1_Load(object sender, EventArgs e)
        {
        }
        #endregion
    }
}

    

