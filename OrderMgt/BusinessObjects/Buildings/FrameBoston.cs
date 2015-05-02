using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Concrete instance fo the BOSTON building type.
// BASE class is responsible for reading definition from file.
// This is SELF-REGISTERING with the BUILDINGFACTORY

namespace OrderMgt
{
    class FrameBoston: FrameBase, IBuilding
    {
        private const String _name="Boston";

        public FrameBoston()
            : base(_name)
        {
        }

        public IBuilding CreateBuilding()
        {
            return new FrameBoston();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameBoston());
        }

    }
}
