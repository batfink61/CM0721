using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class UpdateOrderPresenter
    {
        //private Customer _customer;
        private IOrder _order;
        private IUpdateOrderGui _screen;

        public UpdateOrderPresenter(IUpdateOrderGui screen, IOrder order)
        {
            _screen = screen;
            _screen.Register(this);
            _order = order;
            Initialise();
        }

        private void Initialise()
        {
            _screen.EnableControls(false); // Disables textboxes until user selects a customer or clicks 'New'
            OrderCaretaker.Instance.OrderMemento = _order.SaveOrderMemento();
            this.RefreshScreen();
            if (_order.FoundationReady != null)
            {
                _screen.ToggleFoundationDate(false);
            }
            //intially restore the memento as the intial setting is firing events on the check boxes 
            //which in turn is seeting the values to the timedate now a intial reset fixes this.
            this.undoChanges();
            this.lockPlanning();
            this.lockAssembly();
        }

        //On search of create 
        public void getOrderToUpdate()
        {
            _order = new Order(_screen.OrderId);
            OrderCaretaker.Instance.OrderMemento = _order.SaveOrderMemento();
            this.RefreshScreen();
            //intially restore the memento as the intial setting is firing events on the check boxes 
            //which in turn is seeting the values to the timedate now a intial reset fixes this.
            this.undoChanges();
        }

        //Undo any changes made on the form by restoring the memento and updating the form.
        public void undoChanges()
        {
            _order.RestoreMemento(OrderCaretaker.Instance.OrderMemento);
            this.RefreshScreen();
        }

        public void UpdateOrder()
        {
            string message = _order.CheckStatus();
            _order.Save();
            //this should just call a method on the model not actually have the buisness logic here
            //save_ordermodel to db or something like that and then use an order manager object to workout what has changed and 
            //fire off an actions that the , maybe stick a message box on update saying sccess and any resulting actions
            RefreshScreen();
            _screen.ShowMessage(message);
            _screen.Close();
        }
       
        public void close()
        {
            _order = null;
            //close the screen
            _screen.Close();
        }
        //Check box input logic below
        public void planningRejectedChanged()
        {
            if (_screen.PlanningRejected == true)
            {
                _order.PlanningRejected = DateTime.Now;
            }
            else
            {
                _order.PlanningRejected = null;
            }
            RefreshScreen();
        }

        public void planningGrantedChanged()
        {
            if (_screen.PlanningGranted == true)
            {
                _order.PlanningGranted = DateTime.Now;
                //lock the PlanningFailed CheckBox
                _screen.EnablePlanningRejected(false);
            }
            else
            {
                _order.PlanningGranted = null;
                _screen.EnablePlanningRejected(true);
            }
            RefreshScreen();
        }

        public void planningInvoiceChanged()
        {
            if (_screen.PlanningInvoice == true)
            {
                _order.PlanningInvoice = DateTime.Now;
            }
            else
            {
                _order.PlanningInvoice = null;
            }
            RefreshScreen();
        }

        public void contractSignedChanged()
        {
            if (_screen.ContractSigned == true)
            {
                _order.ContractSigned = DateTime.Now;
            }
            else
            {
                _order.ContractSigned = null;
            }
            RefreshScreen();
        }

        public void orderInvoiceChanged()
        {
            if (_screen.OrderInvoice == true)
            {
                _order.OrderInvoice = DateTime.Now;
            }
            else
            {
                _order.OrderInvoice = null;
            }
            RefreshScreen();
        }

      
        public void foundationDateChanged(DateTime foundationDate)
        {
            _order.FoundationReady = foundationDate;
            RefreshScreen();
        }
        private void lockPlanning()
        {
            if (_order.Status != OrderStatus.Planning)
            {
                _screen.EnablePlanningGroup(false);
            }
        }
        
        private void lockContract()
        {
            if (_order.Status != OrderStatus.Planning)
            {
                _screen.EnablePlanningGroup(false);
            }
        }

        private void lockAssembly()
        {
            if (_order.Status != OrderStatus.Transport)
            {
                _screen.EnableAssemblyGroup(false);
            }
        }

        private void RefreshScreen()
        {
            //Set the values returned for the order model to the screen.
            _screen.OrderId = _order.OrderId;
            _screen.OrderStatus = _order.Status;

            //check for presence of a date and set relvant boxes
            if (_order.PlanningGranted == null)
            {
                _screen.PlanningGranted = false;
                _screen.PlanningGrantedDate = "";
            }
            else
            {
                _screen.PlanningGranted = true;
                _screen.PlanningGrantedDate = _order.PlanningGranted.Value.ToString("dd/MM/yyyy");
            }

            if (_order.PlanningRejected == null)
            {
                _screen.PlanningRejected = false;
                _screen.PlanningRejectedDate = "";
            }
            else
            {
                _screen.PlanningRejected = true;
                _screen.PlanningRejectedDate = _order.PlanningRejected.Value.ToString("dd/MM/yyyy");
            }

            if (_order.ContractSigned == null)
            {
                _screen.ContractSigned = false;
                _screen.ContractSignedDate = "";
            }
            else
            {
                _screen.ContractSigned = true;
                _screen.ContractSignedDate = _order.ContractSigned.Value.ToString("dd/MM/yyyy");
            }

            if (_order.PlanningInvoice == null)
            {
                _screen.PlanningInvoice = false;
                _screen.PlanningInvoiceDate = "";
            }
            else
            {
                _screen.PlanningInvoice = true;
                _screen.PlanningInvoiceDate = _order.PlanningInvoice.Value.ToString("dd/MM/yyyy");
            }

            if (_order.OrderInvoice == null)
            {
                _screen.OrderInvoice = false;
                _screen.OrderInvoiceDate = "";
            }
            else
            {
                _screen.OrderInvoice = true;
                _screen.OrderInvoiceDate = _order.OrderInvoice.Value.ToString("dd/MM/yyyy");
            }

            if (_order.FoundationReady != null)
            {
                _screen.FoundationDate = (DateTime)_order.FoundationReady;
            }

            
            //some logic is need to lock access to boxses once an order has passed that status. 
            //eg if contact and planning then lock planning. 
            //_screen.EnableControls(true);
         
        }
    }
}
