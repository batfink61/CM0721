using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderMgt;

namespace OrderMgtTest
{
    [TestClass]
    public class UnitTest_Customers
    {
        [TestMethod]
        public void TestNewCustomerProperties()
        {
            Customer customer = new Customer();
            Assert.AreEqual(string.Empty, customer.CustomerId, "New customer should have no ID");
            Assert.AreEqual(string.Empty, customer.Name, "New customer should have no name");
            Assert.AreEqual(string.Empty, customer.Address, "New customer should have no Address");
            Assert.AreEqual(string.Empty, customer.Telephone, "New customer should have no Telephone");
        }

        [TestMethod]
        public void TestSaveBlankCustomer()
        {
            Exception exception = null;

            Customer customer = new Customer();

            try
            {
                customer.Save();
            }
            catch (Exception tempException)
            { exception = tempException; }

            Assert.IsNotNull(exception, "Expected exception saving without details not thrown");
        }

        [TestMethod]
        public void TestLoadCustomer()
        {
            Customer customer = new Customer("1");

            Assert.AreEqual("1", customer.CustomerId, "Loaded customer has incorrect ID");
            Assert.AreNotEqual(String.Empty, customer.Name, "Expected name missing");
            Assert.AreNotEqual(String.Empty, customer.Address, "Expected address missing");
            Assert.AreNotEqual(String.Empty, customer.PostCode, "Expected postcode missing");
            Assert.AreNotEqual(String.Empty, customer.Telephone, "Expected telephone no missing");
        }

        [TestMethod]
        public void TestSaveEsistingCustomer()
        {
            Exception exception = null;

            Customer customer = new Customer("1");

            try
            {
                customer.Save();
            }
            catch (Exception tempException)
            { exception = tempException; }

            Assert.IsNull(exception, "Expected exception saving without details not thrown");
        }
    }
}
