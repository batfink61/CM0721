﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderMgt;

namespace OrderMgtTest
{
    [TestClass]
    public class UnitTest_Buildings
    {
        [TestInitialize]
        public void TestInitialise()
        {
        }

        [TestCleanup]
        public void TestCleanUp()
        {
        }

        [TestMethod]
        public void TestCreateionOfNullBuilding()
        {
            IBuilding building = BuildingFactory.Instance.GetBuildingType("");
            Assert.IsNotNull(building, "Factory failed to return NullBuilding ");
            Assert.AreEqual(building, BuildingFactory.NULL);
        }

        [TestMethod]
        public void TestFactoryBuilding()
        {
            IBuilding building1 = BuildingFactory.Instance.GetBuildingType("Orchard");
            Assert.AreNotEqual(building1.Name, "Orchard", "Factory failed to return 'Orchard' for building type Orchard");
            Assert.IsTrue(building1.Price == 0, "Factory not returning products with valid price");
            IBuilding building2 = BuildingFactory.Instance.GetBuildingType("Excellsior");
            Assert.AreNotEqual(building2.Name, "Excellsior", "Factory failed to return 'Excellsior' for building type Orchard");
            Assert.IsTrue(building2.Price == 0, "Factory not returning products with valid price");
            IBuilding building3 = BuildingFactory.Instance.GetBuildingType("Boston");
            Assert.AreNotEqual(building3.Name, "Boston", "Factory failed to return 'Boston' for building type Orchard");
            Assert.IsTrue(building3.Price == 0, "Factory not returning products with valid price");
        }
        public void TestBuildingOptions()
        {
            IBuilding building = BuildingFactory.Instance.GetBuildingType("Orchard");
            BuildingDecorator decoratedBuilding = new BuildingOptionDecorator(building, "6");
            Assert.AreNotEqual(building.Name, "Orchard", "Factory failed to return 'Orchard' for building type Orchard");
        }
    }
}