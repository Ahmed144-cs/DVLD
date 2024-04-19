using DVLD.Properties;
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

namespace DVLD
{
    public partial class AddUpdatePerson : Form
    {
        public AddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public AddUpdatePerson(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            _Mode = enMode.Update;
        }

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female = 0,  Male = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        PersonLogic _Person;

        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                FormLabel.Text = "Add New Person";
                _Person = new PersonLogic();
            }
            else
            {
                FormLabel.Text = "Update Person";
            }

            //set default image for the person.
            if (RbFemale.Checked)
                PbPersonImage.Image = Resources.admin_female;
            else
                PbPersonImage.Image = Resources.admin;

            //hide/show the remove linke incase there is no image for the person.
            linkLabelRemoveImage.Visible = (PbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            DtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            DtpDateOfBirth.Value = DtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            DtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            CbCountry.SelectedIndex = CbCountry.FindString("Jordan");

            TbFirstName.Text = "";
            TbSecondName.Text = "";
            TbThirdName.Text = "";
            TbLastName.Text = "";
            TbNational.Text = "";
            RbMale.Checked = true;
            TbPhone.Text = "";
            TbEmail.Text = "";
            TbAddress.Text = "";
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = CountryLogicAccess.GetCountryDataFromDataAccess();

            foreach (DataRow row in dtCountries.Rows)
            {
                CbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _Person = PersonLogic.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            labelPersonID.Text = _PersonID.ToString();
            TbFirstName.Text = _Person.FirstName;
            TbSecondName.Text = _Person.SecondName;
            TbThirdName.Text = _Person.ThirdName;
            TbLastName.Text = _Person.LastName;
            TbNational.Text = _Person.NationalOn;
            DtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                RbFemale.Checked = true;
            else
                RbMale.Checked = true;

            TbAddress.Text = _Person.Address;
            TbPhone.Text = _Person.Phone;
            TbEmail.Text = _Person.Email;
            CbCountry.SelectedIndex = CbCountry.FindString(_Person.CountryInfo.CountryName);

            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                PbPersonImage.ImageLocation = _Person.ImagePath;
            }
            //hide/show the remove linke incase there is no image for the person.
            linkLabelRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != PbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (PbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = PbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        PbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        #region
        private void addPerson1_Load_1(object sender, EventArgs e)
        {

        }//user control

        private void addPerson1_Load(object sender, EventArgs e)
        {

        }

        private void labelPersonID_Click(object sender, EventArgs e)
        {

        }      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLabel_Click(object sender, EventArgs e)
        {

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

        }
        #endregion

        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                PbPersonImage.Load(selectedFilePath);
                linkLabelRemoveImage.Visible = true;
                // ...
            }
        }

        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPersonImage.ImageLocation = null;

            if (RbMale.Checked)
                PbPersonImage.Image = Resources.admin;
            else
                PbPersonImage.Image = Resources.admin_female;

            linkLabelRemoveImage.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = CountryLogicAccess.Find(CbCountry.Text).ID;

            _Person.FirstName = TbFirstName.Text.Trim();
            _Person.SecondName = TbSecondName.Text.Trim();
            _Person.ThirdName = TbThirdName.Text.Trim();
            _Person.LastName = TbLastName.Text.Trim();
            _Person.NationalOn = TbNational.Text.Trim();
            _Person.Email = TbEmail.Text.Trim();
            _Person.Phone = TbPhone.Text.Trim();
            _Person.Address = TbAddress.Text.Trim();
            _Person.DateOfBirth = DtpDateOfBirth.Value;

            if (RbMale.Checked)
                _Person.Gender = (short)enGendor.Male;
            else
                _Person.Gender = (short)enGendor.Female;

            _Person.NationalityCountryID = NationalityCountryID;

            if (PbPersonImage.ImageLocation != null)
                _Person.ImagePath = PbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                labelPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                FormLabel.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RbMale_Click(object sender, EventArgs e)
        {
            if (PbPersonImage.ImageLocation == null)
                PbPersonImage.Image = Resources.admin;
        }

        private void RbFemale_Click(object sender, EventArgs e)
        {
            if (PbPersonImage.ImageLocation == null)
                PbPersonImage.Image = Resources.admin_female;
        }

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (TbEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(TbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(TbEmail, null);
            };
        }

        private void TbNational_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbNational, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(TbNational, null);
            }

            //Make sure the national number is not used by another person
            if (TbNational.Text.Trim() != _Person.NationalOn && 
                                        PersonLogic.IsPersonExist(TbNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbNational, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(TbNational, null);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
    }
}
