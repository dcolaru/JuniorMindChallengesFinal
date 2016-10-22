using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CatISixNumbers()
        {
            double oneChancein = CalculateLoto(6);
            Assert.AreEqual(13983816, oneChancein);
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
