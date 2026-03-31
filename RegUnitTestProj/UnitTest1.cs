using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr_Kino;
using Pr_Kino.Pages;
using System;

namespace RegUnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Проверяет работу позитивных сценариев метода регистрации
        /// </summary>
        [TestMethod]
        public void RegSuccess()
        {
            var page = new RegPage();
            Assert.IsTrue(page.Registration("Vasilisa@gmai.com", "d7iKKV56", "d7iKKV56"));
        }


        /// <summary>
        /// Проверяет работу негативных сценариев метода регистрации
        /// </summary>
        [TestMethod]
        public void RegFail()
        {
            var page = new RegPage();
            Assert.IsFalse(page.Registration("Yli@gmai.com", "GwffgE", "GwffgE"));
            Assert.IsFalse(page.Registration("Testmail298@gmail.com", "12121212", "11111111"));
            Assert.IsFalse(page.Registration("", "", ""));
            Assert.IsFalse(page.Registration("' OR 1=1 –", "Vladlena@gmai.com'; DROP TABLE users;--", "Vladlena@gmai.com'; DROP TABLE users;--"));
            Assert.IsFalse(page.Registration("Bebabeba@gmail.com", "1234567", "1234567"));
            Assert.IsFalse(page.Registration("Bebabeba@gmail.com", 
                "tetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetoteto",
                "tetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetoteto"));


        }

    }
}
