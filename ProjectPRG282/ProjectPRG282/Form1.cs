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
    public partial class Form1 : Form
    {
        Communications communications = new Communications();
        Officers frmOfficers = new Officers();
        User UserCls = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Pw = txtPassword.Text;
            List<User> lUsers =  UserCls.GetUsers(); //  Method used for populating the list<User> with the DBA method for PopulateUsers method that returns a list of Users

            foreach (User user in lUsers)
            {
                if (Username == user.Username && Pw == user.Password) // Need to find out if High-Ranking or low-ranking to display appropriate form
                {
                    if (user.Rank >= 5)  // High ranking officers gain access to button for adding additonal officers
                    {
                        frmOfficers.btnOfficer.Enabled = true;
                        communications.Show();
                        this.Hide();
                    }
                    else  // Low ranking are not able to see the button specifically for high ranking officers
                    {
                        frmOfficers.btnOfficer.Enabled = false;
                        communications.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Log in details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
