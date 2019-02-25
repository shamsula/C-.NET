using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace BookStoreLIB
    {
        [TestClass]
        public class TestAddBook
        {
            [TestMethod]
            public void TestMethodAddBook()
            {
                BookOrder bookOrder = new BookOrder();
                OrderItem orderItem;

                string bookISBN = "8398230985";
                string bookTitle = "Agile Software Development";
                double bookPrice = 50.40;
                int bookQuantity = 1;
                string description = "sample description";

                // Creating a sample book entry 
                orderItem = new OrderItem(bookISBN, bookTitle, bookPrice, bookQuantity, description);
                bookOrder.AddItem(orderItem);

                bool expectedReturnWithBook = true;

                //Checking if newly created item exists in orderItem
                bool actualReturnWithBook = bookOrder.HasItem(orderItem);

                Assert.AreEqual(expectedReturnWithBook, actualReturnWithBook);
            }
        }
    }


}
