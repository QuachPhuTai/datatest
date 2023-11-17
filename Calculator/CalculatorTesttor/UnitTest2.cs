using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace CalculatorTesttor
{
    [TestClass]

    public class UnitTest2
    {
        [TestMethod]
        public void THVoNghiem()
        {
            SimpleEquation s = new SimpleEquation(0, 1);
            Assert.AreEqual("VN", s.SingleEquation());

        }
        [TestMethod]
        public void THVoSoNghiem()
        {
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());

        }
        [TestMethod]
        public void THMotNghiem()
        {
            SimpleEquation s = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", s.SingleEquation());

        }
    }
}
