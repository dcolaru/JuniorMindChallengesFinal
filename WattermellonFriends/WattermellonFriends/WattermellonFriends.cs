using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WattermellonFriends
{
    [TestClass]
    public class WattermellonFriends
    {
        [TestMethod]
        public void CalculateEvenNumber()
        {
           string message = CalculateSplitWattermellon(10);
            Assert.AreEqual("DA", message);

        }
        public string CalculateSplitWattermellon(int kg)
        {
            int a = 0;
            int b = 0;
            string message1 = "DA";
            string message2 = "NU";
            if (kg % 2 == 0)
            {
                a = kg / 2;
                if (a % 2 != 0)
                {
                    a = a + 1;
                }
                b = kg - a;
                return message1;
            }
            else

                return message2;

        }
    }
}
