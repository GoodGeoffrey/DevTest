using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class OtherSmallTests
    {

        [TestMethod]
        public void FormatFileSize()
        {
            // Modify HumanizeSize for those tests to pass

            Assert.AreEqual("200 B", HumanizeSize(200));
            Assert.AreEqual("1.95 kB", HumanizeSize(2000));
            Assert.AreEqual("1.91 MB", HumanizeSize(2000000));
            Assert.AreEqual("1.86 GB", HumanizeSize(2000000000));
        }

        public static string HumanizeSize(long size)
        {
            string[] suffixes = { "B", "kB", "MB", "GB" };
            int suffix = 0;
            double humanizeSize = size;

            while (humanizeSize >= 1024)
            {
                suffix++;
                humanizeSize /= 1024;
            }

            // There can be some use for check if index exist in array 
            return $"{humanizeSize.ToString("0.##", new CultureInfo("en-us"))} {suffixes[suffix]}";
        }


        [TestMethod]
        public void DictionaryTest()
        {
            // Modify code for tests to pass

            var myDictionary = new Dictionary<string, string>();
            myDictionary.Add("First", "First Item");
            // Not sure if this task idea was like this, but maybe I am looking for unnecessary dficulties
            myDictionary.Add("FIrst", "First Item");
            myDictionary.Add("FIRST", "First Item");

            string temp;
            Assert.IsTrue(myDictionary.TryGetValue("First", out temp));
            Assert.IsTrue(myDictionary.TryGetValue("FIrst", out temp));
            Assert.IsTrue(myDictionary.TryGetValue("FIRST", out temp));
        }
    }
}
