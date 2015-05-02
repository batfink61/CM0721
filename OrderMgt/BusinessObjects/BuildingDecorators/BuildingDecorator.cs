using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// This is the BASE class for the building decorator.
// It currently only handles decorating Name and Price but in time, as new option types are added, it
// could easily be extended to decorate bedrooms, reception rooms etc.

namespace OrderMgt
{
    public abstract class BuildingDecorator : IBuilding
    {
        protected String m_name="Undefined building option";
        protected Decimal m_price=0;
        IBuilding _baseFrame;

        protected BuildingDecorator(IBuilding baseFrame)
        {
            _baseFrame = baseFrame;
        }

        public virtual String Name
        {
            get
            { return String.Format("{0} {1}", _baseFrame.Name, m_name); }
        }

        public virtual Decimal Price
        {
            get
            { return _baseFrame.Price + m_price; }
        }

        #region Building methods and Properties
        public int Bedrooms
        {
            get
            { return 0; }
        }
        public int Bathrooms
        {
            get
            {return 0; }
        }
        public int ReceptionRooms
        {
            get
            { return 0; }
        }
        public int Area
        {
            get
            { return 0; }
        }
        public int ConstructionDays
        {
            get
            { return 0; }
        }
        public IBuilding CreateBuilding()
        {
            return null;
        }
        #endregion
    }
}
