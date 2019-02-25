using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLIB
{
    public class UserRegister
    {
        public string ErrorMessage { set; get; }

        public bool Register (string username, string password1, string password2, string fullname)
        {
            var dbRegister = new DALRegisterUser();
            bool result = dbRegister.Register(username, password1, password2, fullname);
            ErrorMessage = dbRegister.ErrorMessage;
            return result;
        }

        public static bool VerifyRegistration(string user, string pass1, string pass2, string name)
        {
            return !user.Equals("") && !pass1.Equals("") && !pass2.Equals("") && !name.Equals("") && pass1.Equals(pass2);
        }
    }
}
