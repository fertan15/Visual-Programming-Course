using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    public class Account
    {
        public String username { get; set; }
        public String fullName { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public Account(string email, string username, string fullName, string password)
        {
            this.username = username;
            this.fullName = fullName;
            this.email = email;
            this.password = password;
        }
    }
}
