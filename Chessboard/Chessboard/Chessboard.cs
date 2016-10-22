using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chessboard
{
    [TestClass]
    public class Chessboard
    {
        [TestMethod]
        public void TestMethod1()
        {
            double squares = CheckBoard(8);
            Assert.AreEqual(204, squares);
        }
        double CheckBoard(int dimension)
        {
            double numberOfSquares = 0;
            for (int i = 0; i <= dimension; dimension--)
            {
                numberOfSquares += Math.Pow(dimension, 2);
            }
            return numberOfSquares;
        }
    }
}
