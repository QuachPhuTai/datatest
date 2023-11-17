using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTesttor
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString()) ;
            int b = int.Parse(TestContext.DataRow[1].ToString());
            Calculation cal = new Calculation(a, b);
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            int actual = cal.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation cl = new Calculation(a, b);
            string o = TestContext.DataRow[2].ToString();
            int actual = cl.Execute(o);
            Assert.AreEqual(expected, actual);
        }
    }
}
