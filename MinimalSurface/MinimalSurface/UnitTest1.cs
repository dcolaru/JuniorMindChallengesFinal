using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinimalSurface
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void IntCoordonatesTest()
        {
            double minimalSurface = CalculateSurface(1, 2, 3, 15, 9, 4);
            Assert.AreEqual(0.500000, minimalSurface);
        }

        [TestMethod]
        
        public void doubleCoordonatesTest()
        {
            double minimalSurface = CalculateSurface(1.234567, 2.234567, 3.234512, 15.234567, 9.234567, 4.234567);
            Assert.AreEqual(0.499835, minimalSurface);
        }
        [TestMethod]

        double CalculateSurface(double xa, double xb, double xc, double ya, double yb, double yc)
        {
            double A = (double)Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
            double B = (double)Math.Sqrt(Math.Pow((xc - xa), 2) + Math.Pow((yc - ya), 2));
            double C = (double)Math.Sqrt(Math.Pow((xc - xb), 2) + Math.Pow((yc - yb), 2));
            double p = (double)(A + B + C) / 2;//
            double HeronFormula = (double)Math.Sqrt((p * ((p - A) * (p - B) * (p - C))));
            return Math.Round(HeronFormula, 6);
        }
    }
}
