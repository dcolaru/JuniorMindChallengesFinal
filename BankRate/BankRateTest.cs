using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class BankRateTest
    {

        [TestMethod]
        public void FirstMonthRate()
        {
            decimal rate = CalculateBankRate(40000, 240, 7.57m, 1);
            Assert.AreEqual(419.01m, rate);

        }
        [TestMethod]
        public void FourthMonthInTheFOurYearOfATwentyYearsCredit()
        {
            decimal rate = CalculateBankRate(40000, 240, 7.57m, 39);
            Assert.AreEqual(379.05m, rate);

        }



        decimal CalculateBankRate(decimal total, int periodInMonths, decimal interestPerYear, int currentMonth )
        {
            decimal principal = total / periodInMonths;
            principal = Math.Ceiling(principal * 100) / 100;
            decimal exactinterestPerMonth =interestPerYear / 12 / 100;
            decimal sold = total - (currentMonth - 1)* principal;
            decimal neededMonthInterest= principal + sold * exactinterestPerMonth;
            neededMonthInterest = Math.Ceiling(neededMonthInterest * 100) / 100;
            return neededMonthInterest;

        }
    }
}
