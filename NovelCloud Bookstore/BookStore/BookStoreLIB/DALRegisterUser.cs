using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// DALRegisterUser is the class to interact with the database
/// </summary>
/// 
namespace BookStoreLIB
{
    class DALRegisterUser
    {
        public string ErrorMessage { set; get; }
        
        public bool Register(string username, string password1, string password2, string fullName)
        {
            if (!UserRegister.VerifyRegistration(username, password1, password2, fullName))
            {
                ErrorMessage = "Please fill in all fields.";
                return false;
            }
            if (DALUserInfo.HasInvalidPassword(password1))
            {
                ErrorMessage = "Password requires at least six alphanumeric characters.";
                return false;
            }

            string newType = "CU";

            DBQueries db = new DBQueries();
  
            List<object> bookstore = new List<object>(
                new object[] { username, password1, newType, 0, fullName}
                );
            
            return db.INSERT_INTO_TABLE("UserData", bookstore);
        }
    }
}
