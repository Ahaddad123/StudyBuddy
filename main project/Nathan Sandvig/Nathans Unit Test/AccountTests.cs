using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.DataAccess;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CheckCreateAccount()
        {
            Account account = new Account("josh123", "joshpassword", 1);
            account.CheckCreateAccount("josh123", "joshpassword");
            Assert.AreEqual(false, account.CheckCreateAccount("josh123", "joshpassword"));

        }

        public void CheckLogin() {
            Account account = new Account("josh123", "joshpassword", 1);
            account.Login("nathan123", "nathanpassword");
            Assert.AreEqual(false, account.Login("nathan123", "nathanpassword"));
        }

        public void CheckAddCourse() {
            Account account = new Account("josh123", "joshpassword", 1);
            account.addCourse();
            Assert.AreEqual(false, account.addCourse());
        }

        public void CheckRemoveCourse() {
            Account account = new Account("josh123", "joshpassword", 1);
            account.removeCourse("math");
            Assert.AreEqual(false, account.removeCourse("math"));
        }
    }
}
