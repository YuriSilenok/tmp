using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected_result = 1.0;
            double actual_result = M.Sum(0.9, 0.1);
            Assert.AreEqual(expected_result, actual_result, "Математика сошла с ума");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected_result = 1.0;
            double actual_result = M.Sum(0.1, 0.9);
            Assert.AreEqual(expected_result, actual_result, "Математика сошла с ума");
        }
    }
}
