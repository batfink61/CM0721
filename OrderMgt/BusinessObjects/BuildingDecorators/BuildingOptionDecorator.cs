using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OrderMgt
{
    class BuildingOptionDecorator : BuildingDecorator
    {
        public BuildingOptionDecorator(IBuilding buildingBase, String optionId)
            : base(buildingBase)
        {
            DataSet ds = BuildingGateway.FindOption(optionId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.m_name = (String)ds.Tables[0].Rows[0]["OptionName"];
                this.m_price = (Decimal)ds.Tables[0].Rows[0]["OptionPrice"];
            }
        }
        
    }
}
