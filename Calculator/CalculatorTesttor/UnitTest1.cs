using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTesttor
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        public void Setup()
        {
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperation()
        {
            int expected = 15;
            int actual = cal.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperation()
        {
            int expected = 5;
            int actual = cal.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMulOperation()
        {
            int expected = 50;
            int actual = cal.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivideOperation()
        {
            int expected = 2;
            int actual = cal.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            Calculation c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
