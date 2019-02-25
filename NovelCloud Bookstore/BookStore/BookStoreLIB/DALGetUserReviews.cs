using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace BookStoreLIB
{
    public class DALGetUserReviews
    {
        
            SqlConnection conn;
            DataTable dsReviews;
            public DALGetUserReviews()
            {
                conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            }
            public DataTable GetUserReviews(String isbn)
            {
                try
                {
                    dsReviews = new DataTable();
                String strSQL2 = "select t1.ISBN, t2.Title, t1.Rating, t1.Comments from UserReviews " +
                    "t1 INNER JOIN BookData t2  ON t1.ISBN = t2.ISBN Where t1.ISBN = '"+ isbn+"'";
                    SqlCommand cmdSelReviews = new SqlCommand(strSQL2, conn);
                    //dsReviews = new DataSet("Reviews");
                    SqlDataAdapter daReviews = new SqlDataAdapter(cmdSelReviews);
                    daReviews.Fill(dsReviews);                  //Get Reviews info
                    
                }
                catch (Exception ex) { Debug.WriteLine(ex.Message); return null; }
                return dsReviews;
            }
        

    }
}
