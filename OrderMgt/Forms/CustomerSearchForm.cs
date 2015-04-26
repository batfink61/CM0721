using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

// This is a simple Customer Search modal dialogue.
// It can be invoked from anywhere and the 'SelectedCustomerId' method returns the selected customer

namespace OrderMgt
{
    public partial class CustomerSearchForm : Form
    {
        private String _customerId;
        private DataSet _customerDataSet;

        public CustomerSearchForm()
        {
            InitializeComponent();
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            _customerId = "";
            _customerDataSet = CustomerGateway.list();

            RefreshCustomerList();
        }

        public String SelectedCustomerId()
        {
            return _customerId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshCustomerList();
        }

        private void RefreshCustomerList()
        {
            // Should use LINQ here to filter results

            lstCustomers.Items.Clear();
            foreach (DataRow dr in _customerDataSet.Tables[0].Rows)
            {
                if (dr["name"].ToString().ToLower().Contains(txtCustomerName.Text.ToLower()))
                    lstCustomers.Items.Add(String.Format("{0} [{1}]", dr["name"].ToString(), dr["id"].ToString()));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _customerId = "";
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetCustomerId();
        }

        private void lstCustomers_DoubleClick(object sender, EventArgs e)
        {
            SetCustomerId();
        }

        private void SetCustomerId()
        {
            String selectedItem = lstCustomers.SelectedItem.ToString();
            int p1 = selectedItem.IndexOf("[");
            if (p1 > 0)
            {
                int p2 = selectedItem.IndexOf("]");
                if (p2 > p1)
                {
                    _customerId = selectedItem.Substring(p1 + 1, p2 - p1 - 1);
                    this.Close();
                }
            }
        }

    }
}
