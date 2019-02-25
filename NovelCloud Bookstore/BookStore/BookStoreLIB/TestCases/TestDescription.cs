using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB.TestCases
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace BookStoreLIB
    {
        [TestClass]
        public class TestDescription
        {
            [TestMethod]
            public void TestBookDescription()
            {

            OrderItem orderDescriptionItem;

                try
                {
                    orderDescriptionItem = new OrderItem("8398230985", "Agile Software Development", 50.40, 1, "");
                }
                catch (ArgumentOutOfRangeException ae)
                {
                    Assert.AreEqual("Description parameter cannot be null or empty.", ae.Message);
                }

            }
    }
}
}
