using System;
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
            IBuilding building = BuildingFactory.Instance.GetBuildingType("Orchard");
            Assert.AreEqual(building.Name, "", "Factory failed to return 'Orchard' for building type Orchard");
            Assert.IsTrue(building.Price == 0, "Factory not returning products with valid price");
        }

    }
}
