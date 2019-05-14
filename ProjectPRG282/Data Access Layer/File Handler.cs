using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    public class File_Handler
    {
        string encrypted_string;

        public File_Handler() //default Constructor
        {

        }

        public string Binarytostring(string binary)
        {
            string tempString = "";
            string Character = System.Text.RegularExpressions.Regex.Replace(binary, "[^01]", "");
            byte[] Bytes = new byte[(Character.Length / 8) - 1 + 1];
            for (int Index = 0; Index <= Bytes.Length - 1; Index++)
            {
                Bytes[Index] = Convert.ToByte(Character.Substring(Index * 8, 8), 2);
            }
            tempString = (string)(System.Text.ASCIIEncoding.ASCII.GetString(Bytes));
            return tempString;
        }

        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        public string[] GetDecyptedMessage(string tempstring)
        {
            string t;
            string[] stringArray = null;

            int key;
            for (int i = 0; i < 8; i++)
            {

                key = i;
                t = Decipher(tempstring, key);
                stringArray = new string[] { t };
            }
            return stringArray;
        }
    }
}
