using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderPresenter
    {
        private Customer _customer;
        private Order _order;
        private IOrderGui _screen;

        public OrderPresenter(IOrderGui screen)
        {
            _screen = screen;
            _screen.Register(this);


            _screen.EnableControls(false); // Disables order list until user selects a customer or clicks 'New'
        }

        public void txtOrderNumber_TextChanged()
        {
            //if (_screen.OrderId == "new")
            //    _order = new Order();
            //else
            //    _order = new Order(_screen.OrderId);
            _order = new Order(_screen.OrderId);
            RefreshScreen();
        }

        public void cboBuildingType_SelectedIndexChanged()
        {
            if (_order!=null)
            {
//_order.BuildingType=_screen.BuildingType;
                RefreshScreen();
            }
        }

        public void btnSearchOrder_Click(IOrder order)
        {
            _order = (Order)order;
            RefreshScreen();
        }
        public void btnNewOrder_Click()
        {
            //_order = new Order();

            RefreshScreen();
        }

        public void txtCustomerId_TextChanged()
        {
            if (_screen.CustomerId != "")
            {
                _customer = new Customer(_screen.CustomerId);

                _screen.CustomerName = _customer.Name;
                _screen.Address = String.Format("{0},\r\n{1}, {2}", _customer.Address, _customer.Town, _customer.PostCode);
                _screen.Telephone = _customer.Telephone;
                _screen.EnableControls(true);
            }
            else
            {
                _screen.CustomerName = "";
                _screen.Address = "";
                _screen.Telephone = "";
            }
        }

        private void RefreshScreen()
        {
            _screen.CustomerId = _order.CustomerId;
            _screen.BuildingType = _order.BuildingType.ToString();
            _screen.FramePrice = String.Format("{0:0.00}", _order.FramePrice);
            //_screen.OptionsPrice = String.Format("{0:0.00}", _order.OptionsPrice);
            //_screen.VAT = String.Format("{0:0.00}", _order.Vat);
            //_screen.TotalPrice = String.Format("{0:0.00}", _order.TotalPrice);

            _screen.EnableControls(true);

        }
    }
}
