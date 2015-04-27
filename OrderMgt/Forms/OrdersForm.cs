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
    public partial class OrdersForm : Form, IOrderGui
    {
        private OrderPresenter _presenter;

        public OrdersForm()
        {
            InitializeComponent();
        }

        public void Register(OrderPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        public String CustomerId
        {
            set
            {
                txtCustomerId.Text = value;
            }
            get
            {
                return txtCustomerId.Text;
            }
        }

        public String CustomerName
        {
            set
            {
                lblName.Text = value;
            }
        }

        public String Address
        {
            set
            {
                lblAddress.Text = value;
            }
        }

        public String Telephone
        {
            set
            {
                lblTelephone.Text = value;
            }
        }

        public String OrderId
        {
            set
            {
                txtOrderId.Text = value;
            }
            get
            {
                return txtOrderId.Text;
            }
        }

        public String BuildingType
        {
            set
            {
               cboBuildingType.SelectedValue = value;
            }
            get
            {
                return cboBuildingType.SelectedValue.ToString();
            }
        }
        public String FramePrice
        {
            set
            {
                txtFramePrice.Text = value.ToString();
            }
            get
            {
                return txtFramePrice.Text;
            }
        }

        public String OptionsPrice
        {
            set
            {
                txtOptionsPrice.Text = value;
            }
        }

        public String VAT
        {
            set
            {
                txtVAT.Text = value;
            }
        }

        public String TotalPrice
        {
            set
            {
                txtTotalPrice.Text = value;
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing

            cboBuildingType.Enabled = enabled;
            txtFramePrice.Enabled = enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtCustomerId_TextChanged();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            // The Customer search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID

            CustomerSearchForm search = new CustomerSearchForm();
            search.ShowDialog();
            txtCustomerId.Text = search.SelectedCustomerId();
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            // The Order search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID

            //OrderSearchForm search = new OrderSearchForm();
            //search.ShowDialog();

            ChooseOrdersForm search = new ChooseOrdersForm();
            search.ShowDialog();
            txtOrderId.Text = search.SelectedOrderId();
            

           //txtOrderId.Text = search.SelectedOrderNumber();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtOrderNumber_TextChanged();
        }

        private void cboBuildingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.cboBuildingType_SelectedIndexChanged();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            _presenter.btnNewOrder_Click();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BuildingGateway.List();
            cboBuildingType.DataSource = ds.Tables[0];
            cboBuildingType.DisplayMember = "TypeCode";
            cboBuildingType.ValueMember= "TypeCode";
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            BuildingOptionsSelectForm frm = new BuildingOptionsSelectForm();
            frm.BuildingType = cboBuildingType.SelectedValue.ToString();
            frm.ShowDialog();

            if (frm.SelectedOption != "")
            {
                int row = vwOptions.Rows.Add();
                vwOptions.Rows[row].Cells[0].Value = frm.SelectedId;
                vwOptions.Rows[row].Cells[1].Value = frm.SelectedOption;
                vwOptions.Rows[row].Cells[2].Value = frm.SelectedPrice;
                
            }
            //    lstOptions.Items.Add(frm.SelectedOption);

        }



    }
}
