using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// Concrete building decorator class.
// Inherits from BuildingDecorator.
// This dynamic decorator takes name and price from a table.

namespace OrderMgt
{
    public class BuildingOptionDecorator : BuildingDecorator
    {
        protected String m_name;
        protected Decimal m_price;
        protected IBuilding m_buildingBase;

        public BuildingOptionDecorator(IBuilding buildingBase, String optionId)
            : base(buildingBase)
        {
            // Assign base
            m_buildingBase = buildingBase;

            // read definition for this instance of decorator from decorator table using the decorator gateway
            DataSet ds = BuildingGateway.FindOption(optionId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                m_name = (String)ds.Tables[0].Rows[0]["OptionName"];
                m_price = (Decimal)ds.Tables[0].Rows[0]["OptionPrice"];
            }
        }

        public override String Name
        {
            get
            { return String.Format("{0} {1}", m_buildingBase.Name, m_name); }
        }

        public override Decimal Price
        {
            get
            { return m_buildingBase.Price + m_price; }
        }
    }
}
