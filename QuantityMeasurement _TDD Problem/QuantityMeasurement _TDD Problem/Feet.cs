using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement__TDD_Problem
{
    public class Feet
    {
        int feet;
        public Feet(int feet)
        {
            this.feet = feet;
        }

        public override bool Equals(Object Obj)
        {
            if (Obj == null || !this.GetType().Equals(Obj.GetType()))
            {
                return false;
            }

            return true;
        }

        public bool CheckFeetValue(int feet)
        {
            if (this.feet == feet)
                return true;
            return false;
        }
    }
}
