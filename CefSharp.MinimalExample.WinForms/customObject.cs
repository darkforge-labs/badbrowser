using System;
using System.IO;

namespace CefSharp.MinimalExample.WinForms
{
    public class CustomObject
    {
        /// <summary>
        /// Writes the contents "testing" to a file in C:\test\ folder
        /// </summary>
        /// <param name="fileName">Name of the file to create</param>
        /// <returns>True if the file was successfully written, false otherwise</returns>
        public bool WriteFile(string fileName)
        {
            try
            {
                // Ensure the directory exists
                string directory = @"C:\temp\";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Combine the directory and filename
                string filePath = Path.Combine(directory, fileName);

                // Write the file
                File.WriteAllText(filePath, "testing");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}