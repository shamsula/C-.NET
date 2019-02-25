/* **********************************************************************************
 * For use by students taking 60-422 (Fall, 2014) to work on assignments and project.
 * Permission required material. Contact: xyuan@uwindsor.ca 
 * **********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace BookStoreLIB
{
    class DALUserInfo
    {
        public string ErrorMessage { set; get; }

        public int LogIn(string userName, string password)
        {
            if (HasEmptyFields(userName, password))
            {
                ErrorMessage = "Please fill in all slots.";
                return -1;
            }
            if (HasInvalidPassword(password))
            {
                ErrorMessage = "Password requires at least six\ncharacters with both letters and numbers.";
                return -1;
            }

            var conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select UserID from UserData where "
                    + " UserName = @UserName and Password = @Password ";
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                int userId = (int)cmd.ExecuteScalar();
                if (userId > 0) return userId;
                else
                {
                    ErrorMessage = "Wrong name or password.";
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private bool HasEmptyFields(string loginName, string password)
        {
            return loginName == "" || password == "";
        }

        public static bool HasInvalidPassword(string password)
        {
            if (password.Length < 6)
                return true;

            if (!Char.IsLetter(password[0]) || !Char.IsLetter(password[1]))
                return true;

            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                    return true;
            }

            return false;
        }
    }
}
