using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class Gram
    {
        public double gm { get; set; }
        public Gram(double dm)
        {
            this.gm = gm;
        }

        public bool CheckGmValue(double Gm)
        {
            if (this.gm == Gm)
                return true;
            return false;
        }
    }
}
