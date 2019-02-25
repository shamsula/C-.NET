using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLIB
{
    internal class DBInsert
    {
        public Boolean AdminUsers_Insert(List<object> bookstore, SqlConnection conn)
        {
            DBGetID gID = new DBGetID();
            int id = gID.GetID("AdminUsers", conn);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO AdminUsers VALUES "
                + "(@UserID, @AdminLevel)";
            cmd.Parameters.AddWithValue("@UserID", id);
            cmd.Parameters.AddWithValue("@AdminLevel", bookstore[0]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean BookData_Insert(List<object> bookstore, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO BookData VALUES "
                + "(@ISBN, @CategoryID, @Title, @Author, @Price, @SupplierId, @Year, @Edition, @Publisher, @Description)";
            cmd.Parameters.AddWithValue("@ISBN", bookstore[0]);
            cmd.Parameters.AddWithValue("@CategoryID", bookstore[1]);
            cmd.Parameters.AddWithValue("@Title", bookstore[2]);
            cmd.Parameters.AddWithValue("@Author", bookstore[3]);
            cmd.Parameters.AddWithValue("@Price", bookstore[4]);
            cmd.Parameters.AddWithValue("@SupplierId", bookstore[5]);
            cmd.Parameters.AddWithValue("@Year", bookstore[6]);
            cmd.Parameters.AddWithValue("@Edition", bookstore[7]);
            cmd.Parameters.AddWithValue("@Publisher", bookstore[8]);
            cmd.Parameters.AddWithValue("@Description", bookstore[9]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean Category_Insert(List<object> bookstore, SqlConnection conn)
        {
            DBGetID gID = new DBGetID();
            int id = gID.GetID("Category", conn);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Category VALUES "
                + "(@CategoryID, @Name, @Description)";
            cmd.Parameters.AddWithValue("@CategoryID", id);
            cmd.Parameters.AddWithValue("@Name", bookstore[0]);
            cmd.Parameters.AddWithValue("@Description", bookstore[1]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean OrderItem_Insert(List<object> bookstore, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO OrderItem VALUES "
                + "(@OrderID, @ISBN, @Quantity)";
            cmd.Parameters.AddWithValue("@OrderID", bookstore[0]);
            cmd.Parameters.AddWithValue("@ISBN", bookstore[1]);
            cmd.Parameters.AddWithValue("@Quantity", bookstore[2]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean Orders_Insert(List<object> bookstore, SqlConnection conn)
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Orders VALUES "
                + "(@OrderID, @UserID, @OrderDate, @Status)";
            cmd.Parameters.AddWithValue("@OrderID", bookstore[0]);
            cmd.Parameters.AddWithValue("@ISBN", bookstore[1]);
            cmd.Parameters.AddWithValue("@OrderDate", bookstore[2]);
            cmd.Parameters.AddWithValue("@Status", bookstore[3]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean Supplier_Insert(List<object> bookstore, SqlConnection conn)
        {
            DBGetID gID = new DBGetID();
            int id = gID.GetID("Supplier", conn);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Supplier VALUES "
                + "(@SupplierId, @Name)";
            cmd.Parameters.AddWithValue("@SupplierId", id);
            cmd.Parameters.AddWithValue("@Name", bookstore[0]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean UserData_Insert(List<object> bookstore, SqlConnection conn)
        {
            DBGetID gID = new DBGetID();
            int id = gID.GetID("UserData", conn);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO UserData VALUES "
                    + "(@UserID, @Username, @Password, @Type, @Manager, @FullName)";
            cmd.Parameters.AddWithValue("@UserID", id);
            cmd.Parameters.AddWithValue("@Username", bookstore[0]);
            cmd.Parameters.AddWithValue("@Password", bookstore[1]);
            cmd.Parameters.AddWithValue("@Type", bookstore[2]);
            cmd.Parameters.AddWithValue("@Manager", bookstore[3]);
            cmd.Parameters.AddWithValue("@FullName", bookstore[4]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean UserLoginData_Insert(List<object> bookstore, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO UserLoginData VALUES "
                    + "(@UserName, @Password)";
            cmd.Parameters.AddWithValue("@UserName", bookstore[0]);
            cmd.Parameters.AddWithValue("@Password", bookstore[1]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean UserPersonalData_Insert(List<object> bookstore, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO UserPersonalData VALUES "
                    + "(@UserID, @FullName)";
            cmd.Parameters.AddWithValue("@UserID", bookstore[0]);
            cmd.Parameters.AddWithValue("@FullName", bookstore[1]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }

        public Boolean UserReviews_Insert(List<object> bookstore, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO UserReviews VALUES "
                    + "(@ISBN, @OrderID, @Rating, @Comments)";
            cmd.Parameters.AddWithValue("@ISBN", bookstore[0]);
            cmd.Parameters.AddWithValue("@OrderID", bookstore[1]);
            cmd.Parameters.AddWithValue("@Rating", bookstore[2]);
            cmd.Parameters.AddWithValue("@Comments", bookstore[3]);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return !(result < 0);
        }
    }
}