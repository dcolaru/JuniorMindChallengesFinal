using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class ExcelColumn
    {
        [TestMethod]
        public void OneLetter()
        {
            Assert.AreEqual("B", Excel(2));
        }
        
        string Excel(int number)
        {


            string convertedNumber = "";
            

            while (number > 0)
            {
                number--;
                convertedNumber = ExcelFindColumn((number)%26) + convertedNumber;
                number = number  / 26;

            }
            return convertedNumber;
        }
        public string ExcelFindColumn(int number)
        {
            return ((char)('A' + number)).ToString();
        }
    }
}
