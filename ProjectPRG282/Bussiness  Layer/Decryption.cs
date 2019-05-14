using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access_Layer;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bussiness__Layer
{
    public class Decryption
    {
        public Decryption()
        {

        }
        public string GetBinary(string binary)
        {
            File_Handler fh = new File_Handler();
            string encryptedmessage;
            encryptedmessage = fh.Binarytostring(binary);
            return encryptedmessage;
        }

        public string[] DecryptedMessage(string encryptedmessage)
        {
            File_Handler fh = new File_Handler();            
            return fh.GetDecyptedMessage(encryptedmessage);
        }

        public void sendmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int ValidSentence(string message)
        {
            string[] sentences = message.Split(new char[] {' '});
            string[] wordsToMatch = {  };
        }
    }
}
