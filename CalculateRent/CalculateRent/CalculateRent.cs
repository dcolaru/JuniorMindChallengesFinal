using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateRent
{
    [TestClass]
    public class CalculateRent
    {
        [TestMethod]
        public void OneDayDelay()
        {
            double rent = CalculateRentWithDelays(100, 1);
            Assert.AreEqual(102, rent);
        }
        [TestMethod]
        public void TwentyDaysDelay()
        {
            double rent = CalculateRentWithDelays(850, 20);
            Assert.AreEqual(1700, rent);
        }
        [TestMethod]
        public void ThirtyFiveDaysDelay()
        {
            double rent = CalculateRentWithDelays(850, 35);
            Assert.AreEqual(3825, rent);
        }
        public  double CalculateRentWithDelays(double rentAmount, double lateDays)

        {
            double[] rentPenalties = { 0.02 , 0.05, 0.10 };
            int[] delayedDays = { 1, 10, 11, 30,31, 40};

            if (lateDays <= delayedDays[1] && lateDays >= delayedDays[0])
            {
                rentAmount = ((rentAmount * rentPenalties[0]) * lateDays) + rentAmount;
            }
            if (lateDays <= delayedDays[3] && lateDays >= delayedDays[2])
            {
                rentAmount = ((rentAmount * rentPenalties[1]) * lateDays) + rentAmount;
            }
            if (lateDays <= delayedDays[5] && lateDays >= delayedDays[4])
            {
                rentAmount = ((rentAmount * rentPenalties[2]) * lateDays) + rentAmount;

            }
            return rentAmount;

        }
    }
}
