using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;

namespace NUnitTesting
{
    class CelsiusToFahrenheitUnitTesting
    {
        [Test]
        public void Test_Temperature_Value()
        {
            Temperature temperature = new Temperature(0);
            Assert.AreEqual(temperature.CheckGmValue(0), true);
        }

        [Test]
        public void Test_Temp_Equality()
        {
            Temperature temperature = new Temperature(10);
            Assert.AreEqual(temperature.CheckGmValue(10), true);
        }

        [Test]
        public void Test_NullType_Refrence_Temprature()
        {
            Temperature temperature = new Temperature(10);
            Assert.AreEqual(temperature.Equals(null), false);
        }

        [Test]
        public void Test_Refrence_TypeTemprature()
        {
            Temperature temperature = new Temperature(10);
            Assert.AreEqual(temperature.Equals(temperature), true);
        }
        [Test]
        public void Test_Celsius_Temp_Equality()
        {
            double Celsisu = 1;
            double Fahrenheit = 1;
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.AreEqual(celsiusToFahrenheit.Equalate_Celsius_And_Fahreheit(Celsisu, Fahrenheit), false);
        }

        [Test]
        public void Test_Celsius_Temp_Equality1()
        {
            double Celsisu = 10;
            double Fahrenheit = 338;
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.AreEqual(celsiusToFahrenheit.Equalate_Celsius_And_Fahreheit(Celsisu, Fahrenheit), true);
        }

        [Test]
        public void Test_Fahrenheit_Celsisu_Equality()
        {
            double Celsisu = 1;
            double Fahrenheit = 338;
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.AreEqual(celsiusToFahrenheit.Equalate_Celsius_And_Fahreheit(Celsisu, Fahrenheit), false);
        }
    }
}
