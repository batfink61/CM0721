using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// This is effectively the client application

namespace OrderMgt
{
    public partial class frmDialogue : Form
    {
        public frmDialogue()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // Invoke Customer maintenance form using passive view

            CustomersForm screen = new CustomersForm();
            CustomerPresenter presenter = new CustomerPresenter(screen);
            screen.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            // invoke order search form then pass result to appropriate editing form.

            CustomerOrderSearchForm srch = new CustomerOrderSearchForm();
            srch.ShowDialog();

            String orderId = srch.SelectedOrderId();

            if (orderId != "")
            {
                IOrder order = new Order(orderId);

                if (order.Status == OrderStatus.Unsubmitted)
                    InvokeUnsubmittedOrderForm(order);
                else
                    InvokeSubmittedOrderForm(order);
            }
        }

        private void InvokeUnsubmittedOrderForm(IOrder order)
        {
            // Invoke unsubmitted order maintenance form.
            // Uses passive-view with dependancy injection

            EditOrderForm screen = new EditOrderForm();
            EditOrderPresenter presenter = new EditOrderPresenter(screen, order);
            screen.ShowDialog();
        }

        private void InvokeSubmittedOrderForm(IOrder order)
        {
            // Invoke unsubmitted order maintenance form.
            // Uses passive-view with dependancy injection

            UpdateOrderForm screen = new UpdateOrderForm();
            UpdateOrderPresenter presenter = new UpdateOrderPresenter(screen, order);
            screen.ShowDialog();
        }
        
        private void btnUpdateFactory_Click(object sender, EventArgs e)
        {
            UpdateOrderProductionForm screen = new UpdateOrderProductionForm();
            UpdateOrderProductionPresenter presenter = new UpdateOrderProductionPresenter(screen);
            screen.ShowDialog();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            // invoke EditOrders form using passive view for a new order.

            IOrder order = new Order();
            EditOrderForm screen = new EditOrderForm();
            EditOrderPresenter presenter = new EditOrderPresenter(screen, order);
            screen.ShowDialog();
        }

        private void frmDialogue_Load(object sender, EventArgs e)
        {
            // We will need the BuildingFactory but Buildings need to self-register first...

            FrameExcellsior.RegisterBuildingType();
            FrameOrchard.RegisterBuildingType();
            FrameBoston.RegisterBuildingType();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
