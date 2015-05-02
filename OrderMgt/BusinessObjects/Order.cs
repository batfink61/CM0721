using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// The order class implements the IOrder interface which is used throughout the app.

namespace OrderMgt
{
    public class Order: IOrder
    {
        private Boolean _isNewOrder;
        private String _orderId;
        private String _customerId;
        private String _buildingType;
        private Decimal _framePrice;
        private decimal _optionsPrice;
        private Decimal _totalPrice;
        private Decimal _vat;
        private DateTime _created;
        private IBuilding _frame;
        
        private Boolean _requiresRecalculation = false;
        private OrderStatus _status;

        private DataSet _ds;

        public Order()
        {
            // Instanciated without an order id so we can assume it's a new order
            // Use -1 to indicate this is a new order.

            _orderId = "-1";

            Initialise();
        }

        public Order(String orderId)
        {
            _orderId = orderId;

            Initialise();
        }

        public void SetFrame(String buildingType)
        {
            _buildingType = buildingType;
            _frame = BuildingFactory.Instance.GetBuildingType(_buildingType);
            _requiresRecalculation = true;
        }

        public void ClearOptions()
        {
            // Remove all options for the current building.

            _ds.Tables["orderbuildingOptions"].Clear();
            _requiresRecalculation = true;
        }

        public int OptionsCount
        {
            get
            { return _ds.Tables["orderbuildingoptions"].Rows.Count; }
        }

        public String Option(int index)
        {
            return _ds.Tables["orderbuildingoptions"].Rows[index]["buildingoption"].ToString();
        }

        public void AddOption(String optionId)
        {
            DataRow newOption = _ds.Tables["orderbuildingOptions"].NewRow();
            
            // Adding a new option we need to get option price from the list of all
            // possible options and add this to our building options.

            newOption["orderid"] = _orderId;
            newOption["buildingoption"] = optionId;
            newOption["price"] = _ds.Tables["possibleBuildingOptions"].Select(String.Format("id={0}", optionId))[0]["optionprice"].ToString();

            _ds.Tables["orderbuildingOptions"].Rows.Add(newOption);
            _requiresRecalculation = true;
        }

        private void Recalculate()
        {
            // Recalculate the price.
            // Uses the building decorator to decorate the building with all of the selected options.
            // This allows us to get the final price. In time these options could decorate with extra rooms/facilities and these
            // would be exposed through the IOrder interface.

            List<BuildingDecorator> decoratedBuildingList = new List<BuildingDecorator>();

            if (_ds.Tables["orderbuildingOptions"].Rows.Count > 0)
            {
                int i=0;
                foreach (DataRow dr in _ds.Tables["orderbuildingOptions"].Rows)
                {
                    BuildingDecorator decoratedBuilding = null;

                    if (i == 0)
                        decoratedBuilding = new BuildingOptionDecorator(_frame, _ds.Tables["orderbuildingOptions"].Rows[i]["buildingoption"].ToString());
                    else
                        decoratedBuilding = new BuildingOptionDecorator(decoratedBuildingList[i - 1], _ds.Tables["orderbuildingOptions"].Rows[i]["buildingoption"].ToString());

                    decoratedBuildingList.Add(decoratedBuilding);
                    i++;
                }

                _framePrice = _frame.Price;
                _totalPrice = decoratedBuildingList[decoratedBuildingList.Count-1].Price;
                _optionsPrice = _totalPrice - _framePrice;
                _vat = _totalPrice * Properties.Settings.Default.vatrate;
            }
            else
            {
                // No options selected so price, area and VAT all based on the frame price only
                _framePrice = _frame.Price;
                _totalPrice = _frame.Price;
                _optionsPrice = 0;
                _vat = _totalPrice * Properties.Settings.Default.vatrate;
            }

            _requiresRecalculation = false;
        }

        public String CustomerId
        {
            get
            { return _customerId; }
            set
            { _customerId = value; }
        }

        public String BuildingType
        {
            get
            { 
                return _buildingType; 
            }
        }

        public Decimal FramePrice
        {
            get
            { return _framePrice; }

        }

        public Decimal OptionsPrice
        {

            get
            {
                if (_requiresRecalculation)
                    Recalculate();
                return _optionsPrice;
            }
        }

        public Decimal TotalPrice
        {
            get
            {
                if (_requiresRecalculation)
                    Recalculate();
                return _totalPrice;
            }
        }

        public Decimal Vat
        {
            get
            {
                if (_requiresRecalculation)
                    Recalculate();
                return _vat;
            }
        }

        public int ReceptionRooms
        {
            get
            {
                return _frame.ReceptionRooms;
            }
        }

        public int Bedrooms
        {
            get
            {
                return _frame.Bedrooms;
            }
        }

        public int Bathrooms
        {
            get
            {
                return _frame.Bathrooms;
            }
        }

        public OrderStatus Status
        {
            get
            { return _status; }
            set
            {
              _status = value;
            }
        }

        public Nullable<DateTime> PlanningGranted
        {
            get
            { return getOrderDate("PlanningGranted"); }
            set
            { setOrderDate("PlanningGranted",value); }
        }

        public Nullable<DateTime> PlanningRejected
        {
            get
            { return getOrderDate("PlanningRejection"); }
            set
            { setOrderDate("PlanningRejection", value); }
        }

        public Nullable<DateTime> FoundationReady
        {
            get
            { return getOrderDate("FoundationDate"); }
            set
            { setOrderDate("FoundationDate", value); }
        }

        public Nullable<DateTime> EstimatedFab
        {
            get
            { return getOrderDate("EstimateFabDate"); }
            set
            { setOrderDate("EstimateFabDate", value); }
        }

        public String OrderId
        {
            get
            { return _orderId; }
        }

        public Nullable<DateTime> AssemblyDate
        {
            get
            { return getOrderDate("AssemblyDate"); }
            set
            { setOrderDate("AssemblyDate", value); }
        }

        public Nullable<DateTime> ContractSigned
        {
            get
            { return getOrderDate("ContractSigned"); }
            set
            { setOrderDate("ContractSigned", value); }
        }

        public Nullable<DateTime> PlanningInvoice
        {
            get
            { return getOrderDate("PlanningInvoice"); }
            set
            { setOrderDate("PlanningInvoice", value); }
        }

        public Nullable<DateTime> OrderInvoice
        {
            get
            { return getOrderDate("OrderInvoice"); }
            set
            { setOrderDate("OrderInvoice", value); }
        }

        public Nullable<DateTime> DelayInvoice
        {
            get
            { return getOrderDate("DelayInvoice"); }
            set
            { setOrderDate("DelayInvoice", value); }
        }

        private Nullable<DateTime> getOrderDate(String key)
        {
            if (_ds.Tables["order"].Rows[0][key] == DBNull.Value)
                return new Nullable<DateTime>();
            else
                return DateTime.Parse(_ds.Tables["order"].Rows[0][key].ToString());
        }

        private void setOrderDate(String key, Nullable<DateTime> value)
        {
            if (value == null)
                _ds.Tables["order"].Rows[0][key] = DBNull.Value;
            else
                _ds.Tables["order"].Rows[0][key] = value;
        }

        private void Initialise()
        {
            // Use order Gateway for all SQL I/O

            _ds = OrderGateway.Find(_orderId);

            if (_ds.Tables[0].Rows.Count > 0)
            {
                _isNewOrder = false;

                _customerId = _ds.Tables[0].Rows[0]["CustomerId"].ToString();
                _buildingType = _ds.Tables[0].Rows[0]["BuildingType"].ToString();
                _framePrice = (Decimal)_ds.Tables[0].Rows[0]["FramePrice"];
                _status = (OrderStatus)Int32.Parse(_ds.Tables[0].Rows[0]["Status"].ToString());
            }
            else
            {
                _isNewOrder = true;
                _ds.Tables[0].Rows.Add(_ds.Tables[0].NewRow());
                _ds.Tables[0].Rows[0]["Created"] = DateTime.Now;
                _ds.Tables[0].Rows[0]["Status"] = OrderStatus.Unsubmitted;
            }
        }

        public string CheckStatus()
        {
            OrderStatus oldStatus = this.Status;
            this.Status = OrderManager.Instance.ManageOrderUpdate(this);

            if (oldStatus != this.Status)
                return "Order Status Updated: " + this.Status;

            return "Order Status Not Updated";
        }
          
        public OrderMemento SaveOrderMemento()
        {
            return new OrderMemento(this);
        }
 
        // Restores memento
        public void RestoreMemento(OrderMemento memento)
        {
         
            this.PlanningGranted = memento.PlanningGranted;
            this.PlanningRejected = memento.PlanningRejected;
            this.FoundationReady = memento.FoundationReady;
            this.AssemblyDate = memento.AssemblyDate;
            this.EstimatedFab = memento.EstimatedFab;
            this.ContractSigned = memento.ContractSigned;
            this.PlanningInvoice = memento.PlanningInvoice;
            this.OrderInvoice = memento.OrderInvoice;
            this.DelayInvoice = memento.DelayInvoice;
        }

        public void Save()
        {
            // Ensure all datatable values have been set.
            // These were stored in local variables for performance, now we're going to save
            // they need to be inserted into the table.

            _ds.Tables[0].Rows[0]["CustomerId"] = _customerId;
            _ds.Tables[0].Rows[0]["BuildingType"] = _buildingType;
            _ds.Tables[0].Rows[0]["FramePrice"] = _framePrice;
            _ds.Tables[0].Rows[0]["Status"] = _status;
           

            if (_isNewOrder)
                _ds.Tables[0].Rows[0]["Created"] = DateTime.Now;

            OrderGateway.Save(_ds);

            _isNewOrder = false; // No longer a new order!
        }
  }
}