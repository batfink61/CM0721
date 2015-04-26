using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IBuildingType
    {
        String Name { get; }
        Decimal FramePrice { get; }
        int Bedrooms { get; }
        int Bathrooms { get; }
        int ReceptionRooms { get; }
        int Area { get; }
        IBuildingType CreateBuilding();
    }
}
