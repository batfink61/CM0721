using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OrderMgt
{
    class FrameBase
    {
        private String _name = "";
        private Decimal _price=0;
        private int _bedrooms=0;
        private int _bathrooms=0;
        private int _receptionRooms=0;
        private int _area=0;
        private int _constructionDays=0;

        public FrameBase()
        { }
        
        public FrameBase(String name)
        {
            DataSet ds = BuildingGateway.Find(name);

            _name = name;
            _price = (Decimal)ds.Tables[0].Rows[0]["FramePrice"];
            _bedrooms = (int)ds.Tables[0].Rows[0]["Bedrooms"];
            _bathrooms = (int)ds.Tables[0].Rows[0]["Bathrooms"];
            _receptionRooms = (int)ds.Tables[0].Rows[0]["Reception"];
            _area = (int)ds.Tables[0].Rows[0]["Area"];
            _constructionDays = (int)ds.Tables[0].Rows[0]["ConstructionDays"];
        }
        
        public virtual String Name
        {
            get
            {
                return _name;
            }
        }

        public Decimal Price
        {
            get
            {
                return _price;
            }
        }
        public int Bedrooms
        {
            get
            {
                return _bedrooms;
            }
        }
        public int Bathrooms
        {
            get
            {
                return _bathrooms;
            }
        }
        public int ReceptionRooms
        {
            get
            {
                return _receptionRooms;
            }
        }
        public int Area
        {
            get
            {
                return _area;
            }
        }
        public int ConstructionDays
        {
            get
            {
                return _constructionDays;
            }
        }

    }


}
