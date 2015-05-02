using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

// Customer class - defines a single instance of a customer
// Two constructors allow an existing or new customer to be instanciated.

namespace OrderMgt
{
    public class Customer
    {
        private Boolean _isNewCustomer;
        private String _customerId;
        private String _name;
        private String _address;
        private String _town;
        private String _postcode;
        private String _telephone;
        private String _mobile;
        private String _registered;

        public Customer()
        {
            _isNewCustomer = true;
            _customerId = "";
            _name = "";
            _address = "";
            _town = "";
            _postcode = "";
            _telephone = "";
            _mobile="";
            _registered = "";
        }

        public Customer(String customerId)
        {
            _isNewCustomer = false;
            _customerId = customerId;
            Initialise();
        }

        public String CustomerId
        {
            get
            { return _customerId; }
        }

        public String Name
        {
            get
            { return _name; }
            set
            { _name = value; }
        }

        public String Address
        {
            get
            { return _address; }
            set
            { _address = value; }
        }

        public String Town
        {
            get
            { return _town; }
            set
            { _town = value; }
        }

        public String PostCode
        {
            get
            { return _postcode; }
            set
            { _postcode = value; }
        }

        public String Telephone
        {
            get
            { return _telephone; }
            set
            { _telephone = value; }
        }

        public String Mobile
        {
            get
            { return _mobile; }
            set
            { _mobile = value; }
        }

        public String Registered
        {
            get
            { return _registered; }
        }

        private void Initialise()
        {
            DataSet ds = CustomerGateway.Find(_customerId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                _name = ds.Tables[0].Rows[0]["Name"].ToString();
                _address = ds.Tables[0].Rows[0]["Address"].ToString();
                _town = ds.Tables[0].Rows[0]["Town"].ToString();
                _postcode = ds.Tables[0].Rows[0]["PostCode"].ToString();
                _telephone = ds.Tables[0].Rows[0]["Tel"].ToString();
                _mobile = ds.Tables[0].Rows[0]["Mob"].ToString();
                _registered = ds.Tables[0].Rows[0]["registered"].ToString();
            }
        }

        public void Save()
        {
            // Validate the data before attempting to insert/update
            // Any errors will throw exceptions and handled by the presenter

            ValidateData();

            // Data is valid at this point so we can safely attempt to save in DB
            // Use Gateway class for all I/O

            if (_isNewCustomer)
               _customerId = CustomerGateway.Insert(_name, _address, _town, _postcode, _telephone, _mobile);
            else
                CustomerGateway.Update(_customerId, _name, _address, _town, _postcode, _telephone, _mobile);
        }

        private void ValidateData()
        {
            if (_name == "")
                throw new ArgumentOutOfRangeException("Name", "Name cannot be blank");
            if (_address == "")
                throw new ArgumentOutOfRangeException("Address", "Address cannot be blank");
            if (_name.Length > 100)
                throw new ArgumentOutOfRangeException("Name", "Name not be longer than 100 characters.");
            if (_address.Length > 180)
                throw new ArgumentOutOfRangeException("Address", "PostCode not be longer than 180 characters.");
            if (_town.Length > 80)
                throw new ArgumentOutOfRangeException("Town", "PostCode not be longer than 80 characters.");
            if (_postcode.Length > 9)
                throw new ArgumentOutOfRangeException("PostCode", "PostCode not be longer than 9 characters.");
            if (_telephone.Length > 20)
                throw new ArgumentOutOfRangeException("Telephone", "Telephone No. not be longer than 20 characters.");
            if (_mobile.Length > 20)
                throw new ArgumentOutOfRangeException("Mobile", "Mobile Number not be longer than 20 characters.");
        }
    }
}
