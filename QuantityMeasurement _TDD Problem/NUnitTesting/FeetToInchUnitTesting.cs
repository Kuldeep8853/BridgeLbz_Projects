using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;

namespace NUnitTesting
{
    public class FeetToInchUnitTesting
    {

        [Test]
        public void Test_Equelity_Feet()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.CheckFeetValue(0), true);
        }

        [Test]
        public void Test_NullType_Refrence_Feet()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.Equals(null), false);
        }

        [Test]
        public void Test_Refrence_TypeFeet()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.Equals(feet), true);
        }

        [Test]
        public void Test_Feet_Type()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.Equals(feet), true);
        }

        [Test]
        public void Test_Feet_Value()
        {
            Feet feet = new Feet(10);
            Assert.AreEqual(feet.CheckFeetValue(10), true);
        }

        [Test]
        public void Test_Feet_Value1()
        {
            Feet feet = new Feet(5.5);
            Assert.AreEqual(feet.CheckFeetValue(5.5), true);
        }

        [Test]
        public void Test_Equelity_Inch()
        {
            Inches inch = new Inches(0);
            Assert.AreEqual(inch.CheckInchValue(0), true);
        }

        [Test]
        public void Test_NullType_Refrence_Inch()
        {
            Inches inch = new Inches(0);
            Assert.AreEqual(inch.Equals(null), false);
        }
        [Test]
        public void Test_Refrence_TypeInch()
        {
            Inches inch = new Inches(0);
            Assert.AreEqual(inch.Equals(inch), true);
        }
        [Test]
        public void Test_Inch_Type()
        {
            Inches inch = new Inches(0);
            Assert.AreEqual(inch.Equals(inch), true);
        }

        [Test]
        public void Test_Inch_Value()
        {
            Inches inch = new Inches(10);
            Assert.AreEqual(inch.CheckInchValue(10), true);
        }

        [Test]
        public void Test_Inch_Value1()
        {
            Inches inch = new Inches(5.5);
            Assert.AreEqual(inch.CheckInchValue(5.5), true);
        }

        [Test]
        public void Test_Inch_Feet_Equality()
        {
            double inch = 0;
            double feet = 0;
            FeetToInches feetToInche = new FeetToInches();
            Assert.AreEqual(feetToInche.Equalate_Inch_And_Feet(inch, feet), true);
        }

        [Test]
        public void Test_Inch_Feet_Equality1()
        {
            double inch = 1;
            double feet = 1;
            FeetToInches feetToInche = new FeetToInches();
            Assert.AreEqual(feetToInche.Equalate_Inch_And_Feet(inch, feet), false);
        }

        [Test]
        public void Test_Inch_Feet_Equality2()
        {
            double inch = 12;
            double feet = 1;
            FeetToInches feetToInche = new FeetToInches();
            Assert.AreEqual(feetToInche.Equalate_Inch_And_Feet(inch, feet), true);
        }
    }
}