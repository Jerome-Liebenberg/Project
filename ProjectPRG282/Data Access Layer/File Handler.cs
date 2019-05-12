using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    class File_Handler
    {
        FileStream _FStream;
        StreamReader _myReader;
        StreamWriter _myWriter;

        public File_Handler()  // No need to have a Filepath property because we will be reading from and writing to different txtFiles
        {

        }

        public List<string> EncryptMsg(string _FilePath)   // Method for reading the Encrypted mesage from the txtFile
        {
            string line = string.Empty;
            List<string> EncrptMsg = new List<string>();

            try
            {
                _FStream = new FileStream(_FilePath, FileMode.Open, FileAccess.Read);
                _myReader = new StreamReader(_FStream);
                line = _myReader.ReadLine();

                while (line != null)                     // Might need to change according to format of txtFile by what seperates each word etc. (I have a photo)
                {
                    EncrptMsg.Add(line);
                    line = _myReader.ReadLine();
                }
                // Returns list after the 'Finally'
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File {0} was not found.", _FilePath);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory {0} was not found.", _FilePath);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error: {0} ", ioe.Message);
            }
            finally
            {
                _myReader.Close();
                _FStream.Close();
            }
            return EncrptMsg;
        }

        public List<string> DecryptMsg(string _FilePath) // Method for writing the Unencrypted text to the Database (Don't know how to write to DB with txtFile)
        {
            string line = string.Empty;
            List<string> DecrptMsg = new List<string>();

            try
            {
                _FStream = new FileStream(_FilePath, FileMode.Truncate, FileAccess.Write);  // Use Truncate becasue every encrypted message will be different therefore existing txtFile must be overwritten
                _myWriter = new StreamWriter(_FStream);
                line = _myReader.ReadLine();

                //while (line != null)                                        // INSERT DECRYPTION CODE HERE!!!!
                //{
                //    DecrptMsg.Add(line);
                //    line = _myReader.ReadLine();
                //}

                // Returns list after the 'Finally'
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File {0} was not found.", _FilePath);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory {0} was not found.", _FilePath);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error: {0} ", ioe.Message);
            }
            finally
            {
                _myReader.Close();
                _FStream.Close();
            }
            return DecrptMsg;
        }

    }
}
