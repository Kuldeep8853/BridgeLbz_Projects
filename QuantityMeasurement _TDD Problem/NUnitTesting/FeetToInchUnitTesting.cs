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
    }
}