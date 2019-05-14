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


namespace ProjectPRG282
{
    public partial class Decrypt : Form
    {
        int PW;
        bool hided;
        Communications communications = new Communications();
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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            decrypt.Show();
            communications.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            Decryption decryption = new Decryption();
            string encryptedmessage;
            encryptedmessage = decryption.GetBinary(richTextBox1.Text);
            richTextBox2.Lines = decryption.DecryptedMessage(encryptedmessage);
            string source = richTextBox2.Text;
            stopwatch.Stop();
            int duration = Convert.ToInt32(stopwatch.ElapsedMilliseconds);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {

        }
    }
}
