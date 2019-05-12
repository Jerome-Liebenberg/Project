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
    public partial class Communications : Form
    {
        int PW;
        bool hided;
        bool labelhided;
        bool check;
        public Communications()
        {

            InitializeComponent();
            PW = OpenedPanel.Width;
            hided = false;
            labelhided = false;
            check = false;
        }

        private void Communications_Load(object sender, EventArgs e)
        {
            if (check == true)
            {
                timer1.Start();
            }
            OpenedPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenedPanel.Show();
            timer1.Start();
            check = false;
            if (labelhided == false)
            {
                timer2.Start();
            }
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

        private void Communications_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNameOfOfficer_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelhided = true;
            int fadingSpeed = 15;
            label1.ForeColor = Color.FromArgb(label1.ForeColor.R + fadingSpeed, label1.ForeColor.G + fadingSpeed, label1.ForeColor.B + fadingSpeed);

            if (label1.ForeColor.R >= this.BackColor.R)
            {
                timer1.Stop();
                label1.ForeColor = this.BackColor;
                label1.Hide();
                timer2.Stop();
            }

            lblNameOfOfficer.ForeColor = Color.FromArgb(lblNameOfOfficer.ForeColor.R + fadingSpeed, lblNameOfOfficer.ForeColor.G + fadingSpeed, lblNameOfOfficer.ForeColor.B + fadingSpeed);

            if (lblNameOfOfficer.ForeColor.R >= this.BackColor.R)
            {
                timer1.Stop();
                lblNameOfOfficer.ForeColor = this.BackColor;
                lblNameOfOfficer.Hide();
                timer2.Stop();
            }

            label2.ForeColor = Color.FromArgb(label2.ForeColor.R + fadingSpeed, label2.ForeColor.G + fadingSpeed, label2.ForeColor.B + fadingSpeed);

            if (label2.ForeColor.R >= this.BackColor.R)
            {
                timer1.Stop();
                label2.ForeColor = this.BackColor;
                label2.Hide();
                timer2.Stop();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
