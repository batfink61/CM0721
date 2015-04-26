using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IOrderSearchGui
    {
        String OrderId { set; get; }
        void ShowMessage(String message);
        void Close();
        void Register(OrderSearchPresenter presenter);
    }
}
