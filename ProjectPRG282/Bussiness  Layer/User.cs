using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        //NB! Do not show user ID EVER!
        public User(string _Username, string _Password, string _Name, string _Surname, int _Age)
        {
            //this.userID = ; // Need to get UserID without them entering it (Load from Database?)
            this.username = _Username;
            this.password = _Password;
            //this.ranking = ; // Ranking according to the user logged in- get from database?
            this.name = _Name;
            this.surname = _Surname;
            this.age = _Age;
        }

    }
}
