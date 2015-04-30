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
            OrdersForm screen = new OrdersForm();
            OrderPresenter presenter = new OrderPresenter(screen);
            screen.ShowDialog();
        }

        private void btnUpdateFactory_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            IOrder order = new Order();
            NewOrderForm screen = new NewOrderForm();
            NewOrderPresenter presenter = new NewOrderPresenter(screen, order);
            screen.ShowDialog();
        }

        private void frmDialogue_Load(object sender, EventArgs e)
        {
            // We will need the BuildingFactory but Buildings need to self-register first...

            FrameExcellsior.RegisterBuildingType();
            FrameOrchard.RegisterBuildingType();
            FrameBoston.RegisterBuildingType();

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            IOrder order = new Order();
            OrderSearchForm screen = new OrderSearchForm();
            OrderSearchPresenter presenter = new OrderSearchPresenter(screen, order);
            screen.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
