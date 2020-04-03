using NUnit.Framework;
using QuantityMeasurement__TDD_Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    public class KgToGmUnitTesting
    {
        [Test]
        public void Test_Gm_Value()
        {
            Gram gram = new Gram(0);
            Assert.AreEqual(gram.CheckGmValue(0), true);
        }

        [Test]
        public void Test_Gm_Gm_Equality()
        {
            double gm = 1;
            Gram gram = new Gram(10);
            Assert.AreEqual(gram.CheckGmValue(gm), false);
        }

        [Test]
        public void Test_NullType_Refrence_Feet()
        {
            Gram gram = new Gram(10);
            Assert.AreEqual(gram.Equals(null), false);
        }

        [Test]
        public void Test_Refrence_TypeFeet()
        {
            Gram gram = new Gram(10);
            Assert.AreEqual(gram.Equals(gram), true);
        }
        [Test]
        public void Test_Kg_Gm_Equality()
        {
            double kg = 1;
            double gm = 1;
            KgToGm kgToGm = new KgToGm();
            Assert.AreEqual(kgToGm.Equalate_Kg_And_Gm(kg, gm), false);
        }

        [Test]
        public void Test_Kg_Gm_Equality1()
        {
            double kg = 1;
            double gm = 1000;
            KgToGm kgToGm = new KgToGm();
            Assert.AreEqual(kgToGm.Equalate_Kg_And_Gm(kg, gm), true);
        }

        [Test]
        public void Test_Gm_Kg_Equality()
        {
            double kg = 1;
            double gm = 2000;
            KgToGm kgToGm = new KgToGm();
            Assert.AreEqual(kgToGm.Equalate_Kg_And_Gm(kg, gm), false);
        }
    }
}
