using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class ReflectionTest
    {
        //TODO: Use reflection to create and fill up class FillMePlease 
        // - please note we can test with other, unknown class, so use all - Activator, attributes reading, property set via Reflection
        //Fill values with content of attribute DefaultValueAttribute

        [TestMethod]
        public void UseReflectionToFill()
        {
            object result = null;



            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(FillMePlease));
            Assert.AreEqual("This is my value", ((FillMePlease)result).Test);
            Assert.AreEqual(true, ((FillMePlease)result).Flag);
            Assert.AreEqual(null, ((FillMePlease)result).InvalidCanYouHandleMe);
            Assert.AreEqual(null, FillMePlease.WhatAboutMe);
        }


        class FillMePlease
        {
            [DefaultValue("This is my value")]
            public string Test { get; set; }

            [DefaultValue(true)]
            public bool Flag { get; set; }

            [DefaultValue("This is my value 2")]
            public string InvalidCanYouHandleMe { get; private set; }

            [DefaultValue("This is my value 3")]
            public static string WhatAboutMe { get; set; }
        }
    }
}
