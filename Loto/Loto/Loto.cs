using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void CatISixNumbers()
        {
            double oneChanceIn = CalculateLoto(6);
            Assert.AreEqual(13983816, oneChanceIn);
        }
        [TestMethod]
        public void CatIFiveNumbers()
        {
         Assert.AreEqual(1906884, CalculateLoto(5));
        }
        [TestMethod]
        public void CatIFourNumbers()
        {
            double oneChanceIn = CalculateLoto(4);
            Assert.AreEqual(211876, oneChanceIn);
        }
        [TestMethod]
        public void CatIFiveNumbersOutOfForty()
        {
            double oneChanceIn = CalculateCatIFortyNumbers(5);
            Assert.AreEqual(658008, oneChanceIn);
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
         double CalculateLoto(double numbers)

        {
            double loto = 49;
            double chances = 0;
            double factorialMinus = loto - numbers;
            chances = Factorial(loto) / (Factorial(numbers) * Factorial(factorialMinus));
            return chances;
        }
        double CalculateCatIFortyNumbers(double numbers)

        {
            double loto = 40;
            double chances = 0;
            double factorialMinus = loto - numbers;
            chances = Factorial(loto) / (Factorial(numbers) * Factorial(factorialMinus));
            return chances;
        }
    }
}
