using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CityHallSquare
{
    [TestClass]
    public class CityHallSquare
    {
        [TestMethod]
        public void SixBySixSquareWithFourByFourRock()
        {
            double nrOfRocks =  (int)CalculateNrOfRockForASquare(6,6,4);
            Assert.AreEqual(4, nrOfRocks);

        }
        [TestMethod]
        public void TenByTenSquareWithTwoByTwoRock()
        {
            double nrOfRocks = CalculateNrOfRockForASquare(10, 10, 2);
            Assert.AreEqual(25, nrOfRocks);

        }
        [TestMethod]
        public void TenByTenSquareWithZeroDotTwoByZeroDotTwoRock()
        {
            double nrOfRocks = CalculateNrOfRockForASquare(10, 10, 0.2d);
            Assert.AreEqual(2502d, nrOfRocks);

        }

        [TestMethod]
        double CalculateNrOfRockForASquare(double squareLength, double squareWidth, double rockSize)
        {
            double nrOfRocks = ((squareLength * squareWidth) / (rockSize * rockSize));

            if (squareLength % rockSize > 0)
            {
                nrOfRocks += 1;
            }

            if (squareWidth % rockSize > 0)
            {
                nrOfRocks += 1;
            }
            return nrOfRocks;
        }


    }
}
