using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderMgt;

namespace OrderMgtTest
{
    [TestClass]
    public class UnitTest_ProductionDelivery
    {
        [TestMethod]
        public void UpdateOrderProduction_Delivery_Test()
        {
            UpdateOrderProductionForm screen = new UpdateOrderProductionForm();
            UpdateOrderProductionPresenter presenter = new UpdateOrderProductionPresenter(screen);
            screen.CurrentOrderId = "";
            Assert.AreEqual(presenter.ValidateData(), "Current Order ID cannot be Empty");

            screen.LastOrderId = "4";
            screen.CurrentOrderId = screen.LastOrderId; 
            Assert.AreEqual(presenter.ValidateData(), "Last Order ID cannot be the same as the Current Order ID");

            screen.CurrentOrderId = "4A";
            Assert.AreEqual(presenter.ValidateData(), "Current Order ID must be a numeric value");
        }
    }
}
