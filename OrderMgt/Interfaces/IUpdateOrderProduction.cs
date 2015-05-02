using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IUpdateOrderProduction
    {
        String LastOrderId { set; get; }
        String CurrentOrderId { set; get; }
        void ShowMessage(String message);
        void Close();
        void Register(UpdateOrderProductionPresenter presenter);
    }
}
