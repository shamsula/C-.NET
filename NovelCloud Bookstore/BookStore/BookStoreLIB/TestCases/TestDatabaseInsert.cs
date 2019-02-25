using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreLIB
{
    [TestClass]
    public class TestDatabaseInsert
    {
        DBQueries dbQ = new DBQueries();
        DBGetID dbG = new DBGetID();
        DataSet ds = new DataSet();

        [TestMethod]
        public void TestMethodInsertIntoUserData()
        {
            Boolean expectedInsert = true;
            Boolean expectedDelete = true;
            string expectedUserName = "john321";
            string expectedPassword = "sample";
            string expectedFullName = "John Sampleson";
            string expectedType = "SA";

            List<object> bookstore = new List<object>(
                new object[] { expectedUserName, expectedPassword, expectedType,  0, expectedFullName}
                );

            Boolean actualInsert = dbQ.INSERT_INTO_TABLE("UserData", bookstore);    //Insert method for database
            Assert.AreEqual(expectedInsert, actualInsert);

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM UserData WHERE UserName = '"+ expectedUserName + "'");
            string actualUserName = ds.Tables[0].Rows[0]["UserName"].ToString();
            string actualPassword = ds.Tables[0].Rows[0]["Password"].ToString();
            string actualFullName = ds.Tables[0].Rows[0]["FullName"].ToString();
            string actualType = ds.Tables[0].Rows[0]["Type"].ToString();

            Assert.AreEqual(expectedUserName, actualUserName);
            Assert.AreEqual(expectedPassword, actualPassword);
            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedType, actualType);

            Boolean actualDelete = dbQ.DELETE_FROM_TABLE("DELETE FROM UserData WHERE UserName = 'john321'");

            Assert.AreEqual(expectedDelete, actualDelete);
        }
        [TestMethod]
        public void TestMethodInsertIntoCategory()
        {
            var c = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            Boolean expectedInsert = true;
            Boolean expectedDelete = true;
            int expectedCategoryID = dbG.GetID("Category", c);
            string expectedName = "New Fall Books 2017 Edition";
            string expectedDescription = "sample";

            List<object> bookstore = new List<object>(
                new object[] { expectedName, expectedDescription }
                );

            Boolean actualInsert = dbQ.INSERT_INTO_TABLE("Category", bookstore);
            Assert.AreEqual(expectedInsert, actualInsert);

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM Category WHERE Name = '" + expectedName + "'");
            string actualName = ds.Tables[0].Rows[0]["Name"].ToString();
            string actualDescription = ds.Tables[0].Rows[0]["Description"].ToString();
            int actualCategoryID = Int32.Parse(ds.Tables[0].Rows[0]["CategoryID"].ToString());

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDescription, actualDescription);
            Assert.AreEqual(expectedCategoryID, actualCategoryID);

            Boolean actualDelete = dbQ.DELETE_FROM_TABLE("DELETE FROM Category WHERE Name = '"+ expectedName +"'");

            Assert.AreEqual(expectedDelete, actualDelete);
            c.Close();
        }
    }
}
