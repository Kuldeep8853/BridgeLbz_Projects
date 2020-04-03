using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class InchToCentiMeterUnitTest
    {
        [Test]
        public void Test_Inch_CM_Equality()
        {
            double Inch = 1;
            double Cm = 1;
            InchToCm inchToCm = new InchToCm();
            Assert.AreEqual(inchToCm.Equalate_Inch_And_CM(Inch, Cm), false);
        }

        [Test]
        public void Test_Inch_CM_Equality1()
        {
            double Inch = 100;
            double Cm = 254;
            InchToCm inchToCm = new InchToCm();
            Assert.AreEqual(inchToCm.Equalate_Inch_And_CM(Inch, Cm), true);
        }

        [Test]
        public void Test_CM_Feet_Equality()
        {
            double Inch = 1000;
            double Cm = 2540;
            InchToCm inchToCm = new InchToCm();
            Assert.AreEqual(inchToCm.Equalate_Inch_And_CM(Inch, Cm), true);
        }
    }
}
