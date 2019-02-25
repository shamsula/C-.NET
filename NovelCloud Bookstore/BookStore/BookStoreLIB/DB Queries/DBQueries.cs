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
    public class DBQueries
    {
        public Boolean INSERT_INTO_TABLE(string table, List<object> bookstore)
        {
            Boolean flag = false;
            var conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            DBInsert dbI = new DBInsert();
            try
            {
                switch (table)
                {
                    case "AdminUsers":
                        flag = dbI.AdminUsers_Insert(bookstore, conn);
                        break;
                    case "BookData":
                        flag = dbI.BookData_Insert(bookstore, conn);
                        break;
                    case "Category":
                        flag = dbI.Category_Insert(bookstore, conn);
                        break;
                    case "OrderItem":
                        flag = dbI.OrderItem_Insert(bookstore, conn);
                        break;
                    case "Orders":
                        flag = dbI.Orders_Insert(bookstore, conn);
                        break;
                    case "Supplier":
                        flag = dbI.Supplier_Insert(bookstore, conn);
                        break;
                    case "UserData":
                        flag = dbI.UserData_Insert(bookstore, conn);
                        break;
                    case "UserLoginData":
                        flag = dbI.UserLoginData_Insert(bookstore, conn);
                        break;
                    case "UserPersonalData":
                        flag = dbI.UserPersonalData_Insert(bookstore, conn);
                        break;
                    case "UserReviews":
                        flag = dbI.UserReviews_Insert(bookstore, conn);
                        break;
                    default:
                        Console.WriteLine("Please make sure table name is correct & # of " +
                            "arguments passed match the required for the table");
                        break;
                }
                return flag;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public Boolean DELETE_FROM_TABLE(string stmt)
        {
            Boolean flag = false;
            var conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            DBDelete dbD = new DBDelete();
            try
            {
                flag = dbD.deleteRow(stmt, conn);
                return flag;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataSet SELECT_FROM_TABLE(string query)
        {
            var conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            DBSelect dbS = new DBSelect();
            DataSet ds = new DataSet();

            ds = dbS.selectDB(query, conn);

            if (conn.State == ConnectionState.Open)
                conn.Close();

            return ds;
        }
    }
}