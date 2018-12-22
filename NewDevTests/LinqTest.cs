using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class LinqTest
    {

        [TestMethod]
        public void LinqTest1()
        {
            //TODO: Use LINQ to merge the input ranges together, order them by XYNo and by Name

            var x = Enumerable.Range(1, 100).Select(a => new
            {
                Name = $"Name {a}",
                XYNo = a % 5
            });
            var y = Enumerable.Range(50, 100).Select(a => new
            {
                Name = $"Name {a}",
                XYNo = a % 6
            });


            var result = x.Concat(y).OrderBy(o => o.XYNo).ThenBy(o => o.Name).ToList();


            Assert.IsTrue(result is IList);
            // Check if concated
            Assert.AreEqual(200, result.Count);
            // Check if ordered
            Assert.IsTrue(result.Zip(result.Skip(1), (a, b) => new { a, b }).All(a => a.a.XYNo <= a.b.XYNo));
        }

        [TestMethod]
        public void LinqTest2()
        {
            //TODO: Use LINQ to select names of people aged 20 and younger from range, concate them with comma as separator (see test)

            var x = Enumerable.Range(1, 50).Select(a => new
            {
                Name = $"Name {a}",
                Age = 18 + a
            });
            

            string result = String.Join(", ", x.Where(o => o.Age <= 20).Select(o => o.Name));
            
            Assert.AreEqual("Name 1, Name 2", result);
        }
    }
}
