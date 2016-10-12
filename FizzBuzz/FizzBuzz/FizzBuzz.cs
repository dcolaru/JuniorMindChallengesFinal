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
        [TestMethod]
        public void NoFizzBuzzResult()
        {
            string number = DetermineFizzBuzz(22);
            Assert.AreEqual("Can't do FizzBuzz", number);
        }
        public string DetermineFizzBuzz(int givenNumber)
        {
            string[] message = { "fizzbuzz", "fizz", "buzz" };

            if (givenNumber % 3 == 0 || givenNumber % 5 == 0)
            {
                if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
                {
                    return message[0];

                }
                if (givenNumber % 3 == 0 && givenNumber % 5 != 0)
                {
                    return message[1];

                }
                else

                    return message[2];
            }
            else
                return "Can't do FizzBuzz";

        }
    }
}
