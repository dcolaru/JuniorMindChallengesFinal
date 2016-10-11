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
