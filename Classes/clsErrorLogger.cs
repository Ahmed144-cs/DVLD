using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsErrorLogger
    {
        public static void HandleError(string ErrorMessage)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // If errorMessage is null or empty, log it as a warning
                // You can replace this with your preferred logging mechanism
                Console.WriteLine("Warning: Received null or empty error message.");
            }
        }
    }
}
