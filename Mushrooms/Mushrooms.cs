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
            int redM = CalculateMushrooms(10, 3);
            Assert.AreEqual(30, redM);
        }

        int CalculateMushrooms(int whiteM, int moreThenRed)
        {
            int totalM;
            int red = whiteM * moreThenRed;
            totalM = whiteM + red;
            return red;


        }
    }
}
