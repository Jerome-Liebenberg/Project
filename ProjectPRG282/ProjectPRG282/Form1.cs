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
        List<User> l_User = new List<User>();
        Communications communications = new Communications();

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
            
            foreach (User user in l_User)  // Need to populate l_User with form load
            {
                if (Username == user.Username && Pw == user.Password) // Need to find out if High-Ranking or low-ranking to display appropriate form
                {
                    this.Hide();
                    communications.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Log in details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
