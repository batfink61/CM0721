using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderManager
    {
        private static OrderManager instance; 

        private OrderManager() { }

        public static OrderManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderManager();
                }
                return instance;
            }
        }

        public OrderStatus ManageOrderUpdate(Order o)
        {
            switch (o.Status)
            {
                case OrderStatus.Planning:
                    if(this.CheckPlanningComplete(o))
                    {
                        //Do any actions like fire off an invoice for the full payment
                        return OrderStatus.Contract;
                    }
                    //check for planning rejected
                    break;
                case OrderStatus.Contract:
                    if (this.CheckContractComplete(o))
                    {
                        
                        //Maybe need the sceduler or oerder object to do something with this now.
                        return OrderStatus.Scheduled;
                    }
                    break;
                case OrderStatus.Scheduled:
                    if (this.CheckContractComplete(o))
                    {

                        //Maybe need the sceduler or oerder object to do something with this now.
                        return OrderStatus.Contract;
                    }
                    break;
                default:
                    // You cannot "fall through" any switch section, including
                    // the last one. 
                    break;
               
            }
                return o.Status;
        }

        private Boolean CheckPlanningComplete(Order o)
        {
            //Instialise status flag
            Boolean planningComplete = false;
            
            if (o.PlanningGranted != null && o.PlanningInvoice != null)            
            {
               planningComplete = true;
               return planningComplete;    
            }

            return planningComplete;
        }

        private Boolean CheckContractComplete(Order o)
        {
            //Instialise status flag
            Boolean contractComplete = false;

            if (o.ContractSigned != null && o.OrderInvoice != null)
            {
                contractComplete = true;
                return contractComplete;
            }
            return contractComplete;
        }
    
    }
                  
}
