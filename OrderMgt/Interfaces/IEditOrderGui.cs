using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Order UI interface implemented by the Order forms and
// used by the CustomerPresenter to access the UI

namespace OrderMgt
{
    public interface IEditOrderGui
    {

        String BuildingType { set; get; }
        String ReceptionRooms { set; }
        String Bedrooms { set; }
        String Bathrooms { set; }

        String FramePrice { set; get; }
        String OptionsPrice { set; }
        String VAT { set; }
        String TotalPrice { set; }

        String CustomerId { set; get; }
        String CustomerName { set; }
        String Address { set; }
        String Town { set; }
        String PostCode { set; }
        String Telephone { set; }
        String Mobile { set; }
        String Registered { set; }

        //List<Tuple<String, String, String, String>> SelectedBuildingOptions();

        void AddBuildingType(String buildingType);
        void ClearBuildingOptions();
        int SelectedBuildingOptionsCount();
        void SelectBuildingOption(int row, Boolean selected);
        Boolean BuildingOptions_Selected(int row);
        void AddBuildingOption(String[] row);
        String[] GetBuildingOption(int row);
        void SetNextCaption(String caption);
        void ShowMessage(String message);
        void Close();
        void grpCustomerSearch_Enable(Boolean enabled);
        void Register(EditOrderPresenter EditOrderPresenter);
        void SetCurrentBuildingOption(int index);
        void SetTab(String tabName);
    }
}
