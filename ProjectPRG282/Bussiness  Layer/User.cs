using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness__Layer
{
    class User
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
        
    }
}
