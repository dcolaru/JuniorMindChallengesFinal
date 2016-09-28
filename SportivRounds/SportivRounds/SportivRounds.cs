using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportivRounds
{
    [TestClass]
    public class SportivRounds
    {
        [TestMethod]
        public void RehearsalsForTwoRounds()
        {

            int rehearsals = CalcultateRehearsals(2);
            Assert.AreEqual(4, rehearsals);
        }
        [TestMethod]
        public void RehearsalsForTenRounds()
        {

            int rehearsals = CalcultateRehearsals(10);
            Assert.AreEqual(100, rehearsals);
        }
        [TestMethod]
        int CalcultateRehearsals(int rounds)
        {
            int rehearsals = (int)Math.Pow(rounds, 2);
            return rehearsals;
        }
    }
}
