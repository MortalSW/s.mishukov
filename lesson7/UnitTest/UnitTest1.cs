using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson7homework;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);

            f1 = f1 + f2;

            Assert.AreEqual(f1.upPart, 1);
            Assert.AreEqual(f1.upPart, 1);
        }

        [TestMethod]
        public void TestSimplify()
        {
            Fraction f = new Fraction(4, 4);

            Assert.AreEqual(f.upPart, 1);
            Assert.AreEqual(f.downPart, 1);
        }

        [TestMethod]
      
        public void TestZeroDownPart1()
        {
            try
            {
                Fraction f = new Fraction(1, 0);
                Assert.Fail();
            }
            catch (DivideByZeroException ex) { }
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestZeroDownPart2()
        {
            Fraction f = new Fraction(1, 0);        
        }
    }
}
