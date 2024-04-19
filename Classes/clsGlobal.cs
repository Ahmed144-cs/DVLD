using DVLD_LogicAccess;
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
        public static readonly string FilePath = "RememberMeFile.txt";

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string filePath = FilePath;
                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];

                            return true;
                        }

                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static void CreateRememberMeFile()
        {
            if (!IsFileRememberMeExest())
            {
                File.Create(FilePath);
            }
        }

        public static bool IsFileRememberMeExest()
        {
            if (File.Exists(FilePath))
            {
                return true;
            }
            return false;
        }

        public static bool SaveDataToRemeberMeFile(string userName, string Password)
        {
            CreateRememberMeFile();

            return LoadDataToLoginFile(userName, Password); 
        }

        public static bool LoadDataToLoginFile(string userName, string Password)
        {
            try
            {
                StreamWriter file = new StreamWriter(FilePath, false);
                file.WriteLine(userName + "#//#" + Password);
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteLoginInfo()
        {
            try
            {
                File.WriteAllText(FilePath, string.Empty);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
