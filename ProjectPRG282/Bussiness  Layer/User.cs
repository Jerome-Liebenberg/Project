using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data_Access_Layer;

namespace Bussiness__Layer
{
    public class User
    {
        private int idNumber;
        private string name;
        private string surname;
        private int age;
        private int rank;
        private string username;
        private string password;
        

        public int IdNumber { get => idNumber; set => idNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public int Rank { get => rank; set => rank = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        DB_Access dba = new DB_Access();

        public User(string _Username, string _Password)
        {
            //this.idNumber = ; // Need to get UserID without them entering it (Load from Database?)
            // this.name = ;
            // this.surname = ;
            // this.age = ;
            //this.rank = ; // Ranking according to the user logged in- get from database?
            this.username = _Username;
            this.password = _Password;
        }

        public User() // default Constructor
        {
        }

        public List<User> GetUsers()  // Using the method for reading all the user data from the DB_Access into a List that we will use for the login details
        {
            List<User> returnUserList = new List<User>();
            DataSet RawData = dba.ReadData("Users"); 

            foreach (DataRow item in RawData.Tables["Users"].Rows)
            {
                User User = new User();

                User.idNumber = int.Parse(item["IDNumber"].ToString());
                User.name = item["U_Name"].ToString();
                User.surname = item["U_Surname"].ToString();
                User.age = int.Parse(item["U_Age"].ToString());
                User.rank = int.Parse(item["U_Rank"].ToString());
                User.username = item["Username"].ToString();
                User.password = item["U_Password"].ToString();

                returnUserList.Add(User);
            }
            return returnUserList;
        }

        public void AddUser(string _UName, string _USurname, int _UAge, int _URank, string _Username, string _PW)
        {
            dba.AddUser(_UName,_USurname,_UAge,_URank,_Username,_PW);
        } // For buttons on Officer form 

        public void RemoveUser(int _UserID)
        {
            dba.RemoveUser(_UserID);
        } // For buttons on Officer form 

        public void UpdateUser(int _UserID, string _UName, string _USurname, int _UAge, int _URank, string _Username, string _P)
        {
            dba.UpdateUser(_UserID,_UName,  _USurname,  _UAge,  _URank,  _Username,  _P);
        } 
    }
}
