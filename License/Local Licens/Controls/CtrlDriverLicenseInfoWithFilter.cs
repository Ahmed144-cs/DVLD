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
    public partial class CtrlDriverLicenseInfoWithFilter : UserControl
    {
        public CtrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            OnLicenseSelected?.Invoke(LicenseID); // Raise the event with the parameter
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                GbFilters.Enabled = _FilterEnabled;
            }
        }

        public int LicenseID
        {
            get { return this.driverLicenseInfo1.LicenseID; }
        }

        public LicenseLogic SelectedLicenseInfo
        {
            get { return this.driverLicenseInfo1.SelectedLicenseInfo; }
        }


        private int _LicenseID = -1;

        private void TbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                BtnSearch.PerformClick();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbLicenseID.Focus();
                return;

            }
            _LicenseID = int.Parse(TbLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            TbLicenseID.Text = LicenseID.ToString();
            this.driverLicenseInfo1.LoadInfo(LicenseID);

            _LicenseID = this.driverLicenseInfo1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);
        }

        private void TbLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbLicenseID, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(TbLicenseID, null);
            }
        }

        public void TbFocus()
        {
            TbLicenseID.Focus();
        }

        private void CtrlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void TbLicenseID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
