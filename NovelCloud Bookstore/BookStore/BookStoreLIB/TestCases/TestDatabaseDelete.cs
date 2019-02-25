using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookStoreLIB
{
    [TestClass]
    public class TestDatabaseDelete
    {
        DBQueries dbQ = new DBQueries();
        DataSet ds = new DataSet();
        DBGetID dbG = new DBGetID();
        [TestMethod]
        public void TestMethodDeleteFromSupplier()
        {
            var c = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            Boolean expectedInsert = true;
            Boolean expectedDelete = true;
            string expectedName = "Google";
            int expectedSupplierID = dbG.GetID("Supplier", c);

            List<object> bookstore = new List<object>(
                new object[] { expectedName }
                );

            Boolean actualInsert = dbQ.INSERT_INTO_TABLE("Supplier", bookstore);
            Assert.AreEqual(expectedInsert, actualInsert);

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM Supplier WHERE Name = '" + expectedName + "'");
            int actualSupplierID = Int32.Parse(ds.Tables[0].Rows[0]["SupplierId"].ToString());
            string actualName = ds.Tables[0].Rows[0]["Name"].ToString();

            Assert.AreEqual(expectedSupplierID, actualSupplierID);
            Assert.AreEqual(expectedName, actualName);

            //Delete from Database
            Boolean actualDelete = dbQ.DELETE_FROM_TABLE("DELETE FROM Supplier WHERE Name = '" + expectedName + "'");
            Assert.AreEqual(expectedDelete, actualDelete);

            Boolean expectedFinalDeleteReturn = true;
            Boolean finalDeleteReturn = false;
            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM Supplier WHERE Name = '" + expectedName + "'");

            if (ds.Tables[0].Rows.Count == 0)
                finalDeleteReturn = true;

            Assert.AreEqual(expectedFinalDeleteReturn, finalDeleteReturn);
            c.Close();
        }
        [TestMethod]
        public void TestMethodDeleteFromUserReviews()
        {
            var c = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            Boolean expectedInsert = true;
            Boolean expectedDelete = true;
            string expectedISBN = "1285096339";
            int expectedOrderID = 10;
            int expectedRating = 5;
            string expectedComments = "Great read";

            List<object> bookstore = new List<object>(
                new object[] { expectedISBN, expectedOrderID, expectedRating, expectedComments }
                );

            Boolean actualInsert = dbQ.INSERT_INTO_TABLE("UserReviews", bookstore);
            Assert.AreEqual(expectedInsert, actualInsert);

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM UserReviews WHERE ISBN = '" + expectedISBN + "'");
            int actualOrderID = Int32.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
            int actualRating = Int32.Parse(ds.Tables[0].Rows[0]["Rating"].ToString());
            string actualISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();
            string actualComments = ds.Tables[0].Rows[0]["Comments"].ToString();

            Assert.AreEqual(expectedOrderID, actualOrderID);
            Assert.AreEqual(expectedRating, actualRating);
            Assert.AreEqual(expectedISBN, actualISBN);
            Assert.AreEqual(expectedComments, actualComments);

            //Delete from Database
            Boolean actualDelete = dbQ.DELETE_FROM_TABLE("DELETE FROM UserReviews WHERE ISBN = '" + expectedISBN + "'");
            Assert.AreEqual(expectedDelete, actualDelete);

            Boolean expectedFinalDeleteReturn = true;
            Boolean finalDeleteReturn = false;
            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM UserReviews WHERE ISBN = '" + expectedISBN + "'");

            if (ds.Tables[0].Rows.Count == 0)
                finalDeleteReturn = true;

            Assert.AreEqual(expectedFinalDeleteReturn, finalDeleteReturn);
            c.Close();
        }
    }
}
