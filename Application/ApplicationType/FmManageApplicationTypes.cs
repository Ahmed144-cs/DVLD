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
    public partial class FmManageApplicationTypes : Form
    {
        public FmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void FmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            DgvManageAppType.DataSource = ManageAppTypesLogic.GetApplicationTypesData();

            if (DgvManageAppType.Rows.Count == 0)
                return;

            DgvManageAppType.Columns[0].HeaderText = "ID";
            DgvManageAppType.Columns[1].HeaderText = "Title";
            DgvManageAppType.Columns[2].HeaderText = "Fees";
        }


        private void DgvManageAppType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationTypes editAppTp = new EditApplicationTypes((int)DgvManageAppType.CurrentRow.Cells[0].Value);
            editAppTp.ShowDialog();

            FmManageApplicationTypes_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (DgvManageAppType.RowCount == 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
