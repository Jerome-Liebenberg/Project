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
        public Communications()
        {
            InitializeComponent();
            PW = OpenedPanel.Width;
            hided = false;
        }

        private void Communications_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                OpenedPanel.Width = OpenedPanel.Width + 10;
                if (OpenedPanel.Width>=PW)
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

        private void Communications_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
