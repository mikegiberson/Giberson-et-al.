using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;

namespace UnitTestProject
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void LoginTest1()
        {
            User user = new User();
            user.Login("schan", "mims");
            Assert.IsNotNull(User.ID);
            Assert.IsNotNull(user.Role);
            Assert.IsNotNull(user.FirstName);
            Assert.IsNotNull(user.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
         "Empty UserName.")]
        public void LoginTest2()
        {
            User user = new User();
            user.Login("", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
         "Empty Password.")]
        public void LoginTest3()
        {
            User user = new User();
            user.Login("schan", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Password was incorrect.")]
        public void LoginTest4()
        {
            User user = new User();
            user.Login("schan", "jake");
            Assert.IsNull(User.ID);
            Assert.IsNull(user.Role);
            Assert.IsNull(user.FirstName);
            Assert.IsNull(user.LastName);
        }
    }
}
