using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntToRomanNumbers
{
    [TestClass]
    public class RomanNumerals
    {
        [TestMethod]
        public void ThirtyThree()
        {
            string roman = CalculateRomanNumber(33);
            Assert.AreEqual("XXXIII", roman);
        }
       
        [TestMethod]
        public void Seven()
        {
            string roman = CalculateRomanNumber(7);
            Assert.AreEqual("VII", roman);
        }
        [TestMethod]
        public void OneHundred()
        {
            string roman = CalculateRomanNumber(100);
            Assert.AreEqual("C", roman);
        }

        public string CalculateRomanNumber(int arabNumber)
        {
            //declar 3 vectori de stringuri
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] oneHundred = { "", "C" };
            //declar un string care va stoca numarul roman
            string romanNumber = "";
            //aleg indexul din fiecare string
            romanNumber += oneHundred[(arabNumber % 1000) / 100];
            romanNumber += tens[(arabNumber % 100) / 10];
            romanNumber += units[arabNumber % 10];

            return romanNumber;
            ////for 100's
            //while (arabNumber >= 100)
            //{
            //    romanNumber += "C";
            //    arabNumber -= 100;

            //}
            ////for 90's
            //while (arabNumber >= 90)
            //{
            //    romanNumber += "XC";
            //    arabNumber -= 90;

            //}
            ////for 50's
            //while (arabNumber >= 50)
            //{
            //    romanNumber += "L";
            //    arabNumber -= 50;

            //}
            ////for 40's
            //while (arabNumber >= 40)
            //{
            //    romanNumber += "XL";
            //    arabNumber -= 40;

            //}
            ////for 10's
            //while (arabNumber >= 10)
            //{
            //    romanNumber += "X";
            //    arabNumber -= 10;

            //}
            ////for 9's
            //while (arabNumber >= 9)
            //{
            //    romanNumber += "IX";
            //    arabNumber -= 9;

            //}
            ////for 5's
            //while (arabNumber >= 5)
            //{
            //    romanNumber += "V";
            //    arabNumber -= 5;

            //}
            ////for 4's
            //while (arabNumber >= 4)
            //{
            //    romanNumber += "IV";
            //    arabNumber -= 4;

            //}
            ////for 1's
            //while (arabNumber >= 1)
            //{
            //    romanNumber += "I";
            //    arabNumber -= 1;

            //}



        }
    }
}
