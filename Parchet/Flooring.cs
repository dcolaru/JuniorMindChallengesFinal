using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Flooring
    {
        [TestMethod]
        public void WoodNeededForFlooring()
        {
            double FlooringSurface = CalculateFlooring(20, 10, 2, 1);
            Assert.AreEqual(115, FlooringSurface);
        }

        double CalculateFlooring(double roomLength, double roomWidth, double woodLength, double woodWidth)
        {
            double woodSurface = woodLength * woodWidth;
            double roomSurface = roomLength * roomWidth;

            double FlooringNeeded = roomSurface / woodSurface + ((roomSurface / woodSurface) * 0.15);

            return FlooringNeeded;
        }
    }
}
