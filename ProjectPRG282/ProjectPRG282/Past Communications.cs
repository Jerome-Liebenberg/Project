using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussiness__Layer;

namespace ProjectPRG282
{
    public partial class Past_Communications : Form
    {
        int PW;
        bool hided;
        bool check;

        BindingSource bs = new BindingSource();      

        public Past_Communications()
        {
            InitializeComponent();
            PW = OpenedPanel.Width;
            hided = false;
            check = true;
        }

        private void Past_Communications_Load(object sender, EventArgs e)
        {
            Communications comms = new Communications();
            bs.DataSource = comms.GetPastComms();
            dgvDisplay.DataSource = bs;

            if (check == true)
            {
                timer1.Start();
            }
            OpenedPanel.Hide();
        }

        private void btnPanelOpen_Click(object sender, EventArgs e)
        {
            OpenedPanel.Show();
            timer1.Start();
            check = false;
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
                    check = true;
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

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            Communications comms = (Communications)bs.Current;
            txtMessageID.Text = comms.Messageid.ToString();
            txtDuration.Text = comms.Duration.ToString();
            txtMessage.Text = comms.Message;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOfficers_Click(object sender, EventArgs e)
        {
            
            Officers officers = new Officers();
            this.Hide();
            officers.Show();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            this.Hide();
            decrypt.Show();
        }
    }
}
