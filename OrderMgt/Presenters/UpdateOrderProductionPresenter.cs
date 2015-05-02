using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class UpdateOrderProductionPresenter
    {
        private IUpdateOrderProduction _screen;
        
        public UpdateOrderProductionPresenter(IUpdateOrderProduction screen)
        {
            _screen = screen;
            _screen.Register(this);
            populateLastOrder();
        }

        public void populateLastOrder()
        {
            _screen.LastOrderId = OrderGateway.getLastOrderInProduction();
        }
        public void setOrderStatus()
        {
            IOrder _order; 
            //Assuming there was no previous order set to Production,
            //then there will be no Order to set 'Ready For Delivery'.
            //This only happens once, so this validation code is not in the ValidateData() function
            if (_screen.LastOrderId != string.Empty)
            {
                _order = new Order(_screen.LastOrderId);
                _order.Status = OrderStatus.Transport;
                _order.Save();
            }
            
            _order = new Order(_screen.CurrentOrderId);
            _order.Status = OrderStatus.Fabrication;
            _order.Save();

            
            _screen.ShowMessage("Successfully Updated");
            populateLastOrder();
        }
        public String ValidateData()
        {
            String errMessage = "";
            int number1 = 0;
            
            if (_screen.CurrentOrderId == string.Empty)
                errMessage = "Current Order ID cannot be Empty";
            else if (_screen.CurrentOrderId == _screen.LastOrderId)
                errMessage = "Last Order ID cannot be the same as the Current Order ID";
            else if (int.TryParse(_screen.CurrentOrderId, out number1) == false)
                errMessage = "Current Order ID must be a numeric value";

            return errMessage;
        }

    }
}