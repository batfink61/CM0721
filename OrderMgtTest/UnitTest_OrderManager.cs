using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderMgt;
using Moq;

namespace OrderMgtTest
{
    [TestClass]
    public class UnitTest_OrderManager
    {
        [TestMethod]
        public void WhenStatusIsUnsubmitted()
        {
            DateTime test = new DateTime();
            test = DateTime.Now;
            OrderStatus status = new OrderStatus();
            Order order = new Order();
            order.Status = OrderStatus.Planning;
            order.PlanningGranted = test;
            order.PlanningInvoice = test;
            
            //var order = new Mock<Order>();
            //order.SetupGet(m => m.Status).Returns(OrderStatus.Unsubmitted);
            //order.SetupGet(m => m.PlanningGranted).Returns(test);
            //order.SetupGet(m => m.PlanningInvoice).Returns(test);
    
            //order.SetupSet(m => m.Status = OrderManager.Instance.ManageOrderUpdate(order.Object));
            //status = OrderManager.Instance.ManageOrderUpdate(order.Object);
            status = OrderManager.Instance.ManageOrderUpdate(order);
            Assert.AreEqual(status, OrderStatus.Contract);
        }
        
        [TestMethod]
        public void WhenStatusIsPlaced()
        {
            Order order = new Order();
            OrderManager.Instance.ManageOrderUpdate(order);
        }
        

    }
}
