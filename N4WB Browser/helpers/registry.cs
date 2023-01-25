using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N4WB_Browser.helpers
{
    internal static class registry
    {
        public static string get(string value)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\N4WB"))
                {
                    if (key != null)
                    {
                        object o = key.GetValue(value);
                        if (o != null)
                        {
                            return o.ToString();
                        }
                    }
                    else
                        throw new Exception("This registry key does not exist.");
                }
            }
            catch
            {
                throw new Exception("Something went wrong trying to open the Registry.");
            }

            throw new Exception("This value pair does not exist.");
        }

        public static bool exists(string value)
        {
            try
            {
                get(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void set(string valueName, string value)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

                // Try opening the subkey and create it if it doesn't exist already
                RegistryKey subKey = subKey = key.CreateSubKey("N4WB");

                subKey.SetValue(valueName, value);
                key.Close();
                subKey.Close();
            }
            catch
            {
                //throw new Exception("Failed to set registry value pair");
            }
        }
    }
}
