using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

// Customer Presenter enabling a passive view model to be implemented for customer maintenance

namespace OrderMgt
{
    public class CustomerPresenter
    {
        private Customer _customer;
        private ICustomerGui _screen;

        public CustomerPresenter(ICustomerGui screen)
        {
            _screen = screen;
            _screen.Register(this);

            _screen.EnableControls(false); // Disables textboxes until user selects a customer or clicks 'New'
        }

        public void txtCustomerId_TextChanged()
        {
            if (_screen.CustomerId=="new")
                _customer = new Customer();
            else
                _customer = new Customer(_screen.CustomerId);

            _screen.CustomerName = _customer.Name;
            _screen.Address = _customer.Address;
            _screen.Town = _customer.Town;
            _screen.PostCode = _customer.PostCode;
            _screen.Telephone = _customer.Telephone;
            _screen.Mobile = _customer.Mobile;
            _screen.Registered = _customer.Registered;

            _screen.EnableControls(true);
        }

        public void btnNew_Click()
        {
            // User has decided to register a new Customer

            _screen.CustomerId = "new";
        }

        public void txtCustomerName_TextChanged()
        {
            _customer.Name = _screen.CustomerName;
        }

        public void txtAddress_TextChanged()
        {
            _customer.Address = _screen.Address;
        }

        public void txtTown_TextChanged()
        {
            _customer.Town = _screen.Town;
        }

        public void txtPostCode_TextChanged()
        {
            _customer.PostCode = _screen.PostCode;
        }

        public void txtTelephone_TextChanged()
        {
            _customer.Telephone = _screen.Telephone;
        }

        public void txtMobile_TextChanged()
        {
            _customer.Mobile = _screen.Mobile;
        }
     
        public void btnSave_Click()
        {
            ValidateData();
            _customer.Save();
            _screen.CustomerId = _customer.CustomerId;
            _screen.Close();
        }
        private void ValidateData()
        {
            if (_customer.Name== "")
                throw new ArgumentOutOfRangeException("Name", "Name cannot be blank");
            if (_customer.Address == "")
                throw new ArgumentOutOfRangeException("Address", "Address cannot be blank");
            if (_customer.Name.Length > 100)
                throw new ArgumentOutOfRangeException("Name", "Name not be longer than 100 characters.");
            if (_customer.Address.Length > 180)
                throw new ArgumentOutOfRangeException("Address", "PostCode not be longer than 180 characters.");
            if (_customer.Town.Length > 80)
                throw new ArgumentOutOfRangeException("Town", "PostCode not be longer than 80 characters.");
            if (_customer.PostCode.Length > 9)
                throw new ArgumentOutOfRangeException("PostCode", "PostCode not be longer than 9 characters.");
            if (_customer.Telephone.Length > 20)
                throw new ArgumentOutOfRangeException("Telephone", "Telephone No. not be longer than 20 characters.");
            if (_customer.Mobile.Length > 20)
                throw new ArgumentOutOfRangeException("Mobile", "Mobile Number not be longer than 20 characters.");
        }
    }
}
