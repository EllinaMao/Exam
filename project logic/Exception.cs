using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_logic
{
    public class InvalidLoginOrPasswordException : Exception
    {
        //класс осознанно не разделяет что неправильное, что бы не показывать где ошибка в случае попытки взлома(хотя кому это надо, это викторинка)
        public InvalidLoginOrPasswordException(string login)
            : base($"Неправильный логин или пароль пользователя: {login}") { }
    }
}
