using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Restaurant
{
    [TestClass]
    public class Restaurant
    {
        [TestMethod]
        public void TestMethod1()
        {
            int nextDayForeeting = NextMeetingAtRestaurant(6,4);
            Assert.AreEqual(12, nextDayForeeting);
        }
        int NextMeetingAtRestaurant(int a, int b)
        {
            int cmmmc;
            //x=a1;y=b1;

            cmmmc = (a * b) / CMMDC(a, b);
            return cmmmc;
        }
        int CMMDC(int a1, int b1)
        {
            int r = 0;
            while (b1 != 0)
            {
                r = a1 % b1;
                a1 = b1;
                b1 = r;
            }
            return a1;

        }


    }
}
