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
            double actual = CabInvoiceGenerator.CalculateFare(0.1, 2);
            double expected = Math.Max(5, (0.1*10)+(2*1));
            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void Test_Ride_Fare2()
        {
            double actual = CabInvoiceGenerator.CalculateFare(0.5, 7);
            double expected = Math.Max(5, (0.5 * 10) + (7 * 1));
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_MultipleRide_Fare1()
        {
            Ride[] rides= new Ride[2];
            rides[0] = new Ride { Distance=2.0, Time=10 };
            rides[1] = new Ride { Distance = 10.0, Time = 50 };
            double actual = CabInvoiceGenerator.CalculateFare(rides);
            double expected = CabInvoiceGenerator.CalculateFare(2.0, 10) + CabInvoiceGenerator.CalculateFare(10.0, 50);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_MultipleRide_Fare2()
        {
            Ride[] rides = new Ride[2];
            rides[0] = new Ride { Distance = 0.5, Time = 5 };
            rides[1] = new Ride { Distance = 1.0, Time = 8 };
            double actual = CabInvoiceGenerator.CalculateFare(rides);
            double expected = CabInvoiceGenerator.CalculateFare(0.5, 5) + CabInvoiceGenerator.CalculateFare(1.0, 8);
            Assert.AreEqual(actual, expected);
        }
    }
}