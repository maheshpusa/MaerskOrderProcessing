using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessor.Helper;
using System;

namespace OrderProcessor.HelperTests
{
    [TestClass]
    public class ProcesspackageTest
    {
        [TestMethod]
        public void TestForBook()
        {
            ProcessOrderHelper pkg = new ProcessOrderHelper();
            pkg.processpackage("BookRule");

        }
    }
}
