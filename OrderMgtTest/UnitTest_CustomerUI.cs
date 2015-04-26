using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderMgt;

namespace OrderMgtTest
{
    [TestClass]
    public class UnitTest_CustomerUI
    {
        [TestInitialize]
        public void TestInitialise()
        {
        }
        [TestMethod]
        public void TestCustomer_UI()
        {
            //REF: https://msdn.microsoft.com/en-us/library/ms182532.aspx
            ICustomerGui screen = new CustomersForm();
            CustomerPresenter presenter = new CustomerPresenter(screen);
            screen.CustomerId = "new";
            screen.CustomerName = "";
            //Please see the ValidateData() method of CustomerPresenter for error messages
             
            try
            {
                presenter.btnSave_Click();
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Name cannot be blank");
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
        [TestCleanup]
        public void TestCleanUp()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
