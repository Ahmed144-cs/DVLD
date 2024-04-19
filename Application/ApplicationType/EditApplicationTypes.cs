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
    public partial class EditApplicationTypes : Form
    {
        public EditApplicationTypes(int AppTypeId)
        {
            InitializeComponent();
            _AppTypeId = AppTypeId;
        }

        private int _AppTypeId;
        private ManageAppTypesLogic _ApplictionType;

        private void EditApplicationTypes_Load(object sender, EventArgs e)
        {
            LAppTypeID.Text = _AppTypeId.ToString();
            _ApplictionType = ManageAppTypesLogic.Find(_AppTypeId);

            if(_ApplictionType != null)
            {
                TbTitleAppType.Text = _ApplictionType.Title;
                TbPriceAppType.Text = _ApplictionType.Fees.ToString();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to Edit this Application Type", "Update Application Type", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            _ApplictionType.Title= TbTitleAppType.Text;
            _ApplictionType.Fees = Convert.ToSingle(TbPriceAppType.Text.Trim());

            if (_ApplictionType.UpdateAppTypes())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TbPriceAppType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));       
        }

        private void TbTitleAppType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbTitleAppType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbTitleAppType, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(TbTitleAppType, null);
            };
        }

        private void TbPriceAppType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPriceAppType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbPriceAppType, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(TbPriceAppType, null);
            };
        }

        #region
        private void LAppTypeID_Click(object sender, EventArgs e)
        {

        }

        private void TbTitleAppType_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPriceAppType_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
