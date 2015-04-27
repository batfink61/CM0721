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
    public partial class ChooseOrdersForm : Form
    {

        private String _orderId;
        private DataSet _orderDataSet;

        public ChooseOrdersForm()
        {
            InitializeComponent();
        }
        private void ChooseOrdersForm_Load(object sender, EventArgs e)
        {
            _orderId = "";
            _orderDataSet = OrderGateway.list();

            RefreshOrderList();
        }

        public String SelectedOrderId()
        {
            return _orderId;
        }

        private void RefreshOrderList()
        {
            // Should use LINQ here to filter results

            lstOrders.Items.Clear();
            foreach (DataRow dr in _orderDataSet.Tables[0].Rows)
            {
                lstOrders.Items.Add(String.Format("{0} {1} [{2}]", dr["BuildingType"].ToString(), dr["FramePrice"].ToString(), dr["id"].ToString()));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetOrderId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _orderId = "";
            this.Close();
        }
        private void SetOrderId()
        {
            String selectedItem = lstOrders.SelectedItem.ToString();
            int p1 = selectedItem.IndexOf("[");
            if (p1 > 0)
            {
                int p2 = selectedItem.IndexOf("]");
                if (p2 > p1)
                {
                    _orderId = selectedItem.Substring(p1 + 1, p2 - p1 - 1);
                    MessageBox.Show(_orderId.ToString());
                    //this.Close();
                }
            }
        }


    }
}
