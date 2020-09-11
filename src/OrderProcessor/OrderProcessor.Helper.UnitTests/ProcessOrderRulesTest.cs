using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessor.Domain;
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
            Customer customer = new Customer();
            customer.FirstName = "Mahesh";
            customer.LastName = "Reddy ";
            customer.Email = "mahesh@gmail.com";
            customer.Address = "Bangalore";
            pkg.processpackage("BookRule", customer);

        }
    }
}
