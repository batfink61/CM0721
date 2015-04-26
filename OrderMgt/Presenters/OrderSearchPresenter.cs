using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderSearchPresenter
    {
     //private Customer _customer;
        private IOrder _order;
        private IOrderSearchGui _screen;
        private OrderPresenter _orderPresenter;

        public OrderSearchPresenter(IOrderSearchGui screen, IOrder order)
        {
            _screen = screen;
            _screen.Register(this);
            _order = order;
            Initialise();
        }

        private void Initialise()
        {
        
        }
        public void setOrderPresenter(OrderPresenter orderPresenter) 
        {
            _orderPresenter = orderPresenter;
        }

        public void getOrderToUpdate()
        {
            _order = new Order(_screen.OrderId);
            _orderPresenter.btnSearchOrder_Click(_order);
            
            
            /*
            if (_order.Status == OrderStatus.Unsubmitted)
            {
            }
            else 
            {
                UpdateOrderForm screen = new UpdateOrderForm();
                UpdateOrderPresenter presenter = new UpdateOrderPresenter(screen, _order);
                screen.ShowDialog();
                _screen.Close();
            }
            */
        }
    }
}
