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

        public void TestSimplify()
        {
            Fraction f = new Fraction(4, 4);

            Assert.AreEqual(f.upPart, 1);
            Assert.AreEqual(f.downPart, 1);
        }
    }
}
