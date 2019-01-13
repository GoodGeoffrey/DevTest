using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewDevTests
{
    [TestClass]
    public class FileTraverseTest
    {
        //TODO: Write class to search for all .config files in given directory
        // Every file named default.[anyallowedenvironment].config rename to default.[newEnvironment].config
        // All other files search content for any case of `.[anyallowedenvironment].config` and change to `.[newEnvironment].config`
        // Allow case-invariant behavior (.CONfig) is valid, etc.
        // Try to avoid loading all file names name to memory

        string newEnvironement = "newEnvironment";

        [TestMethod]
        public void TracerseFileTest() // Not sure what "Tracerse" mean. Maybe typo from "Trace"?
        {
            var rootDirectory = ".";
            var allowedEnvironements = new[] { "development", "integration", "validation", "production", "demo" };

            RenameFiles(rootDirectory, allowedEnvironements);

            Assert.Inconclusive();
        }

        public void RenameFiles(string directory, string[] allowedEnvironements)
        {
            DirectoryInfo root = new DirectoryInfo(directory);
            var files = root.GetFiles("*.config").ToList();
            string reg = String.Join("|", allowedEnvironements);
            files.ForEach(f => f.MoveTo(f.Directory.FullName + "\\" + Regex.Replace(f.Name, reg, AllowedEnvironmentsEvaluator)));
        }

        public string AllowedEnvironmentsEvaluator(Match notWanted)
        {
            return newEnvironement;
        }
    }
}
