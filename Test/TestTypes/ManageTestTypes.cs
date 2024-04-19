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
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            DgvManageTestType.DataSource = ManageTestTypeLogic.GetTestTypeDataFromDatabase();

            if (DgvManageTestType.Rows.Count == 0)
                return;

            DgvManageTestType.Columns[0].HeaderText = "ID";
            DgvManageTestType.Columns[1].HeaderText = "Title";
            DgvManageTestType.Columns[2].HeaderText = "Fees";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypes editTestTp = new EditTestTypes(
                                        (ManageTestTypeLogic.enTestType)DgvManageTestType.CurrentRow.Cells[0].Value);
            editTestTp.ShowDialog();

            ManageTestTypes_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (DgvManageTestType.RowCount == 0);        
        }

        #region
        private void DgvManageTestType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
