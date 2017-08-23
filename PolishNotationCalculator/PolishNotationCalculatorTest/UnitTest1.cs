using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolishNotationCalculator;

namespace PolishNotationCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calc_10division2_5returned()
        {
            double expected = 5;
            double actual = PN.Calculate(@"/ 10 2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calc_3addition4_7returned()
        {
            double expected = 7;
            double actual = PN.Calculate(@"+ 3 4");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calc_5subtraction6multiplication7_minus7returned()
        {
            double expected = -7;
            double actual = PN.Calculate(@"* - 5 6 7");
            Assert.AreEqual(expected, actual);
        }
    }
}
