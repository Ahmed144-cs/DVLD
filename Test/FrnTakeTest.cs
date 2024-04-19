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
    public partial class FrnTakeTest : Form
    {
        public FrnTakeTest(int testAppointmentID, ManageTestTypeLogic.enTestType testType)
        {
            InitializeComponent();

            _TestAppointmentID = testAppointmentID;
            _TestType = testType;
        }

        private int _TestAppointmentID;

        private ManageTestTypeLogic.enTestType _TestType;

        private TestsResultLogic _TestsResultInfo;

        private void FrnTakeTest_Load(object sender, EventArgs e)
        {
            TbResultNoat.MaxLength = 100;
            RbPass.Checked = true;

            this.ctrlSecheduledTestResult1.TestTypeID = _TestType;
            this.ctrlSecheduledTestResult1.LoadInfo(_TestAppointmentID);


            if (this.ctrlSecheduledTestResult1.TestAppointmentID == -1)
                BtnSave.Enabled = false;
            else
                BtnSave.Enabled = true;

            // to update just the note if the result was taken

            int _TestID = this.ctrlSecheduledTestResult1.TestID;

            if (_TestID != -1)
            {
                _TestsResultInfo = TestsResultLogic.Find(_TestID);

                if (_TestsResultInfo.TestResult)
                    RbPass.Checked = true;
                else
                    RbFail.Checked = true;

                TbResultNoat.Text = _TestsResultInfo.Notes;

                RbFail.Enabled = false;
                RbPass.Enabled = false;
            }
            else
                _TestsResultInfo = new TestsResultLogic();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            _TestsResultInfo.TestAppointmentID = _TestAppointmentID;
            _TestsResultInfo.TestResult = RbPass.Checked;
            _TestsResultInfo.Notes = TbResultNoat.Text.Trim();
            _TestsResultInfo.CreatedByUserID = clsGlobal.CurrUser.UserID;

            if (_TestsResultInfo.Save())
            {
                BtnSave.Enabled = false;
                RbFail.Enabled = false;
                RbPass.Enabled = false;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        private void RbPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbFail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TbResultNoat_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion  
    }
}
