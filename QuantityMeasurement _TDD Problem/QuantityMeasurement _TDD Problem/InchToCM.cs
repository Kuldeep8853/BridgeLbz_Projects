using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class InchToCm
    {
        private readonly double Cm = 2.54;
        public bool Equalate_Inch_And_CM(double inch, double CM)
        {
            if (inch*this.Cm == CM)
            {
                return true;
            }
            return false;
        }
    }
}
