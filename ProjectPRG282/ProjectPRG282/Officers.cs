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
    public partial class Officers : Form
    {
        User usercls = new User();
        BindingSource bs = new BindingSource();
        
        
        public Officers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOfficer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text ;
            string PW = txtPassword.Text ;
            string Surname =  txtSurname.Text;
            string Username = txtUsername.Text ;

            if (txtAge.Text == null || Name == null || PW == null || txtRank.Text == null || Surname == null || Username == null)
            {
                MessageBox.Show("Invalid data inputs from text boxes. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usercls.AddUser(txtName.Text, txtSurname.Text, int.Parse(txtAge.Text), int.Parse(txtRank.Text), txtUsername.Text, txtPassword.Text); // Auto generates IDNum for user
                RefreshDisplay();
            }

        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            User User = (User)bs.Current;
            usercls.RemoveUser(User.IdNumber); // Get UserID from dgv Current bs
            RefreshDisplay();     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User User = (User)bs.Current;
            int _UserID = User.IdNumber;
            string _UName = User.Name;
            string _USurname = User.Surname;
            int _Age = User.Age;
            int _Rank = User.Rank;
            string _Username = User.Username;
            string _Password = User.Password;

            usercls.UpdateUser(_UserID, _UName, _USurname, _Age, _Rank, _Username, _Password); 
            RefreshDisplay();
        }

        public void RefreshDisplay()
        {
            bs.DataSource = usercls.GetUsers();
            dgvOfficers.DataSource = null;
            dgvOfficers.DataSource = bs;
        }

        private void Officers_Load(object sender, EventArgs e)
        {
            bs.DataSource = dgvOfficers.SelectedCells;
            
        }

        private void dgvOfficers_SelectionChanged(object sender, EventArgs e)
        {
            User user = (User)bs.Current;
            txtAge.Text = Convert.ToString(user.Age);
            txtName.Text = user.Name;
            txtPassword.Text = user.Password;
            txtRank.Text = Convert.ToString(user.Rank);
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.Username;
        }

        private void btnPastComminications_Click(object sender, EventArgs e)
        {
            Past_Communications comms = new Past_Communications();
            this.Hide();
            comms.Show();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            this.Hide();
            decrypt.Show();
        }
    }
}
