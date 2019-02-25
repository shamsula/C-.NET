using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookStoreLIB
{
    [TestClass]
    public class TestDatabaseSelect
    {
        DBQueries dbQ = new DBQueries();
        DataSet ds = new DataSet();
        [TestMethod]
        public void TestDatabaseSelectFromBookData()
        {
            int expectedCategoryID = 2;
            int expectedSupplierID = 1;
            int expectedYear = 2002;
            int expectedEdition = 1;
            double expectedPrice = 70.40;
            string expectedISBN = "0135974445";
            string expectedTitle = "Agile Software Development, Principles, Patterns, and Practices";
            string expectedAuthor = "Robert C. Martin";
            string expectedPublisher = "Pearson";
            string expectedDescription = "Written by a software developer for software developers, this book is a unique collection of the latest software development methods. The author includes OOD, UML, Design Patterns, Agile and XP methods with a detailed description of a complete software design for reusable programs in C++ and Java.";
            
            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM BookData WHERE ISBN = '"+ expectedISBN + "'");
            int actualCategoryID = Int32.Parse(ds.Tables[0].Rows[0]["CategoryID"].ToString());
            int actualSupplierID = Int32.Parse(ds.Tables[0].Rows[0]["SupplierId"].ToString());
            int actualYear = Int32.Parse(ds.Tables[0].Rows[0]["Year"].ToString());
            int actualEdition = Int32.Parse(ds.Tables[0].Rows[0]["Edition"].ToString());
            double actualPrice = Double.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
            string actualISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();
            string actualTitle = ds.Tables[0].Rows[0]["Title"].ToString();
            string actualAuthor = ds.Tables[0].Rows[0]["Author"].ToString();
            string actualPublisher = ds.Tables[0].Rows[0]["Publisher"].ToString();
            string actualDescription = ds.Tables[0].Rows[0]["Description"].ToString();

            Assert.AreEqual(expectedCategoryID, actualCategoryID);
            Assert.AreEqual(expectedSupplierID, actualSupplierID);
            Assert.AreEqual(expectedYear, actualYear);
            Assert.AreEqual(expectedEdition, actualEdition);
            Assert.AreEqual(expectedPrice, actualPrice);
            Assert.AreEqual(expectedISBN, actualISBN);
            Assert.AreEqual(expectedTitle, actualTitle);
            Assert.AreEqual(expectedAuthor, actualAuthor);
            Assert.AreEqual(expectedPublisher, actualPublisher);
            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [TestMethod]
        public void TestDatabaseSelectFromOrderItem()
        {
            int expectedOrderID = 4;
            int expectedQuantity = 1;
            string expectedISBN = "1617290890";

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM OrderItem WHERE ISBN = '" + expectedISBN + "' AND OrderID = '" + expectedOrderID + "'");
            int actualOrderID = Int32.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
            int actualQuantity = Int32.Parse(ds.Tables[0].Rows[0]["Quantity"].ToString());
            string actualISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();

            Assert.AreEqual(expectedOrderID, actualOrderID);
            Assert.AreEqual(expectedQuantity, actualQuantity);
            Assert.AreEqual(expectedISBN, actualISBN);
        }
    }
}
