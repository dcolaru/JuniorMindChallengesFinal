using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    //one chace out of oneChanceIn
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void CatISixNumbers()
        {
            double oneChanceIn = CalculateLoto(6,49);
            Assert.AreEqual(13983816, oneChanceIn);
        }
        [TestMethod]
        public void CatIFiveNumbers()
        {
           
            Assert.AreEqual(1906884, CalculateLoto(5,49));
        }
        [TestMethod]
        public void CatIFourNumbers()
        {
            double oneChanceIn = CalculateLoto(4,49);
            Assert.AreEqual(211876, oneChanceIn);
        }
        [TestMethod]
        public void CatIFiveNumbersOutOfForty()
        {
            double oneChanceIn = CalculateLoto(5,40);
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
         double CalculateLoto(double numbers, double totalBalls)

        {
          
            double chances = 0;
            double factorialMinus = totalBalls - numbers;
            chances = Factorial(totalBalls) / (Factorial(numbers) * Factorial(factorialMinus));
            return chances;
        }
        
    }
}
