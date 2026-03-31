using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr_Kino;
using Pr_Kino.Pages;
using System;

namespace AuthUnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthTest()
        {
            var page = new LogPage();
            Assert.IsTrue(page.Auth("test", "test"));
            Assert.IsFalse(page.Auth("user1", "12345"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));
        }
    }
}
