/* **********************************************************************************
 * For use by students taking 60-422 (Fall, 2014) to work on assignments and project.
 * Permission required material. Contact: xyuan@uwindsor.ca 
 * **********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace BookStoreLIB
{
    public class DALReviewItem 
    {
       

        //public string BookID { get; set; } //which is isbn
        //public string BookTitle { get; set; }
        //public int OrderID { get; set; }
        //public int Rating { get; set; }
        //public string Comments { get; set; }
        public string ErrorMessage { set; get; }


        public bool Review(String isbn, 
             int orderID, int rating, String comments)
        {
            

            var conn = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO UserReviews VALUES "
                    + " ( @BookID, @Rating, @OrderID, @Comments)";
                cmd.Parameters.AddWithValue("@BookID", isbn);
                cmd.Parameters.AddWithValue("@Rating", rating);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@Comments", comments);
                conn.Open();
                cmd.ExecuteScalar();
                return true;
               
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
        
    }
}
