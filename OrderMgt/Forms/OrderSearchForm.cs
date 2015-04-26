using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderMgt
{
    public partial class OrderSearchForm : Form, IOrderSearchGui
    {
        private OrderSearchPresenter _presenter;

        public OrderSearchForm()
        {
            InitializeComponent();
        }
        
        public String OrderId
        {
            set
            {
                txtOrderID.Text = value;
            }
            get
            {
                return txtOrderID.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _presenter.getOrderToUpdate();
            this.Close();
        }

        public void Register(OrderSearchPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

    }
}
