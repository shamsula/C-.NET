using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStoreLIB
{
    [TestClass]
    public class TestLogin
    {
        UserData userData = new UserData();
        string inputName, inputPassword;
        int actualUserId;

        [TestMethod]
        public void TestMethod1()
        {
            inputName = "shamsul";
            inputPassword = "ss8749";

            Boolean expectedReturn = true;
            int expectedUserId = 5;

            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);
        }

        [TestMethod]
        public void TestMethod2()
        {
            inputName = "";             // Example of blank username.
            inputPassword = "sc9464";

            int expectedUserId = 2;
            bool expectedReturn = false;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreNotEqual(expectedUserId, actualUserId);
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod3()
        {
            inputName = "chawl";        // Example of wrong username.
            inputPassword = "sc9464";

            int expectedUserId = 2;
            bool expectedReturn = false;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreNotEqual(expectedUserId, actualUserId);
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod4()
        {
            inputName = "stpierrb";
            inputPassword = "bp5723";   // Example of wrong password.

            int expectedUserId = 3;
            bool expectedReturn = false;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreNotEqual(expectedUserId, actualUserId);
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod5()
        {
            inputName = "shamsul";
            inputPassword = "ss8?49";   // Example of invalid password.

            int expectedUserId = 1;
            bool expectedReturn = false;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreNotEqual(expectedUserId, actualUserId);
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void TestMethod6()
        {
            inputName = "chawl113";
            inputPassword = "";         // Example of blank password.

            bool expectedReturn = false;
            int expectedUserId = 2;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreNotEqual(expectedUserId, actualUserId);
        }

        [TestMethod]
        public void TestMethod7()
        {
            inputName = "stpierrb";
            inputPassword = "bs572";         // Example of password that is too short.

            bool expectedReturn = false;
            int expectedUserId = 3;

            bool actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;

            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreNotEqual(expectedUserId, actualUserId);
        }

        
    }
}
