using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WattermellonFriends
{
    [TestClass]
    public class WattermellonFriends
    {
        [TestMethod]
        public void EvenNumberNotEvanShares()
        {
           string message = CalculateSplitWattermellon(10);
            Assert.AreEqual("DA", message);

        }
        [TestMethod]
        public void EvenNumberAndEvanShares()
        {
            string message = CalculateSplitWattermellon(8);
            Assert.AreEqual("DA", message);

        }
        [TestMethod]
        public void CalculateOddNumber()
        {
            string message = CalculateSplitWattermellon(13);
            Assert.AreEqual("NU", message);

        }
        public string CalculateSplitWattermellon(int kg)
        {
           // int a = 0;
            //int b = 0;
            string [] message = { "DA", "NU" };
           
            if (kg % 2 == 0)
            {
               int a = kg / 2;
                if (a % 2 != 0)
                {
                    a++;
                }
                int b = kg - a;
                return message[0];
            }
            else

                return message[1];

        }
    }
}
