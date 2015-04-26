using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// Customer UI interface implemented by the Customer form and
// used by the CustomerPresenter to access the UI

namespace OrderMgt
{
    public interface ICustomerGui
    {
        String CustomerId { set; get; }
        String CustomerName { set; get; }
        String Address { set; get; }
        String Town { set; get; }
        String PostCode { set; get; }
        String Telephone { set; get; }
        String Mobile { set; get; }
        String Registered { set; }

        void ShowMessage(String message);
        void Close();
        void EnableControls(Boolean enabled);
        void Register(CustomerPresenter customerPresenter);
    }
}
