using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGradeBoundaries()
        {
            var page = new MainWindow();

            Assert.AreEqual("5 (отлично)", page.Calculate(22, 34, 20)); // 76
            Assert.AreEqual("4 (хорошо)", page.Calculate(10, 20, 10));  // 40
            Assert.AreEqual("3 (удовл.)", page.Calculate(5, 10, 1));    // 16
            Assert.AreEqual("2 (неуд.)", page.Calculate(0, 0, 0));      // 0
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestInvalidInput()
        {
            var page = new MainWindow();

            _ = int.Parse("abc");
        }

        [TestMethod]
        public void TestScoreOutOfRange()
        {
            var page = new MainWindow();

            string result = page.Calculate(23, 40, 25);
            Assert.AreEqual("Ошибка: превышены допустимые значения!", result);
        }
    }
}


