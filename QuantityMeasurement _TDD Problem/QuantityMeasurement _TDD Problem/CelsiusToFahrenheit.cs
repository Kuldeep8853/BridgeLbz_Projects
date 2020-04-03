using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class CelsiusToFahrenheit
    {
        private readonly double fahrenheit = 33.8;
        public bool Equalate_Celsius_And_Fahreheit(double Celsius, double fh)
        {
            if (Celsius * this.fahrenheit == fh)
            {
                return true;
            }
            return false;
        }
    }
}
