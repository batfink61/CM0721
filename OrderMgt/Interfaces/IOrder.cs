using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Order interface used to pass reference for all Orders.

namespace OrderMgt
{
    public interface IOrder
    {
        String OrderId { get; }
        String CustomerId { set; get; }
        String BuildingType { get; }
        int ReceptionRooms { get; }
        int Bedrooms { get; }
        int Bathrooms { get; }
        Decimal FramePrice { get; }
        Decimal TotalPrice { get; }
        Decimal Vat { get; }
        Decimal OptionsPrice { get; }
        OrderStatus Status { set; get; }
        Nullable<DateTime> FoundationReady { set; get; }
        Nullable<DateTime> EstimatedFab { set; get; }
        Nullable<DateTime> AssemblyDate { set; get; }
        Nullable<DateTime> ContractSigned { set; get; }
        Nullable<DateTime> PlanningGranted { set; get; }
        Nullable<DateTime> PlanningRejected { set; get; }
        Nullable<DateTime> PlanningInvoice { set; get; }
        Nullable<DateTime> OrderInvoice { set; get; }
        Nullable<DateTime> DelayInvoice { set; get; }

        void ClearOptions();
        void SetFrame(String building);
        void AddOption(String optionName);
        void Save();

        int OptionsCount { get; }
        String Option(int index);
        string CheckStatus();
        OrderMemento SaveOrderMemento();
        void RestoreMemento(OrderMemento memento);
    }
}
