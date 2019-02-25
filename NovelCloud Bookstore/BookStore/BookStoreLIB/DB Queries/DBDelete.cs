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
    class DBDelete
    {
        public Boolean deleteRow(string stmt, SqlConnection conn)
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(stmt, conn))
            {
                int result = command.ExecuteNonQuery();
                conn.Close();
                return !(result < 0);
            }
        }
    }
}
