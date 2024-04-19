using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_LogicAccess;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form peopleForm = new PeopleForm();
            peopleForm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form userForm = new ManageUsers();
            userForm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo editUser = new UserInfo(clsGlobal.CurrUser.UserID);
            editUser.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangUserPassword changePass = new ChangUserPassword(clsGlobal.CurrUser.UserID);
            changePass.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrUser = null;
            clsGlobal.DeleteLoginInfo();
            this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmManageApplicationTypes manageAppTp = new FmManageApplicationTypes();
            manageAppTp.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes manageTestTp = new ManageTestTypes();
            manageTestTp.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateLocalDrivingLicense nLocDrv = new AddUpdateLocalDrivingLicense();
            nLocDrv.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications llDrivLicApp = new LocalDrivingLicenseApplications();
            llDrivLicApp.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers drivers = new ManageDrivers();
            drivers.ShowDialog();
        }

        private void internaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApp internalLic = new NewInternationalLicenseApp();
            internalLic.ShowDialog();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalDrivLicenseApp intDrivLicApp = new InternationalDrivLicenseApp();
            intDrivLicApp.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLocalDrivingLicense newLicense = new RenewLocalDrivingLicense();
            newLicense.ShowDialog();
        }

        private void replacementForLastOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementLastOrDamagedLicApp ReplacementLic = new ReplacementLastOrDamagedLicApp();
            ReplacementLic.ShowDialog();
        }

        private void detainLicensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetainLicenseApplication detainLicense = new DetainLicenseApplication();          
            detainLicense.ShowDialog();
        }

        private void releaseDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseApplication releaseLicenses = new ReleaseDetainedLicenseApplication();
            releaseLicenses.ShowDialog();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainLicApp listDetainLic = new ManageDetainLicApp();
            listDetainLic.ShowDialog();
        }
    }
}
