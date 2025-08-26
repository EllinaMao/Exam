using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_logic
{
    public class InvalidLoginOrPasswordException : Exception
    {
        public InvalidLoginOrPasswordException(string login)
            : base($"Invalid login or password for user: {login}") { }
    }
}
