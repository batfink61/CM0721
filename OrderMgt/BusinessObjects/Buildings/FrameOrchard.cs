using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Concrete instance fo the ORCHARD building type.
// BASE class is responsible for reading definition from file.
// This is SELF-REGISTERING with the BUILDINGFACTORY

namespace OrderMgt
{
    class FrameOrchard: FrameBase, IBuilding
    {
        private const String _name="Orchard";


        public FrameOrchard()
            : base(_name)
        {
        }

        public IBuilding CreateBuilding()
        {
            return new FrameOrchard();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameOrchard());
        }

    }
}
