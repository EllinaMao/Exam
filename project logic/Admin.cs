using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_logic
{
    public class Admin:User, interfaces.IAdmin
    {
        public bool isAdmin { get; } = true;

        public Admin() : base()
        {
        }
        public Admin(string login, string password, DateOnly dateOfBirth) : base(login, password, dateOfBirth)
        {
        }

    }
}
