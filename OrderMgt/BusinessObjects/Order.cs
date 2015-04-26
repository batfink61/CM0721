using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OrderMgt
{
    public class Order: IOrder
    {
        private Boolean _isNewOrder;
        private String _orderId;
        private String _customerId;
        private String _buildingType;
        private Decimal _framePrice;
        private Decimal _totalPrice;
        private Decimal _vat;
        private DateTime _created;
        private IBuilding _frame;
        private List<String> _buildingOptions = new List<string>();
        
        private Boolean _requiresRecalculation = false;
        private OrderStatus _status;

        private Nullable<DateTime> _foundationReady;
        private Nullable<DateTime> _estimatedFab;
        private Nullable<DateTime> _assemblyDate;
        private Nullable<DateTime> _contractSigned;
        private Nullable<DateTime> _planningGranted;
        private Nullable<DateTime> _planningRejected;
        private Nullable<DateTime> _planningInvoice;
        private Nullable<DateTime> _orderInvoice;
        private Nullable<DateTime> _delayInvoice;
      

        public Order()
        {
            _isNewOrder = true;

            _orderId = "new";
            _customerId = "";
            _created = DateTime.Now;

            _totalPrice = 0;
            // Instantiate building for the order.
            // The BuildingFactory will return a NULL BUILDING object if we don't specify a valid building type

            _buildingType = "";
            _frame = BuildingFactory.Instance.GetBuildingType(_buildingType);
            //_frame = BuildingFactory.Instance.GetBuildingType("");
        }

        public Order(String orderId)
        {
            _isNewOrder = false;

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
            _buildingOptions = new List<string>();
            _requiresRecalculation = true;
        }

        public void AddOption(String optionId)
        {
            _buildingOptions.Add(optionId);
            _requiresRecalculation = true;
        }

        private void Recalculate()
        {
            //_building = BuildingFactory.Instance.GetBuildingType(_buildingType);

            List<BuildingDecorator> decoratedBuildingList = new List<BuildingDecorator>();

            if (_buildingOptions.Count > 0)
            {
                for (int i = 0; i < _buildingOptions.Count; i++)
                {
                    BuildingDecorator decoratedBuilding = null;

                    if (i == 0)
                        decoratedBuilding = new BuildingOptionDecorator(_frame, _buildingOptions[i]);
                    else
                        decoratedBuilding = new BuildingOptionDecorator(decoratedBuildingList[i - 1], _buildingOptions[i]);

                    decoratedBuildingList.Add(decoratedBuilding);
                }

                _framePrice = _frame.Price;
                _totalPrice = decoratedBuildingList[decoratedBuildingList.Count-1].Price;
                _vat = _totalPrice * Properties.Settings.Default.vatrate;
            }
            else
            {
                // No options selected so price, area and VAT all based on teh frame price only
                _framePrice = _frame.Price;
                _totalPrice = _frame.Price;
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
                return _totalPrice - _frame.Price;
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
            { return _planningGranted; }
            set
            { _planningGranted = value; }
        }

        public Nullable<DateTime> PlanningRejected
        {
            get
            { return _planningRejected; }
            set
            { _planningRejected = value; }
        }

        public Nullable<DateTime> FoundationReady
        {
            get
            { return _foundationReady; }
            set
            { _foundationReady = value; }
        }

        public Nullable<DateTime> EstimatedFab
        {
            get
            { return _estimatedFab; }
            set
            { _estimatedFab = value; }
        }

        public String OrderId
        {
            get
            { return _orderId; }
        }

        public Nullable<DateTime> AssemblyDate
        {
            get
            { return _assemblyDate; }
            set
            { _assemblyDate = value; }
        }

        public Nullable<DateTime> ContractSigned
        {
            get
            { return _contractSigned; }
            set
            { _contractSigned = value; }
        }

        public Nullable<DateTime> PlanningInvoice
        {
            get
            { return _planningInvoice; }
            set
            { _planningInvoice = value; }
        }

        public Nullable<DateTime> OrderInvoice
        {
            get
            { return _orderInvoice; }
            set
            { _orderInvoice = value; }
        }

        public Nullable<DateTime> DelayInvoice
        {
            get
            { return _delayInvoice; }
            set
            { _delayInvoice = value; }
        }

        private void Initialise()
        {
            DataSet ds = OrderGateway.Find(_orderId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                _customerId = ds.Tables[0].Rows[0]["CustomerId"].ToString();
                _buildingType = ds.Tables[0].Rows[0]["BuildingType"].ToString();
                _framePrice = (Decimal)ds.Tables[0].Rows[0]["FramePrice"];
                _created = (DateTime)ds.Tables[0].Rows[0]["Created"];
                _status = (OrderStatus)Enum.Parse(typeof(OrderStatus), ds.Tables[0].Rows[0]["Status"].ToString());


                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["PlanningRejection"].ToString()))
                {
                    _planningRejected = null;
                }
                else
                {
                    _planningRejected = (Nullable<DateTime>)ds.Tables[0].Rows[0]["PlanningRejection"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["PlanningGranted"].ToString()))
                {
                    _planningGranted = null;
                }
                else
                {
                    _planningGranted = (Nullable<DateTime>)ds.Tables[0].Rows[0]["PlanningGranted"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["ContractSigned"].ToString()))
                {
                    _contractSigned = null;
                }
                else
                {
                    _contractSigned = (Nullable<DateTime>)ds.Tables[0].Rows[0]["ContractSigned"];
                }
                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["EstimateFabDate"].ToString()))
                {
                    _estimatedFab = null;
                }
                else
                {
                    _estimatedFab = (DateTime)ds.Tables[0].Rows[0]["EstimateFabDate"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["AssemblyDate"].ToString()))
                {
                    _assemblyDate = null;
                }
                else
                {
                    _assemblyDate = (Nullable<DateTime>)ds.Tables[0].Rows[0]["AssemblyDate"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["FoundationDate"].ToString()))
                {
                    _foundationReady = null;
                }
                else
                {
                    _foundationReady = (Nullable<DateTime>)ds.Tables[0].Rows[0]["FoundationDate"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["PlanningInvoice"].ToString()))
                {
                    _planningInvoice = null;
                }
                else
                {
                    _planningInvoice = (Nullable<DateTime>)ds.Tables[0].Rows[0]["PlanningInvoice"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["OrderInvoice"].ToString()))
                {
                    _orderInvoice = null;
                }
                else
                {
                    _orderInvoice = (Nullable<DateTime>)ds.Tables[0].Rows[0]["OrderInvoice"];
                }

                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["DelayInvoice"].ToString()))
                {
                    _delayInvoice = null;
                }
                else
                {
                    _delayInvoice = (Nullable<DateTime>)ds.Tables[0].Rows[0]["DelayInvoice"];
                }


            }
        }

        public string CheckStatus()
        {
            OrderStatus oldStatus = this.Status;
            this.Status = OrderManager.Instance.ManageOrderUpdate(this);
            if (oldStatus != this.Status)
            {
                return "Order Status Updated: " + this.Status;
            }

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
            if (_isNewOrder)
            {
                _orderId = OrderGateway.Create(_customerId, _buildingType, _framePrice, _planningRejected, _planningGranted, _contractSigned, _estimatedFab, _assemblyDate, _foundationReady, _planningInvoice,_orderInvoice,_delayInvoice);
                _isNewOrder = false;
            }
            else
            {
                OrderGateway.Save(this);
            }
        }
  }
}
