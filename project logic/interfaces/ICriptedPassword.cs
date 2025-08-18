using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_logic.interfaces
{
    public interface ICriptedPassword
    {
        public bool CheckPassword(string password);
    }
}
