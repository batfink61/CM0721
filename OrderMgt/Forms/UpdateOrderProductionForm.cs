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
    public partial class UpdateOrderProductionForm : Form, IUpdateOrderProduction
    {
        UpdateOrderProductionPresenter _presenter;

        public UpdateOrderProductionForm()
        {
            InitializeComponent();
        }
        public void Register(UpdateOrderProductionPresenter presenter)
        {
            _presenter = presenter;
        }
        public void ShowMessage(String s)
        {
            MessageBox.Show(s);
        }
        public String LastOrderId
        {
            set
            {
                txtLastOrder.Text = value;
            }
            get
            {
                return txtLastOrder.Text;
            }
        }
        public String CurrentOrderId
        {
            set
            {
                txtCurrentOrder.Text = value;
            }
            get
            {
                return txtCurrentOrder.Text;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String errMessage = _presenter.ValidateData();
            if (errMessage != string.Empty)
            {
                ShowMessage(errMessage);
                return;
            }
            _presenter.setOrderStatus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
