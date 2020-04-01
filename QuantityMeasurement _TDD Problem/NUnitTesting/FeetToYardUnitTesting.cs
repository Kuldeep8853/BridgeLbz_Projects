using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    public class FeetToYardUnitTesting
    {
        [Test]
        public void Test_Yard_Feet_Equality()
        {
            double yard = 1;
            double feet = 1;
            FeetToYard feetToYard = new FeetToYard();
            Assert.AreEqual(feetToYard.Equalate_Yard_And_Feet(yard, feet), false);
        }

        [Test]
        public void Test_Yard_Feet_Equality1()
        {
            double yard = 1;
            double feet = 3;
            FeetToYard feetToYard = new FeetToYard();
            Assert.AreEqual(feetToYard.Equalate_Yard_And_Feet(yard, feet), true);
        }

        [Test]
        public void Test_Yard_Inch_Equality()
        {
            double yard = 1;
            double inch = 36;
            FeetToYard feetToYard = new FeetToYard();
            Assert.AreEqual(feetToYard.Equalate_Yard_And_Inch(yard, inch), true);
        }
    }
}
