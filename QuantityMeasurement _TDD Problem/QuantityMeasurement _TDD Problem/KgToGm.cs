using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class KgToGm
    {
        private readonly double gm = 1000;
        public bool Equalate_Kg_And_Gm(double Kg, double Gm)
        {
            if (Kg * this.gm == Gm)
            {
                return true;
            }
            return false;
        }
    }
}
