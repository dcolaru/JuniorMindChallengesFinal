using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntToRomanNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThirtyThree()
        {
            string _romanNumber = CalculateRomanNumber(33);
            Assert.AreEqual("XXXIII", _romanNumber);
        }
        [TestMethod]
        public void NINETYNINE()
        {
            string _romanNumber = CalculateRomanNumber(99);
            Assert.AreEqual("XCIX", _romanNumber);
        }
        [TestMethod]
        public void SEVEN()
        {
            string _romanNumber = CalculateRomanNumber(7);
            Assert.AreEqual("VII", _romanNumber);
        }
        public string CalculateRomanNumber(int arabNumber)
        {
            string romanNumber = "";
            //for 100's
            while (arabNumber >= 100)
            {
                romanNumber += "C";
                arabNumber -= 100;

            }
            //for 90's
            while (arabNumber >= 90)
            {
                romanNumber += "XC";
                arabNumber -= 90;

            }
            //for 50's
            while (arabNumber >= 50)
            {
                romanNumber += "L";
                arabNumber -= 50;

            }
            //for 40's
            while (arabNumber >= 40)
            {
                romanNumber += "XL";
                arabNumber -= 40;

            }
            //for 10's
            while (arabNumber >= 10)
            {
                romanNumber += "X";
                arabNumber -= 10;

            }
            //for 9's
            while (arabNumber >= 9)
            {
                romanNumber += "IX";
                arabNumber -= 9;

            }
            //for 5's
            while (arabNumber >= 5)
            {
                romanNumber += "V";
                arabNumber -= 5;

            }
            //for 4's
            while (arabNumber >= 4)
            {
                romanNumber += "IV";
                arabNumber -= 4;

            }
            //for 1's
            while (arabNumber >= 1)
            {
                romanNumber += "I";
                arabNumber -= 1;

            }

            return romanNumber;

        }
    }
}
