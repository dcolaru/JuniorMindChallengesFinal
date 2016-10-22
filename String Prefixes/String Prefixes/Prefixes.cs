using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Prefixes
{
    [TestClass]
    public class Prefixes
    {
        [TestMethod]
        public void SamePrefix()
        {
            string prefix = CheckPrefixes("aaab", "aaabc");
            Assert.AreEqual("aaa", prefix);
        }
        [TestMethod]
        public void DiferentPrefix()
        {
            string prefix = CheckPrefixes("asadab", "aaabc");
            Assert.AreEqual("false", prefix);
        }

        string CheckPrefixes(string firstString, string secondString)
        {
            string message = "";
            string a1 = firstString.Substring(0, 3);

            string aa1 = secondString.Substring(0, 3);
            if (a1 == aa1)
                message = a1;
        
	    else
	    
		  message = "false";
         
        return message;
    }
}
    }
