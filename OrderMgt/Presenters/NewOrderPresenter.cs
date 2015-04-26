using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

// Customer Presenter enabling a passive view model to be implemented for customer maintenance

namespace OrderMgt
{
    public class NewOrderPresenter
    {
        private Customer _customer;
        private INewOrderGui _screen;
        private IOrder _order;
        private String _currentTab = "Customer";

        public NewOrderPresenter(INewOrderGui screen, IOrder order)
        {
            _screen = screen;
            _screen.Register(this);

            _order = order;

            Initialise();
        }

        private void Initialise()
        {
            _screen.EnableControls(false); // Disables textboxes until user selects a customer or clicks 'New'

            DataSet ds = BuildingGateway.List();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _screen.AddBuildingType(dr[1].ToString());
            }
        }

        public void txtCustomerId_TextChanged()
        {
            if (_screen.CustomerId != "")
            {
                _customer = new Customer(_screen.CustomerId);

                _screen.CustomerName = _customer.Name;
                _screen.Address = _customer.Address;
                _screen.Town = _customer.Town;
                _screen.PostCode = _customer.PostCode;
                _screen.Telephone = _customer.Telephone;
                _screen.Mobile = _customer.Mobile;
                _screen.Registered = _customer.Registered;

                _order.CustomerId = _screen.CustomerId;
            }
        }

        public void btnNext_Click()
        {
            switch (_currentTab)
            {
                case "Customer":
                    _screen.SetTab("Building");
                    _screen.SetNextCaption("Next >>");
                    break;

                case "Building":
                    _screen.SetTab("Options");
                    _screen.SetNextCaption("Next >>");
                    break;

                case "Options":
                    _screen.SetTab("Confirm");
                    _screen.SetNextCaption("Place Order");
                    break;

                case "Confirm":
                    if (ValidateData())
                        SaveOrder();
                    break;

                default:
                    break;
            }
        }

        public void tabWizzard_Selected(String tabName)
        {
            _currentTab = tabName;
        }

        public void btnBack_Click()
        {
            switch (_currentTab)
            {
                case "Building":
                    _screen.SetTab("Customer");
                    _screen.SetNextCaption("Next >>");
                    break;

                case "Options":
                    _screen.SetTab("Building");
                    _screen.SetNextCaption("Next >>");
                    break;

                case "Confirm":
                    _screen.SetTab("Options");
                    _screen.SetNextCaption("Next >>");
                    break;

                default:
                    break;
            }
        }

        public void btnNewCustomer_Click()
        {
            CustomersForm screen = new CustomersForm();
            CustomerPresenter presenter = new CustomerPresenter(screen);

            // Invoke "New Customer" so user can immediately start typing new customer details
            presenter.btnNew_Click();

            screen.ShowDialog();

            _screen.CustomerId = screen.CustomerId;
        }

        public void cboBuildingType_SelectedIndexChanged()
        {
            _order.SetFrame(_screen.BuildingType);

            _screen.BuildingType = _order.BuildingType;
            _screen.ReceptionRooms = _order.ReceptionRooms.ToString();
            _screen.Bathrooms = _order.Bathrooms.ToString();
            _screen.Bedrooms = _order.Bedrooms.ToString();

            _screen.ClearBuildingOptions();

            DataSet ds = BuildingGateway.Options(_screen.BuildingType);
            foreach (DataRow option in ds.Tables[0].Rows)
            {
                String[] row = new String[4];
                row[0] = option["id"].ToString();
                row[1] = option["optionname"].ToString();
                row[2] = option["optionprice"].ToString();
                row[3] = option["optiontype"].ToString();

                _screen.AddBuildingOption(row);
            }

            RefreshPrice();

        }
        private void RefreshPrice()
        {
            _screen.FramePrice = String.Format("{0:0.00}", _order.FramePrice);
            _screen.OptionsPrice = String.Format("{0:0.00}", _order.OptionsPrice);
            _screen.VAT = String.Format("{0:0.00}", _order.Vat);
            _screen.TotalPrice = String.Format("{0:0.00}", _order.TotalPrice);
        }

        public void vwBuildingOptions_SelectionChanged(int row)
        {
            String errMessage = "";
            Decimal optionsPrice = 0;
            List<String> optionTypes = new List<string>();
            List<String> validatedOptions = new List<string>();

            _order.ClearOptions();

            for (int i = 0; i < _screen.SelectedBuildingOptionsCount(); i++)
            {
                String[] screenOptions = _screen.GetBuildingOption(i);
                if (_screen.BuildingOptions_Selected(i))
                {
                    if (optionTypes.Contains(screenOptions[3]))
                    {
                        errMessage = String.Format("Only one type of {0} may be selected", screenOptions[3]);
                        _screen.SelectBuildingOption(i, false);
                        break;
                    }
                    else
                    {
                        validatedOptions.Add(screenOptions[0]);
                        optionTypes.Add(screenOptions[3]);
                        optionsPrice += Decimal.Parse(screenOptions[2]);

                        _order.AddOption(screenOptions[0]);
                    }
                }
            }

            _screen.OptionsPrice = optionsPrice.ToString();

            if (errMessage != "")
                _screen.ShowMessage(errMessage);

            RefreshPrice();
        }

        private Boolean ValidateData()
        {
            String errMessage = "";

            Boolean roofingSpecified = false;
            for (int i = 0; i < _screen.SelectedBuildingOptionsCount(); i++)
            {
                String[] screenOptions = _screen.GetBuildingOption(i);
                if (_screen.BuildingOptions_Selected(i))
                {
                    if (screenOptions[3] == "roof")
                        roofingSpecified = true;
                 }
            }
            if (!roofingSpecified)
                errMessage = "You must specify a roofing type";

            if (_order.BuildingType == "")
                errMessage = "You must enter a valid building type";

            if (_order.CustomerId == "")
                errMessage = "You must enter a valid customer ID";

            if (errMessage != "")
                _screen.ShowMessage(errMessage);

            return (errMessage == "");
        }

        private void SaveOrder()
        {
            _order.Save();

            _screen.ShowMessage(String.Format("New order created\r\nOrder Number: {0}", _order.OrderId));

            _screen.Close();
        }

    }

}