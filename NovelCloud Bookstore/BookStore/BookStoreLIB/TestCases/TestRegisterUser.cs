using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Diagnostics;

/// <summary>
/// Public TEST class for User Registration. Test case creates a new user with set parameters, 
/// tests if the database matches the given values, checks success reply, and then deletes
/// the test user account.
/// </summary>
namespace BookStoreLIB
{
    [TestClass]
    public class TestRegisterUser
    {
        UserRegister userRegister = new UserRegister();
        UserData userData = new UserData();
        DataSet ds = new DataSet();
        DBQueries dbQ = new DBQueries();
        string inputName, inputPassword, inputPasswordV, inputFullName;

        [TestMethod]
        public void TestMethodRegisterUser ()
        {
            inputName = "TestUser";
            inputPassword = "ts0987";
            inputPasswordV = "ts0987";
            inputFullName = "TestUserFull";

            bool expectedRegister = true;
            bool expectedLogin = true;
            bool expectedDelete = true;

            var c = new SqlConnection(Properties.Settings.Default.dbConnectionString);

            bool actualRegister = userRegister.Register(inputName, inputPassword, inputPasswordV, inputFullName);
            bool actualLogin = userData.LogIn(inputName, inputPassword);
            int actualUserId = userData.UserID;

            ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM UserData WHERE UserName = 'TestUser'");
            int expectedUserId = Int32.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());

            Assert.AreEqual(expectedRegister, actualRegister);
            Assert.AreEqual(expectedLogin, actualLogin);
            Assert.AreEqual(expectedUserId, actualUserId);

            DBDelete dbD = new DBDelete();
            bool actualDelete = dbD.deleteRow("DELETE FROM UserData WHERE UserName = '" + inputName +"'", c);
            Assert.AreEqual(expectedDelete, actualDelete);
            c.Close();
        }
    }
}
