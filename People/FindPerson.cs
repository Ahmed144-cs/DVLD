using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FindPerson : Form
    {
        public FindPerson()
        {
            InitializeComponent();
        }


        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        private async void BtnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, this.filterPerson1.PersonID);
            await Task.Delay(500); // Delay for 500 milliseconds
            this.Close();
        }

        private void FindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
