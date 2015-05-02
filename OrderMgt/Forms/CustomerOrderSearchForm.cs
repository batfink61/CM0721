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
    public partial class CustomerOrderSearchForm : Form
    {
        private String _orderId;
        private DataSet _customerOrderDataSet;

        public CustomerOrderSearchForm()
        {
            InitializeComponent();
        }

        private void CustomerOrderSearchForm_Load(object sender, EventArgs e)
        {
            _orderId = "";
            _customerOrderDataSet = OrderGateway.ListCustomerOrders();

            RefreshCustomerOrderList();
     
        }
     
        public String SelectedOrderId()
        {
            return _orderId;
        }

        private void RefreshCustomerOrderList()
        {
            // Should use LINQ here to filter results

            vwOrders.Rows.Clear();
            foreach (DataRow dr in _customerOrderDataSet.Tables[0].Rows)
            {
                if (dr["name"].ToString().ToLower().Contains(txtCustomerName.Text.ToLower()))
                    vwOrders.Rows.Add(new String[] { dr["id"].ToString(), dr["customerid"].ToString(), dr["name"].ToString(), dr["BuildingType"].ToString() });

                    //lstCustomers.Items.Add(String.Format("{0} {1} {2} [{3}]", dr["name"].ToString(), dr["BuildingType"].ToString(), dr["FramePrice"].ToString(), dr["id"].ToString()));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _orderId = "";
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetOrderId();
            this.Close();
        }

        private void lstCustomers_DoubleClick(object sender, EventArgs e)
        {
            SetOrderId();
        }

        private void SetOrderId()
        {
            _orderId = vwOrders.SelectedRows[0].Cells[0].Value.ToString();
         }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            RefreshCustomerOrderList();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vwOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetOrderId();
            this.Close();
        }
    }
}
