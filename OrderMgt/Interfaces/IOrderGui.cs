using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IOrderGui
    {
        String OrderId { set; get; }
        String BuildingType { set; get; }
        String FramePrice { set; get; }
        String OptionsPrice { set; }
        String VAT { set; }
        String TotalPrice { set; }
        String CustomerId { set; get; }
        String CustomerName { set; }
        String Address { set; }
        String Telephone { set; }

        void ShowMessage(String message);
        void Close();
        void EnableControls(Boolean enabled);
        void Register(OrderPresenter orderPresenter);
    }
}
