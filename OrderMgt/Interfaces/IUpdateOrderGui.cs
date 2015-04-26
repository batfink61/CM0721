using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IUpdateOrderGui
    {
        //Order summary
        String OrderId { set; get; }
        OrderStatus OrderStatus { set; }
        
        //Planning Phase
        Boolean PlanningInvoice { set; get; }
        Boolean PlanningGranted { set; get; }
        Boolean PlanningRejected { set; get; }
        String PlanningGrantedDate { set; get; }
        String PlanningRejectedDate { set; get; }
        String PlanningInvoiceDate { set; get; }

        //Contract and Paymet Phase
        Boolean ContractSigned { set; get; }
        String ContractSignedDate { set; get; }
        Boolean OrderInvoice { set; get; }
        DateTime FoundationDate { set; get; }
        Boolean DelayInvoice { set; get; }
        String OrderInvoiceDate { set; get; }
        String DelayInvoiceDate { set; get; }

        void ShowMessage(String message);
        void Close();
        void EnableControls(Boolean enabled);
        void Register(UpdateOrderPresenter presenter);

        void EnablePlanningRejected(Boolean enabled);
        void EnablePlanningGroup(Boolean enabled);
        void EnableContractGroup(Boolean enabled);
        void EnableAssemblyGroup(Boolean enabled);
        void ToggleFoundationDate(Boolean enabled);
    }
}
