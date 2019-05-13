using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectPRG282
{
    public partial class Decrypt : Form
    {
        int PW;
        bool hided;
        Communications communications = new Communications();
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
    }
}
