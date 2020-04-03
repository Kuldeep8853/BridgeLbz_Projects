using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class Temperature
    {
        public double Celsius { get; set; }
        public Temperature(double Celsius)
        {
            this.Celsius = Celsius;
        }

        public bool CheckGmValue(double celsius)
        {
            if (this.Celsius == celsius)
                return true;
            return false;
        }
    }
}
