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
        public  double CalculateRentWithDelays(double _rent, double lateDays)

        {
            if (lateDays <= 10 && lateDays >= 1)
            {
                _rent = ((_rent * 0.02) * lateDays) + _rent;
            }
            if (lateDays <= 30 && lateDays >= 11)
            {
                _rent = ((_rent * 0.05) * lateDays) + _rent;
            }
            if (lateDays <= 40 && lateDays >= 31)
            {
                _rent = ((_rent * 0.10) * lateDays) + _rent;

            }
            return _rent;

        }
    }
}
