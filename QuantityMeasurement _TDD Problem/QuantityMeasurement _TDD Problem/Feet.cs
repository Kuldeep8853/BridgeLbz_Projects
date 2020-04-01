using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class Feet
    {
        public double feet { get; set; }
        public Feet(double feet)
        {
            this.feet = feet;
        }

        public bool CheckFeetValue(double feet)
        {
            if (this.feet == feet)
                return true;
            return false;
        }

        public override bool Equals(Object Obj)
        {
            if (Obj == null || !this.GetType().Equals(Obj.GetType()))
            {
                return false;
            }

            return true;
        }
    }
}
