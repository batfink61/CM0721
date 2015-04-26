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
        [TestInitialize]
        public void TestInitialise()
        {

        }

        [TestMethod]
        public void WhenStatusIsPlanningAndStatusIsToBeUpdated()
        {
            DateTime testTime = new DateTime();
            testTime = DateTime.Now;
            OrderStatus status = new OrderStatus();
            Order order = new Order();
            order.Status = OrderStatus.Planning;
            order.PlanningGranted = testTime;
            order.PlanningInvoice = testTime;
            
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
        public void WhenStatusIsPlanningAndStatusNotToBeUpdated()
        {
            //setup
            DateTime testTime = new DateTime();
            testTime = DateTime.Now;
            OrderStatus status = new OrderStatus();
            Order order = new Order();
            order.Status = OrderStatus.Planning;
            
            //Test both null 
            order.PlanningGranted = null;
            order.PlanningInvoice = null;
            status = OrderManager.Instance.ManageOrderUpdate(order);
            Assert.AreEqual(status, OrderStatus.Planning);

            order.PlanningGranted = null;
            order.PlanningInvoice = testTime;
            status = OrderManager.Instance.ManageOrderUpdate(order);
            Assert.AreEqual(status, OrderStatus.Planning);

            order.PlanningGranted = testTime;
            order.PlanningInvoice = null;
            status = OrderManager.Instance.ManageOrderUpdate(order);
            Assert.AreEqual(status, OrderStatus.Planning);

        }

        

    }
}
