using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;

namespace NUnitTesting
{
    public class FeetToInchUnitTesting
    {

        [Test]
        public void Test_Equelity_Inch_Feet()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.CheckFeetValue(0), true);
        }

        [Test]
        public void Test_NullType_Refrence()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.Equals(null), false);
        }
        [Test]
        public void Test_Refrence_Type()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(feet.Equals(feet), true);
        }
        [Test]
        public void Test_Type()
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
    }
}