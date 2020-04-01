using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class FeetToInches
    {
        private readonly double Feet = 12;
        public bool Equalate_Inch_And_Feet(double inch, double feet)
        {
            if (inch == feet * this.Feet)
            {
                return true;
            }
            return false;
        }
    }
}
