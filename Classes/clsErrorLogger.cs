using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsErrorLogger
    {
        private static string _SourceName = "DVLD";

        public static void HandleError(string ErrorMessage)
        {
            if (!string.IsNullOrEmpty(ErrorMessage) && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _CreateEventLogFile();

                // Log an information event
                EventLog.WriteEntry(_SourceName, ErrorMessage, EventLogEntryType.Error);
            }    
        }

        private static void _CreateEventLogFile()
        {
            if(!EventLog.SourceExists(_SourceName))
            {
                EventLog.CreateEventSource(_SourceName, "Application");
            }
        }
    }
}
