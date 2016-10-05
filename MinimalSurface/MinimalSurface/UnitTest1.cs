using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinimalSurface
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void doubleCoordonatesTest()
        {
            double minimalSurface = CalculateSurface(1, 2, 3, 15, 9, 4);
            Assert.AreEqual(32.5, minimalSurface);
        }

        [TestMethod]
        
        public void doubleCoordonatesTest2()
        {
            double minimalSurface = CalculateSurface(1.234567, 2.234567, 3.234512, 15.234567, 9.234567, 4.234567);
            Assert.AreEqual(32.499977, minimalSurface);
        }
        [TestMethod]

        double CalculateSurface(double xa, double xb, double xc, double ya, double yb, double yc)
        {
            double A = CalculateCoordonates(xa, xb,ya, yb);
            double B = CalculateCoordonates(xa, xc, ya, yc);
            double C = CalculateCoordonates(xc, xb, yc, ya);
            double p = (A + B + C) / 2;
            double minimumSurface = HeronSurface(p, A, B, C);
            return Math.Round(minimumSurface, 6);
        }
         double CalculateCoordonates(double xb, double xa, double ya, double yb)
        {

            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));

        }
         double HeronSurface(double _p, double _A, double _B, double _C)
        {

            return Math.Sqrt((_p * ((_p - _A) * (_p - _B) * (_p - _C))));

        }

    }
}
