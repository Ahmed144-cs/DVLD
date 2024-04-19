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
    public partial class EditTestTypes : Form
    {
        public EditTestTypes(ManageTestTypeLogic.enTestType testTypeId)
        {
            InitializeComponent();
            _TestTypeId = testTypeId;    
        }

        private ManageTestTypeLogic.enTestType _TestTypeId = ManageTestTypeLogic.enTestType.VisionTest;
        private ManageTestTypeLogic _TestTypeLogicInfo;

        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            LTestTypeID.Text = _TestTypeId.ToString();
            _TestTypeLogicInfo = ManageTestTypeLogic.Find(_TestTypeId);

            if(_TestTypeLogicInfo != null)
            {
                TbTitleTestType.Text = _TestTypeLogicInfo.Title;
                TbPriceTestType.Text = _TestTypeLogicInfo.Fees.ToString();
            }
            else
            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeId.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to Edit this Test Type", "Update Test Type", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            _TestTypeLogicInfo.Title = TbTitleTestType.Text;
            _TestTypeLogicInfo.Fees = Convert.ToSingle(TbPriceTestType.Text);

            if (_TestTypeLogicInfo.UpdateTestTypes())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbPriceTestType_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }

        #region
        private void LTestTypeID_Click(object sender, EventArgs e)
        {

        }

        private void TbTitleTestType_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPriceTestType_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void TbTitleTestType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbTitleTestType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbTitleTestType, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(TbTitleTestType, null);
            };
        }

        private void TbPriceTestType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPriceTestType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbPriceTestType, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(TbPriceTestType, null);
            };
        }
    }
}
