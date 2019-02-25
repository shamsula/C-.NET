using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
    [TestClass]
    public class TestRemoveBookItem
    {
        BookOrder bookOrder = new BookOrder();
        OrderItem orderItem;

        [TestMethod]
        public void TestMethod8()
        {
            string bookISBN = "21435362";
            string bookTitle = "Bryce's Book";
            double bookPrice = 25.99;
            int bookQuantity = 1;
            string description = "Bryce's Book";


            orderItem = new OrderItem(bookISBN, bookTitle, bookPrice, bookQuantity, description);

            // Method that is invoked by clicking the 'Add Book' button.
            bookOrder.AddItem(orderItem);

            bool expectedReturnWithBook = true;
            bool actualReturnWithBook = bookOrder.HasItem(orderItem);

            // Method that is invoked by clicking the 'Remove Book' button.
            bookOrder.RemoveItem(orderItem.BookID);

            bool expectedReturnWithoutBook = false;
            bool actualReturnWithoutBook = bookOrder.HasItem(orderItem);

            Assert.AreEqual(expectedReturnWithBook, actualReturnWithBook);
            Assert.AreEqual(expectedReturnWithoutBook, actualReturnWithoutBook);
        }
    }
}
