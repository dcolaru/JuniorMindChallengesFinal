using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cub
{
    [TestClass]
    public class Cub
    {
        [TestMethod]
        public void ForOne()
        {
            int cub = CubNumber(1);
            Assert.AreEqual(192, cub); 
        }
        [TestMethod]
        public void ForNine()
        {
            int cub = CubNumber(9);
            Assert.AreEqual(2832, cub);
        }

        int CubNumber(int x)
        {
            int nr = 0;
            int counter = 0;
            int cub = 0;
            int mod = 0;

            while (counter < x)
            {
                nr++;
                cub = nr * nr * nr;//(int)Math.Pow(x,3);

                mod = cub % 1000;
                if (mod == 888)
                {
                    counter++;
                }
            }
            return nr;
        }
    }
}

