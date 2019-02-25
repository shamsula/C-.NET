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
    class DBSelect
    {
        public DataSet selectDB(string stmt, SqlConnection conn)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("Results");
            da.SelectCommand = new SqlCommand(stmt, conn);
            da.Fill(ds, "Results");
            conn.Close();

            return ds;
        }
    }
}
