using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class StringInterpolationTest
    {
        //TODO: Use string interpolation to generate expected text. You are allowed to change just lines with variable age and greeting

        [TestMethod]
        public void ReadFile()
        {
            var firstName = "Jmeno";
            var lastName = "Prijmeni";
            var birthDate = new DateTime(1995, 5, 6);
            var today = new DateTime(2019, 1, 1);
            var age = ((today - birthDate).Days * 100 / 36525);
            var greeting = $"Ahoj {firstName} {lastName}, narozeny {birthDate.ToString("d. M. yyyy")}, dnes ti je {age}";
                                 

            Assert.AreEqual("Ahoj Jmeno Prijmeni, narozeny 6. 5. 1995, dnes ti je 23", greeting);
        }
    }
}
