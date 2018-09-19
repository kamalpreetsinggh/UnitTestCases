using System;
using NUnit.Framework;
using ProductNUnitApplication.Repository;

namespace ProductNUnitApplication.tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            Assert.That(Calculate.CalculateRegularDiscount(100)==90.0);
        }

        [Test]
        public void Test2()
        {
            Assert.That(Calculate.CalculateRegularDiscount(100) != 80.0);
        }

        [Test]
        public void Test3()
        {
            Assert.That(Calculate.CalculatePremiumDiscount(100) == 80.0);
        }

        [Test]
        public void Test44()
        {
            Assert.That(Calculate.CalculatePremiumDiscount(100) != 90.0);
        }
    }
}
