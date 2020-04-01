using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class Inches
    {
        public double Inch { get; set; }

        public Inches(double inch)
        {
            this.Inch = inch;
        }

        public bool CheckInchValue(double value)
        {
            if (this.Inch == value)
                return true;
            return false;
        }
    }
}
