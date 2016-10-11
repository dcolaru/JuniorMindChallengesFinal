using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
    [TestClass]
    public class FarmersLand
    {
        [TestMethod]
        public void FirstLandSurface()
        {
            double land = CalculateLand(770000, 230);
            Assert.AreEqual(592900, land);
        }
        public static double CalculateLand(double totalAria, double addedWidth)
        {
            double surfaceLength = addedWidth / 1000 - (totalAria / 1000) / (totalAria / 1000);

            double firstLandAria = Math.Pow((surfaceLength * 1000), 2);

            return firstLandAria;

        }
    }
}
