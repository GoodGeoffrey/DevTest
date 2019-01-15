using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // VALUES have 1000 limit, so if the sourceData is bigger, it can be used something like this:
            //var cycleCount = (sourceData.Count - 1) / 1000 + 1;
            //for (int i = 0; i < cycleCount; i++)
            //{ }

            string insertQuery =
                $"INSERT INTO imaginary_ToSaveToDatabase " +
                $"({nameof(ToSaveToDatabase.Id)}, {nameof(ToSaveToDatabase.Name)}, {nameof(ToSaveToDatabase.Code)}, {nameof(ToSaveToDatabase.CreationDate)}, {nameof(ToSaveToDatabase.LastChange)}) " +
                $"VALUES " +
                $"{GetFormatedStringToSaveToDatabase(sourceData)}";

            Assert.Inconclusive();
        }

        private string GetFormatedStringToSaveToDatabase(List<ToSaveToDatabase> sourceData)
        {
            StringBuilder sb = new StringBuilder();
            sourceData.ForEach(item => sb.AppendLine($"('{item.Id}', '{item.Name}', '{item.Code}', '{item.CreationDate.ToString("yyyyMMdd HH:mm:ss")}', NULL)"));
            return sb.ToString();
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
