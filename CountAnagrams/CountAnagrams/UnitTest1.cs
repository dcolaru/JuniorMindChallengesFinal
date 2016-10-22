using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountAnagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeLetterWord()
        {
            double countAnagrams = CalculateAnagrams("dog");
            Assert.AreEqual(6, countAnagrams);
        }

        double Factorial(double number)
        {

            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {

                factorial = factorial * i;
            }
            return factorial;
        }
        double CalculateAnagrams(string word)

        {
            double wordLenght = word.Length;
            double numbersOfLetters = wordLenght;
            double numbersOfAnagrams = 0;
            double factorialMinus = numbersOfLetters - wordLenght;
            numbersOfAnagrams = Factorial(numbersOfLetters) / Factorial(factorialMinus);
            return numbersOfAnagrams;
        }

    }
}
