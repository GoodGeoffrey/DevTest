using System;
using System.Collections.Generic;
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
            return null;
        }


        [TestMethod]
        public void DictionaryTest()
        {
            // Modify code for tests to pass

            var myDictionary = new Dictionary<string, string>();
            myDictionary.Add("First", "First Item");

            string temp;
            Assert.IsTrue(myDictionary.TryGetValue("First", out temp));
            Assert.IsTrue(myDictionary.TryGetValue("FIrst", out temp));
            Assert.IsTrue(myDictionary.TryGetValue("FIRST", out temp));
        }
    }
}
