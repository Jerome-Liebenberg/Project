using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussiness__Layer;
using System.Threading;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace ProjectPRG282
{
    public partial class Decrypt : Form
    {
        int PW;
        string message;
        bool hided;

        Past_Communications P_communications = new Past_Communications();
        Officers officers = new Officers();
        Stopwatch stopwatch = new Stopwatch();

        public Decrypt()
        {
            InitializeComponent();
            PW = OpenedPanel.Width;
            hided = false;
        }

        private void btnPanelOpen_Click(object sender, EventArgs e)
        {
            OpenedPanel.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                OpenedPanel.Width = OpenedPanel.Width + 10;
                if (OpenedPanel.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                OpenedPanel.Width = OpenedPanel.Width - 10;
                if (OpenedPanel.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {
            timer1.Start();
            OpenedPanel.Hide();
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += richTextBox1_DragDrop;
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    richTextBox1.LoadFile(filenames[0], RichTextBoxStreamType.PlainText);
                    File.Delete(filenames[0]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            decrypt.Show();
            P_communications.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_communications.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {


        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Please give a valid textfile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stopwatch.Start();
                Decryption decryption = new Decryption();
                string encryptedmessage;
                encryptedmessage = decryption.GetBinary(richTextBox1.Text);
                richTextBox2.Lines = decryption.DecryptedMessage(encryptedmessage);
                message = richTextBox2.Text;
                stopwatch.Stop();
                int duration = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
                Communications com = new Communications();
                Form1 form1 = new Form1();
                int id = form1.GetUserID();
                com.AddCommunication(id, Convert.ToDateTime(duration), message);                
            }
        }

        private void btnOfficer_Click(object sender, EventArgs e)
        {
            officers.Show();
            this.Hide();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("jeromeliebenberg41@gmail.com", "dshapovalov199974@gmail.com");
            SmtpClient SmtpServer = new SmtpClient();
            mail.Subject = "Encrypted Message";
            mail.Body = "The decrypted message : /n{0}" + message;
            mail.IsBodyHtml = true;
            SmtpServer.Port = 587;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = false;
            NetworkCredential credential = new NetworkCredential("jeromeliebenberg41@gmail.com", "liebenberghuis41");
            SmtpServer.Credentials = credential;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("mail Send");
        }
    }
}
