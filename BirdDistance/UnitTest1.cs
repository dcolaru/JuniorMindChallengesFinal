using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdDistance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BirdDistanceBetweenTwoTrains()
        {
            double BirdDistance = CalculateBirdDistance(100);
            Assert.AreEqual(50, BirdDistance);
        }
        double CalculateBirdDistance(double Totaldistance)
        {
            return Totaldistance / 2;
        }
    }
}
