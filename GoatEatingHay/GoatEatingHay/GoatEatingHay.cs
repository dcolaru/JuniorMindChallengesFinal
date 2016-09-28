using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoatEatingHay
{
    [TestClass]
    public class GoatEatingHay
    {
        [TestMethod]
        public void TotalHayEatenByOneGoatInOneDay()
        {
            int totalKgOfHayEaten = CalculateKgsOfHayEatenByGoat(1, 1, 10);
            Assert.AreEqual(10, totalKgOfHayEaten);
        }
        [TestMethod]
        public void TotalHayEatenBySevenGoatsInThereeDays()
        {
            int totalKgOfHayEaten = CalculateKgsOfHayEatenByGoat(7, 3, 10);
            Assert.AreEqual(210, totalKgOfHayEaten);
        }
        [TestMethod]
        int CalculateKgsOfHayEatenByGoat( int nrOfGoats, int nrOfDays, int kgOfHayAday)
        {
            
            int totalKgOfHayEaten;
            totalKgOfHayEaten = nrOfGoats * nrOfDays * kgOfHayAday;
            return totalKgOfHayEaten;

        }
    }
}
