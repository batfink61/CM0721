using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class MockNewOrderForm: INewOrderGui
    {
        private NewOrderPresenter _presenter;
        private String _txtCustomerId;
        private String _lblName;
        private String _lblAddress;
        private String _lblTelephone;
        private String _txtOrderId;
        private String _cboBuildingType_SelectedValue;
        private String _txtFramePrice;
        private String _txtOptionsPrice;
        private String _txtVat;
        private String _txtTotalPrice;
        private String _txtTown;
        private String _txtPostCode;
        private String _txtMobile;
        private String _txtRegistered;
        private String _txtReceptionRooms;
        private String _txtBedrooms;
        private String _txtBathrooms;
        private String _txtSelectedOptionsPrice;

        public MockNewOrderForm()
        {
        }

        public void Close()
        {
        }

        public void ShowDialog()
        {
        }

        public void Register(NewOrderPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
        }

        public String CustomerId
        {
            set
            {
                _txtCustomerId = value;
            }
            get
            {
                return _txtCustomerId;
            }
        }

        public String CustomerName
        {
            set
            {
                _lblName = value;
            }
        }

        public String Address
        {
            set
            {
                _lblAddress = value;
            }
        }

        public String Town
        {
            set
            {
                _txtTown = value;
            }
        }

        public String PostCode
        {
            set
            {
                _txtPostCode = value;
            }
        }

        public String Telephone
        {
            set
            {
                _lblTelephone = value;
            }
        }

        public String Mobile
        {
            set
            {
                _txtMobile = value;
            }
        }


        public String Registered
        {
            // This is a read-only field used to show when the customer was registered

            set
            {
                _txtRegistered = value;
            }
        }

        public String BuildingType
        {
            set
            {
                _cboBuildingType_SelectedValue = value;
            }
            get
            {
                return _cboBuildingType_SelectedValue;
            }
        }

        public String FramePrice
        {
            set
            {
                _txtFramePrice = value.ToString();
            }
            get
            {
                return _txtFramePrice;
            }
        }

        public String ReceptionRooms
        {
            set
            {
                _txtReceptionRooms = value;
            }
        }
        public String Bedrooms
        {
            set
            {
                _txtBedrooms = value;
            }
        }
        public String Bathrooms
        {
            set
            {
                _txtBathrooms = value;
            }
        }
        public String OptionsPrice
        {
            set
            {
                _txtOptionsPrice = value;
            }
        }

        public String VAT
        {
            set
            {
                _txtVat = value;
            }
        }

        public String TotalPrice
        {
            set
            {
                _txtTotalPrice = value;
            }
        }

        public String SelectedOptionsPrice
        {
            set
            {
                _txtSelectedOptionsPrice = value;
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtCustomerId_TextChanged();
        }

        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing

        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCustomerSearch_Click()
        {

        }

        public void AddBuildingType(String buildingType)
        {
        }

        private void btnNext_Click()
        {
            _presenter.btnNext_Click();
        }

        public void SetTab(String tabName)
        {

        }

        private void btnBack_Click()
        {
            _presenter.btnBack_Click();
        }

        private void btnNewCustomer_Click()
        {
            _presenter.btnNewCustomer_Click();
        }

        private void tabWizzard_Selected()
        {
            _presenter.tabWizzard_Selected("tabname");
        }


        private void cboBuildingType_SelectedValueChanged()
        {
            //            if (cboBuildingType.Items.Count > 0)
            _presenter.cboBuildingType_SelectedIndexChanged();
        }

        public void ClearBuildingOptions()
        {

        }

        public void AddBuildingOption(String[] row)
        {

        }

        public String[] GetBuildingOption(int row)
        {
            String[] cells = new String[4];
           
            return cells;
        }

        private void vwBuildingOptions_SelectionChanged(object sender, EventArgs e)
        {
            _presenter.vwBuildingOptions_SelectionChanged(0);
        }

        public int SelectedBuildingOptionsCount()
        {
            return 1;
        }

        public Boolean BuildingOptions_Selected(int row)
        {
            return false;   
        }

        public void SelectBuildingOption(int row, Boolean selected)
        {

        }

        public void SetNextCaption(String caption)
        {

        }
    }
}
