using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_logic
{
    public class RegularUser : User
    {
        public RegularUser() : base()
        {
        }
        public RegularUser(string login , string password , DateOnly dateOfBirth) : base(login , password , dateOfBirth)
        {
        }
    }
}
