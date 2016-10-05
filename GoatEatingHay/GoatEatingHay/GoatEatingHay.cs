using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoatEatingHay
{
    [TestClass]
    public class GoatEatingHay
    {
       
        [TestMethod]
        public void TotalHayEatenByTwentyGoatsInTenDays()
        {
          double totalKgOfHayEaten = CalculateKgsOfHayEatenByGoat(12, 15, 18, 20, 10);
            Assert.AreEqual(20, totalKgOfHayEaten);
        }
        [TestMethod]
        double CalculateKgsOfHayEatenByGoat(double nrOfGoats, double nrOfDays, double kgOfHayAday, double otherGoats, double otherNrOfDays)
        {

            double finalHay;
            double tempHay;

            tempHay = (otherNrOfDays * kgOfHayAday) / nrOfDays;

            finalHay = (otherGoats * tempHay) / nrOfGoats;

            return finalHay;

        }
    }
}
