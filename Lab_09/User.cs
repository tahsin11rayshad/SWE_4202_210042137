using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    internal class User
    {
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public User(string _username, string _name, string _password) 
        {
            this.username = _username;
            this.name = _name;  
            this.password = _password;
        }
    }
}
