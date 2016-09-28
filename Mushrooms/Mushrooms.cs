using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]
        public void ThreeTimeMoreRed()
        {
            double redMushrooms = CalculateMushrooms(10, 3);
            Assert.AreEqual(7.5, redMushrooms);
        }

       double CalculateMushrooms(double totalMushrooms, double moreThenWhite)
        {

           return moreThenWhite * totalMushrooms / (moreThenWhite + 1);
          //  return Math.Round(redMushrooms,2);

        }
    }
}
