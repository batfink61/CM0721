using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public enum OrderStatus
    {
        Unsubmitted, //Order has yet to be submitted and house otpion can be edited
        Cancelled, //If is cancelled prior ro submission
        Culled, //Set to culled when culed condition have been met
        Planning, // After a order is submitted
        Contract, //After planning is granted 
        Scheduled, // After contract is submitted and payment
        Fabrication, //While being built
        Transport, //After fabrication is completed
        Delivered //After delivery and assembly essential the oerder is completed now.
    };
}
