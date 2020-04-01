using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class FeetToYard
    {
        private readonly double Feet = 3;
        private readonly double Inch = 36;
        public bool Equalate_Yard_And_Feet(double yard, double feet)
        {
            if (feet == yard * this.Feet)
            {
                return true;
            }
            return false;
        }

        public bool Equalate_Yard_And_Inch(double yard, double inch)
        {
            if (inch == yard * this.Inch)
            {
                return true;
            }
            return false;
        }
    }
}
