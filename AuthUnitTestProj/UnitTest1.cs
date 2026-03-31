using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr_Kino;
using Pr_Kino.Pages;
using System;

namespace AuthUnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Проверяет общую работу метода авторизации
        /// </summary>
        [TestMethod]
        public void AuthTest()
        {
            var page = new LogPage();
            Assert.IsTrue(page.Auth("bebe", "baba"));
            Assert.IsFalse(page.Auth("user1", "12345"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));
        }

        /// <summary>
        /// Проверяет работу позитивных сценариев метода авторизации
        /// </summary>
        [TestMethod]
        public void AuthTestSuccess()
        {
            var page = new LogPage();
            Assert.IsTrue(page.Auth("bebe", "baba"));
            Assert.IsTrue(page.Auth("pepe", "shn"));
            Assert.IsTrue(page.Auth("GOREdov", "1467"));
            Assert.IsTrue(page.Auth("user", "12435"));
            Assert.IsTrue(page.Auth("Yli@gmai.com", "GwffgE"));
            Assert.IsTrue(page.Auth("Vladlena@gmai.com", "yntiRS"));
        }

        /// <summary>
        /// Проверяет работу негативных сценариев метода авторизации
        /// </summary>
        [TestMethod]
        public void AuthTestFail()
        {
            var page = new LogPage();
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth("Yli@gmai.com", "12345"));
            Assert.IsFalse(page.Auth("1234@gail.com", "GwffgE"));
            Assert.IsFalse(page.Auth("Yli@gmai.com", "YNTIRS"));
            Assert.IsFalse(page.Auth("' OR 1=1 –", "Vladlena@gmai.com'; DROP TABLE users;--"));
        }
    }
}
