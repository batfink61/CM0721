using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// Concrete instance fo the Excellsior building type.
// BASE class is responsible for reading definition from file.
// This is SELF-REGISTERING with the BUILDINGFACTORY

namespace OrderMgt
{
    class FrameExcellsior: FrameBase, IBuilding
    {
        private const String _name="Excellsior";


        public FrameExcellsior()
            : base(_name)
        {
        }

        public IBuilding CreateBuilding()
        {
            return new FrameExcellsior();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameExcellsior());
        }

    }
}
