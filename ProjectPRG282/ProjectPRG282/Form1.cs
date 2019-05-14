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
        public int userid;

        Decrypt decrypt = new Decrypt();
        Past_Communications comms = new Past_Communications();
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
            bool found = false;
            List<User> lUsers =  UserCls.GetUsers(); //  Method used for populating the list<User> with the DBA method for PopulateUsers method that returns a list of Users

            foreach (User user in lUsers)
            {
                if (Username == user.Username && Pw == user.Password) // Need to find out if High-Ranking or low-ranking to display appropriate form
                {
                    found = true;
                    if (user.Rank >= 5)  // High ranking officers gain access to button for adding additonal officers
                    {
                        comms.btnOfficers.Enabled = true;
                        decrypt.btnOfficer.Enabled = true;
                    }
                    else  // Low ranking are not able to see the button specifically for high ranking officers
                    {
                        comms.btnOfficers.Enabled = false;
                        decrypt.btnOfficer.Enabled = false;
                    }
                    userid = user.IdNumber;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            if (found == true)
            {
                decrypt.Show();
                this.Hide();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                MessageBox.Show("Invalid Log in details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public int GetUserID()
        {
            return userid;
        }
    }
}
