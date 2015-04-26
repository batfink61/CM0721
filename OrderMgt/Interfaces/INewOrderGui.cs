using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface INewOrderGui
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
        void EnableControls(Boolean enabled);
        void Register(NewOrderPresenter newOrderPresenter);

        void SetTab(String tabName);
    }
}
