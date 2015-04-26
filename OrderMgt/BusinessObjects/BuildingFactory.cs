using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

// Building factory class - responsible for creating building objects using the Factory Pattern.

namespace OrderMgt
{
    public class BuildingFactory
    {
        private Hashtable BuildingMap = new Hashtable();
        public static readonly IBuilding NULL = new NullBuilding();

        #region Singleton instanciation
        
        private static BuildingFactory instance = new BuildingFactory();
        public static BuildingFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private BuildingFactory() { }
        
        #endregion

        public void RegisterBuilding(String buildingType, IBuilding building)
        {
            if (!BuildingMap.ContainsKey(buildingType))
                BuildingMap[buildingType] = building;
        }

        public IBuilding GetBuildingType(String buildingType)
        {
            IBuilding building = null; // Need to instanciate a pointer to keep compiler happy

            // If we have a definition for the buildingType requested by the client then create an instance
            // of that type and reference using the IBuilding interface

            if (BuildingMap.ContainsKey(buildingType))
            {
                building = (IBuilding)BuildingMap[buildingType];

                return building.CreateBuilding();
            }
            else
            {
                return NULL;
            }
        }

        private class NullBuilding : FrameBase, IBuilding
        {
            public IBuilding CreateBuilding()
            {
                return null;
            }
        }
    }
}
