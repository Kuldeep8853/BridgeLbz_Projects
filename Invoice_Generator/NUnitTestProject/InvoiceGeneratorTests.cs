using Invoice_Generator;
using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    public class InvoiceGeneratorTests
    {
        [Test]
        public void Test_Ride_Fare1()
        {
            double actual = CabInvoiceGenerator.CalaculateFare(0.1, 2);
            double expected = Math.Max(5, (0.1*10)+(2*1));
            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void Test_Ride_Fare2()
        {
            double actual = CabInvoiceGenerator.CalaculateFare(0.5, 7);
            double expected = Math.Max(5, (0.5 * 10) + (7 * 1)); ;
            Assert.AreEqual(actual, expected);
        }
    }
}