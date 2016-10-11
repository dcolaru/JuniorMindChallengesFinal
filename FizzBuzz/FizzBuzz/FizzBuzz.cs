using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void Fizz()
        {
            string number = DetermineFizzBuzz(9);
            Assert.AreEqual("fizz", number);
        }
        [TestMethod]
        public void Buzz()
        {
            string number = DetermineFizzBuzz(10);
            Assert.AreEqual("buzz", number);
        }
        [TestMethod]
        public void FizzBuzzResult()
        {
            string number = DetermineFizzBuzz(30);
            Assert.AreEqual("fizzbuzz", number);
        }
        public string DetermineFizzBuzz(int nr)
        {
            string[] message = { "fizz", "buzz", "fizzbuzz", "Number not divided by 3 or by 5" };
            if (nr % 3 == 0 && nr % 5 != 0)
            {

                return message[0];
            }
            if (nr % 3 != 0 && nr % 5 == 0)
            {

                return message[1];
            }
            if (nr % 3 == 0 && nr % 5 == 0)
            {
                return message[2];
            }
            else
                return message[3];


        }
    }
}
