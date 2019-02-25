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
    class DBGetID
    {
        public int GetID(string table, SqlConnection conn)
        {
            int id;
            switch (table)
            {
                case "AdminUsers":
                    id = getID("UserID", "AdminUsers", conn);
                    break;
                case "Category":
                    id = getID("CategoryID", "Category", conn);
                    break;
                case "Supplier":
                    id = getID("SupplierId", "Supplier", conn);
                    break;
                case "UserData":
                    id = getID("UserID", "UserData", conn);
                    break;
                default:
                    id = -1;
                    Console.WriteLine("Please make sure table name is correct.");
                    break;
            }
            return id;
        }
        private int getID(string colid, string table, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX("+colid+") FROM "+ table;
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            if (id > 0) return id + 1;
            else return -1;
        }
    }
}
