using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class SQLGenTest
    {
        //TODO: Write SQL generator to insert sourceData to imaginary table. TableName is imaginary_ToSaveToDatabase. Result should be SQL string

        [TestMethod]
        public void ReadFile()
        {
            var sourceData = Enumerable.Range(1, 1000)
                .Select(a => new ToSaveToDatabase()
                {
                    Id = Guid.NewGuid(),
                    Name = $"Name {a}",
                    Code = $"Code{a}",
                    CreationDate = DateTime.Today.AddDays(-a)
                }).ToList();





            Assert.Inconclusive();
        }

        class ToSaveToDatabase
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public DateTime CreationDate { get; set; }
            public DateTime? LastChange { get; set; }
        }

    }
}
