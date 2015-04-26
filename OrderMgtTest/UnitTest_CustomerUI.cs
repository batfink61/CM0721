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
            IOrder order = new Order();
            MockNewOrderForm screen = new MockNewOrderForm();
            NewOrderPresenter presenter = new NewOrderPresenter(screen, order);
            screen.ShowDialog();
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
