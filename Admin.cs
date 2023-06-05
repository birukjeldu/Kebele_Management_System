using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebele_Management_System
{
    public class Admin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public Admin(string email, string password, string fullName)
        {
            Email = email;
            Password = password;
            FullName = fullName;
        }
    }


}
