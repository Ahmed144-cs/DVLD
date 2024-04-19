using DVLD.Properties;
using DVLD_LogicAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.AddUpdatePerson;

namespace DVLD
{
    public partial class PersonInfoUC : UserControl
    {
        private int _PersonID = -1;
        private PersonLogic _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public PersonLogic SelectedPersonInfo
        {
            get { return _Person; }
        }

        public PersonInfoUC()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = PersonLogic.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = PersonLogic.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            LPersonID.Text = PersonID.ToString();
            LName.Text = _Person.FullName;
            LNationalNo.Text = _Person.NationalOn;
            LGendor.Text = _Person.Gender == 0 ? "Female" : "Male";
            LPhone.Text = _Person.Phone;
            LEmail.Text = _Person.Email;
            LDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            LCountry.Text = _Person.CountryInfo.CountryName;
            LAddress.Text = _Person.Address;

            linkLabelEditPerson.Visible = true;
            _LoadPersonImage();
        }    

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                PbPersonPhoto.Image = Resources.admin_female;
            else
                PbPersonPhoto.Image = Resources.admin_female;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PbPersonPhoto.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            LPersonID.Text = "[????]";
            LName.Text = "[????]";
            LNationalNo.Text = "[????]";
            LGendor.Text ="[????]";
            LPhone.Text = "[????]";
            LEmail.Text = "[????]";
            LDateOfBirth.Text = "[????]";
            LCountry.Text = "[????]";
            LAddress.Text = "[????]";
            PbPersonPhoto.Image = Resources.admin;
            linkLabelEditPerson.Visible = false;
        }

        private void linkLabelEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            Form editPerosn = new AddUpdatePerson(_PersonID);
            editPerosn.ShowDialog();

            //refresh
            LoadPersonInfo(_PersonID);
        }

        #region
        public void PersonInfoUC_Load(object sender, EventArgs e)
        {
        }

        private void LPersonID_Click(object sender, EventArgs e)
        {

        }

        private void LName_Click(object sender, EventArgs e)
        {

        }

        private void LNationalNo_Click(object sender, EventArgs e)
        {

        }

        private void LGendor_Click(object sender, EventArgs e)
        {

        }

        private void LPhone_Click(object sender, EventArgs e)
        {

        }

        private void LEmail_Click(object sender, EventArgs e)
        {

        }

        private void LDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void PersonInfoUC_Load_1(object sender, EventArgs e)
        {

        }

        private void LCountry_Click(object sender, EventArgs e)
        {

        }

        private void LAddress_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
