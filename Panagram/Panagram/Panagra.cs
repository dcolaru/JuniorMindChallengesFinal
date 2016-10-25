using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagra
    {
        [TestMethod]
        public void IsPanagram()
        {
            string word = getMissingLetters("Brick quiz whangs jumpy veldt fox");
            Assert.AreEqual("true", word);

        }
        [TestMethod]
        public void IsNotAPanagram()
        {
            string word = getMissingLetters("This will return false");
            Assert.AreEqual("false", word);

        }
        string getMissingLetters(string sentence)
        {
            string alphabetLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//alfabet
            sentence = sentence.ToUpper();//propozitie

            string message = " ";
            for (int i = 0; i <= sentence.Length - 1; i++)
            {
                int j = alphabetLetters.IndexOf(sentence[i]);
                if (j != -1)
                {
                    alphabetLetters = alphabetLetters.Remove(j, 1);

                    message = "true";
                }
                else
                {
                    message = "false";
                }
            }
            return message;
        }
    }
}
