using Microsoft.Win32;
using RentalBusinessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string RegisteryName = @"HKEY_CURRENT_USER\SOFTWARE\RentalCar";

            string ValueName = "LastLogIn";
            string ValueDate = Registry.GetValue(RegisteryName, ValueName, null) as string;

            if (Username == "" && !string.IsNullOrEmpty(ValueDate))
            {
                ValueDate = "";
                Registry.SetValue(RegisteryName, ValueDate, ValueDate);
            }

            ValueDate = Username + "#//#" + Password;

            try
            {
                Registry.SetValue(RegisteryName, ValueName, ValueDate);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }

            /*try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username=="" && File.Exists(filePath)) 
                { 
                     File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#"+Password ;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);
                   
                  return true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;
            }*/

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string RegisteryName = @"HKEY_CURRENT_USER\SOFTWARE\RentalCar";

            string ValueName = "LastLogIn";

            try
            {
                string ValueDate = Registry.GetValue(RegisteryName, ValueName, null) as string;

                if (!string.IsNullOrEmpty(ValueDate))
                {
                    string[] Result = ValueDate.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    Username = Result[0];
                    Password = Result[1];
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
                return false;
            }

            //return true;
            /*//this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath  = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }*/

        }

        public static void SaveEventLog(string Message, EventLogEntryType LogType, string SourceName = "DVLD")
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, Message, LogType);
        }

        public static string ComputeHash(string Name)
        {
            using (SHA256 Hashing = SHA256.Create())
            {
                byte[] hashBytes = Hashing.ComputeHash(Encoding.UTF8.GetBytes(Name));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
