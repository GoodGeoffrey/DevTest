using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class CsvTest
    {
        //TODO: Write CSV Parser class
        //Assume primitive CSV structure - no new lines in columns, no delimiters in columns.
        //It should be able to read all values out of file - not just values we check for in tests
        //Assume gigantic files - do not read whole file in memmory
        //Test it using file in /Files/Test_Addressfile_PostCard_5000Ex.csv

        [TestMethod]
        public void ReadFile()
        {
            var lineCount = 0;
            var doAllLinesHaveValidColumnCount = true;



            Assert.AreEqual(5001, lineCount);
            Assert.IsTrue(doAllLinesHaveValidColumnCount);
        }


    }
}
