using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB.TestCases
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestAddReview
    {
        [TestMethod]
        public void TestMethodAddReview()   //checks if bookISBN is NULL (it cannot be null)
        {      
            DALReviewItem revItem = new DALReviewItem();
            

            string bookISBN = ""; //"1617290890";
            int orderID = 4;
            int rating = 1;
            string comments = "good book";

            
            
            

            bool expectedReturnWithBook = false;

           
            bool actualReturnWithBook = revItem.Review(bookISBN, orderID, rating, comments);

            Assert.AreEqual(expectedReturnWithBook, actualReturnWithBook);
        }
    }
}
