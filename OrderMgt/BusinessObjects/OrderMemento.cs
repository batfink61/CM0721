using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderMemento
    {
        private Nullable<DateTime> _foundationReady;
        private Nullable<DateTime> _estimatedFab;
        private Nullable<DateTime> _assemblyDate;
        private Nullable<DateTime> _contractSigned;
        private Nullable<DateTime> _planningGranted;
        private Nullable<DateTime> _planningRejected;
        private Nullable<DateTime> _planningInvoice;
        private Nullable<DateTime> _orderInvoice;
        private Nullable<DateTime> _delayInvoice;

        public OrderMemento(Order order)
        {
            _foundationReady = order.FoundationReady;
            _estimatedFab = order.EstimatedFab;
            _assemblyDate = order.AssemblyDate;
            _contractSigned = order.ContractSigned;
            _planningGranted = order.PlanningGranted;
            _planningRejected = order.PlanningRejected;
            _planningInvoice = order.PlanningInvoice;
            _orderInvoice = order.OrderInvoice;
            _delayInvoice = order.DelayInvoice;
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
    }
}
