using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Building interface used to pass reference for all buildings.

namespace OrderMgt
{
    public interface IBuilding
    {
        String Name { get; }
        Decimal Price { get; }
        int Bedrooms { get; }
        int Bathrooms { get; }
        int ReceptionRooms { get; }
        int Area { get; }
        IBuilding CreateBuilding();
    }
}
