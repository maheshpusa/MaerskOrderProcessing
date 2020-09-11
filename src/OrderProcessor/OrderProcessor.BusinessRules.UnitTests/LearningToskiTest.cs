using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;

namespace OrderProcessor.BusinessRules.UnitTests
{
    [TestClass]
    public class LearningToskiTest
    {
        [TestMethod]
        public void ProcessLeaningSkiTest()
        {
            List<string> productList = new List<string>();
            productList.Add("LearningToski"); 
             
            Customer customer = new Customer();
            customer.FirstName = "Mahesh";
            customer.LastName = "Reddy ";
            customer.Email = "mahesh@gmail.com";
            customer.Address = "Bangalore";


            IProcessOrderRule processOrder = new LearningToSkiRule();
            processOrder.ProcessOrder(customer, productList); 

           

        }
    }
}
