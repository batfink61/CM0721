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
    public partial class UpdateOrderForm : Form, IUpdateOrderGui
    {
        private UpdateOrderPresenter _presenter;
        
        public UpdateOrderForm()
        {
            InitializeComponent();
            
        }

        public void Register(UpdateOrderPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }
                
        public OrderStatus OrderStatus 
        {
            set
            {
                lblStatus.Text = value.ToString();
            }
        }
        
        public Boolean PlanningInvoice 
        {
            set
            {
                chkPlanningInvoice.Checked = value;
            }
            get
            {
                return chkPlanningInvoice.Checked;
            }
        }
        public Boolean PlanningGranted
        {
            set
            {
                chkPlanning.Checked = value;
            }
            get
            {
                return chkPlanning.Checked;
            }
        }

        public Boolean PlanningRejected
        {
            set
            {
                chkRejected.Checked = value;
            }
            get
            {
                return chkRejected.Checked;
            }
        }
        
        public String PlanningGrantedDate
        {
            set
            {
                chkPlanning.Text = value;
            }
            get
            {
                return chkPlanning.Text;
            }
        }

        public String PlanningRejectedDate
        {
            set
            {
                chkRejected.Text = value;
            }
            get
            {
                return chkRejected.Text;
            }
        }

        public String OrderId
        {
            set
            {
                lblOrderIDTxt.Text = value;
            }
            get
            {
                return lblOrderIDTxt.Text;
            }
        }

        public Boolean ContractSigned 
        {
            set
            {
                chkContract.Checked = value;
            }
            get
            {
                return chkContract.Checked;
            }
        }

        public String ContractSignedDate
        {
            set
            {
                chkContract.Text = value;
            }
            get
            {
                return chkContract.Text;
            }
        }
        
        public DateTime FoundationDate 
        {
            set
            {
                dtpFoundationDate.Value = value;
            }
            get
            {
                return dtpFoundationDate.Value;
            }
        }

        public Boolean OrderInvoice 
        {
            set
            {
                chkOrderInvoice.Checked = value;
            }
            get
            {
                return chkOrderInvoice.Checked;
            }
        }

        public Boolean DelayInvoice
        {
            set
            {
                chkDelayInvoice.Checked = value;
            }
            get
            {
                return chkDelayInvoice.Checked;
            }
        }

        public String PlanningInvoiceDate
        {
            set
            {
                chkPlanningInvoice.Text = value;
            }
            get
            {
                return chkPlanningInvoice.Text;
            }
        }

        public String OrderInvoiceDate
        {
            set
            {
                chkOrderInvoice.Text = value;
            }
            get
            {
                return chkOrderInvoice.Text;
            }
        }

        public String DelayInvoiceDate
        {
            set
            {
                chkDelayInvoice.Text = value;
            }
            get
            {
                return chkDelayInvoice.Text;
            }
        }
        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing
            //chkPlanning.Enabled = false;
            //grpPlanning.Enabled = false; 
        }

        public void EnablePlanningRejected(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing
            chkRejected.Enabled = enabled;
            //grpPlanning.Enabled = false; 
        }

        public void EnablePlanningGroup(Boolean enabled)
        {
            grpPlanning.Enabled = enabled; 
        }

        public void EnableContractGroup(Boolean enabled)
        {
            grpPlanning.Enabled = enabled;
        }

        public void EnableAssemblyGroup(Boolean enabled)
        {
            grpAssembly.Enabled = enabled;
        }

        public void ToggleFoundationDate(Boolean enabled)
        {
            dtpFoundationDate.Enabled = enabled;
        }


        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            // The Order search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID
            _presenter.getOrderToUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.UpdateOrder();
        }

        private void chkPlanning_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.planningGrantedChanged();
        }

        private void chkRejected_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.planningRejectedChanged();
        }


        private void chkContract_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.contractSignedChanged();
        }

        private void chkPlanningInvoice_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.planningInvoiceChanged();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _presenter.undoChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.close();
        }

        private void chkOrderInvoice_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.orderInvoiceChanged();
        }

        private void dtpFoundationDate_ValueChanged(object sender, EventArgs e)
        {
            this.FoundationDate = dtpFoundationDate.Value;
            _presenter.foundationDateChanged(this.FoundationDate);
        }



    }
}
