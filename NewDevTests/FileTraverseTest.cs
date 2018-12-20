using System;
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

        [TestMethod]
        public void TracerseFileTest()
        {
            var rootDirectory = ".";
            var allowedEnvironements = new[] { "development", "integation", "validation", "production", "demo" };



            Assert.Inconclusive();
        }

    }
}
