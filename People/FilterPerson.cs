using System;
using DVLD_LogicAccess;
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
    public partial class FilterPerson : UserControl
    {
        public FilterPerson()
        {
            InitializeComponent();
        }

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        //to Visible the butten from out the this form
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                PbAdd.Visible = _ShowAddPerson;
            }
        }

        //to Enabled the filter from out the this form
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
                GbFilter.Enabled = _FilterEnabled;
            }
        }

        //get person id from the personInfo user control
        public int PersonID
        {
            get { return this.personInfoUC1.PersonID; }
        }

        //get person class from the personInfo user control
        public PersonLogic SelectedPersonInfo
        {
            get { return this.personInfoUC1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            CbSearchBy.SelectedIndex = 1;
            TbSearchInput.Text = PersonID.ToString();
            FindNow();
        }

        private void FilterPerson_Load(object sender, EventArgs e)
        {
            CbSearchBy.SelectedIndex = 0;
            TbSearchInput.Focus();
        }

        private void TbSearchInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                PbSearch_Click(sender, e);
            }

            //this will allow only digits if person id is selected
            if (CbSearchBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PbSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void TbSearchInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbSearchInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbSearchInput, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(TbSearchInput, null);
            }
        }

        private void FindNow()
        {
            switch (CbSearchBy.Text)
            {
                case "Person ID":
                    this.personInfoUC1.LoadPersonInfo(int.Parse(TbSearchInput.Text));

                    break;

                case "National No.":
                    this.personInfoUC1.LoadPersonInfo(TbSearchInput.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnPersonSelected(this.personInfoUC1.PersonID);
        }

        public void FilterFocus()
        {
            TbSearchInput.Focus();
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            AddUpdatePerson addPerson = new AddUpdatePerson();
            // Subscribe to the event using the method name
            addPerson.DataBack += DataBackEvent;
            addPerson.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            CbSearchBy.SelectedIndex = 1;
            TbSearchInput.Text = PersonID.ToString();
            this.personInfoUC1.LoadPersonInfo(PersonID);
        }

        #region
        private void CbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TbSearchInput_TextChanged(object sender, EventArgs e)
        {
        }


        #endregion
    }
}
