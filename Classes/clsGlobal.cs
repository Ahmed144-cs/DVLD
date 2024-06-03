using DVLD_LogicAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsGlobal
    {
        public static UserLogic CurrUser;
        public static readonly string WindowsRegeFilePath = @"HKEY_CURRENT_USER\SOFTWARE\MyDVLD";


        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string _UserName = Registry.GetValue(WindowsRegeFilePath, "Username", null) as string;
                string _Password = Registry.GetValue(WindowsRegeFilePath, "Password", null) as string;

                if (_UserName != null && _Password != null)
                {
                    Username = _UserName;
                    Password = _Password;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.HandleError(ex.Message);
                return false;
            }
        }

        public static bool SaveDataToRememberMeRegistry(string userName, string password)
        {
            try
            {
                Registry.SetValue(WindowsRegeFilePath,"Username", userName, RegistryValueKind.String);
                Registry.SetValue(WindowsRegeFilePath, "Password", password, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                clsErrorLogger.HandleError(ex.Message);
                return false;
            }
        }

        public static void DeleteLoginInfo()
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(WindowsRegeFilePath, true))
                    {
                        if (key != null)
                        {
                            // Delete the values under the subkey
                            key.DeleteValue("Username", false);
                            key.DeleteValue("Password", false);
                        }
                    }
                }       
            }
            catch (Exception ex)
            {
                clsErrorLogger.HandleError(ex.Message);
            }
        }
    }
}
