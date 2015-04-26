using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Passive View form providing the GUI for for customer maintenance.

namespace OrderMgt
{
    public partial class CustomersForm : Form, ICustomerGui
    {
        private CustomerPresenter _presenter;

        public CustomersForm()
        {
            InitializeComponent();
        }

        public void Register(CustomerPresenter presenter)
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
                txtCustomerName.Text = value;
            }
            get
            {
                return txtCustomerName.Text;
            }
        }

        public String Address
        {
            set
            {
                txtAddress.Text = value;
            }
            get
            {
                return txtAddress.Text;
            }
        }

        public String Town
        {
            set
            {
                txtTown.Text = value;
            }
            get
            {
                return txtTown.Text;
            }
        }

        public String PostCode
        {
            set
            {
                txtPostCode.Text = value;
            }
            get
            {
                return txtPostCode.Text;
            }
        }

        public String Telephone
        {
            set
            {
                txtTelephone.Text = value;
            }
            get
            {
                return txtTelephone.Text;
            }
        }

        public String Mobile
        {
            set
            {
                txtMobile.Text = value;
            }
            get
            {
                return txtMobile.Text;
            }
        }


        public String Registered
        {
            // This is a read-only field used to show when the customer was registered

            set
            {
                txtRegistered.Text = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // The search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID

            CustomerSearchForm search = new CustomerSearchForm();
            search.ShowDialog();
            txtCustomerId.Text = search.SelectedCustomerId();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtCustomerId_TextChanged();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtCustomerName_TextChanged();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtAddress_TextChanged();
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtTown_TextChanged();
        }

        private void txtPostCode_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtPostCode_TextChanged();
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtTelephone_TextChanged();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtMobile_TextChanged();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.btnSave_Click();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _presenter.btnNew_Click();
        }

        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing

            txtAddress.Enabled = enabled;
            txtTown.Enabled = enabled;
            txtPostCode.Enabled = enabled;
            txtCustomerName.Enabled = enabled;
            txtTelephone.Enabled = enabled;
            txtMobile.Enabled = enabled;
        }


    }
}
