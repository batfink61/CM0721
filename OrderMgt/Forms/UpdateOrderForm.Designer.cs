namespace OrderMgt
{
    partial class UpdateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblOrderIDTxt = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.grpPlanning = new System.Windows.Forms.GroupBox();
            this.chkRejected = new System.Windows.Forms.CheckBox();
            this.lblPlanningRejected = new System.Windows.Forms.Label();
            this.chkPlanningInvoice = new System.Windows.Forms.CheckBox();
            this.chkPlanning = new System.Windows.Forms.CheckBox();
            this.lblPlanningPay = new System.Windows.Forms.Label();
            this.lblPlanningGranted = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDelayInvoice = new System.Windows.Forms.CheckBox();
            this.lblDelayInvoice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDelayCost = new System.Windows.Forms.Label();
            this.btnDelay = new System.Windows.Forms.Button();
            this.dtpFoundationDate = new System.Windows.Forms.DateTimePicker();
            this.lblFoundationDate = new System.Windows.Forms.Label();
            this.chkOrderInvoice = new System.Windows.Forms.CheckBox();
            this.lblOrderInvoice = new System.Windows.Forms.Label();
            this.chkContract = new System.Windows.Forms.CheckBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.grpAssembly = new System.Windows.Forms.GroupBox();
            this.lblAssemblyDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.picSidePanel = new System.Windows.Forms.PictureBox();
            this.grpSummary.SuspendLayout();
            this.grpPlanning.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblOrderIDTxt);
            this.grpSummary.Controls.Add(this.lblOrderID);
            this.grpSummary.Controls.Add(this.label2);
            this.grpSummary.Controls.Add(this.lblStatus);
            this.grpSummary.Controls.Add(this.lblOrderStatus);
            this.grpSummary.Location = new System.Drawing.Point(159, 12);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(546, 216);
            this.grpSummary.TabIndex = 10;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblOrderIDTxt
            // 
            this.lblOrderIDTxt.AutoSize = true;
            this.lblOrderIDTxt.Location = new System.Drawing.Point(116, 31);
            this.lblOrderIDTxt.Name = "lblOrderIDTxt";
            this.lblOrderIDTxt.Size = new System.Drawing.Size(0, 13);
            this.lblOrderIDTxt.TabIndex = 4;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(39, 31);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(116, 54);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(39, 54);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(69, 13);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // grpPlanning
            // 
            this.grpPlanning.Controls.Add(this.chkRejected);
            this.grpPlanning.Controls.Add(this.lblPlanningRejected);
            this.grpPlanning.Controls.Add(this.chkPlanningInvoice);
            this.grpPlanning.Controls.Add(this.chkPlanning);
            this.grpPlanning.Controls.Add(this.lblPlanningPay);
            this.grpPlanning.Controls.Add(this.lblPlanningGranted);
            this.grpPlanning.Location = new System.Drawing.Point(159, 234);
            this.grpPlanning.Name = "grpPlanning";
            this.grpPlanning.Size = new System.Drawing.Size(546, 98);
            this.grpPlanning.TabIndex = 11;
            this.grpPlanning.TabStop = false;
            this.grpPlanning.Text = "Planning";
            // 
            // chkRejected
            // 
            this.chkRejected.AutoSize = true;
            this.chkRejected.Location = new System.Drawing.Point(127, 58);
            this.chkRejected.Name = "chkRejected";
            this.chkRejected.Size = new System.Drawing.Size(15, 14);
            this.chkRejected.TabIndex = 5;
            this.chkRejected.UseVisualStyleBackColor = true;
            this.chkRejected.CheckedChanged += new System.EventHandler(this.chkRejected_CheckedChanged);
            // 
            // lblPlanningRejected
            // 
            this.lblPlanningRejected.AutoSize = true;
            this.lblPlanningRejected.Location = new System.Drawing.Point(16, 59);
            this.lblPlanningRejected.Name = "lblPlanningRejected";
            this.lblPlanningRejected.Size = new System.Drawing.Size(100, 13);
            this.lblPlanningRejected.TabIndex = 4;
            this.lblPlanningRejected.Text = "Planning Rejected: ";
            // 
            // chkPlanningInvoice
            // 
            this.chkPlanningInvoice.AutoSize = true;
            this.chkPlanningInvoice.Location = new System.Drawing.Point(414, 30);
            this.chkPlanningInvoice.Name = "chkPlanningInvoice";
            this.chkPlanningInvoice.Size = new System.Drawing.Size(15, 14);
            this.chkPlanningInvoice.TabIndex = 3;
            this.chkPlanningInvoice.UseVisualStyleBackColor = true;
            this.chkPlanningInvoice.CheckedChanged += new System.EventHandler(this.chkPlanningInvoice_CheckedChanged);
            // 
            // chkPlanning
            // 
            this.chkPlanning.AutoSize = true;
            this.chkPlanning.Location = new System.Drawing.Point(127, 30);
            this.chkPlanning.Name = "chkPlanning";
            this.chkPlanning.Size = new System.Drawing.Size(15, 14);
            this.chkPlanning.TabIndex = 2;
            this.chkPlanning.UseVisualStyleBackColor = true;
            this.chkPlanning.CheckedChanged += new System.EventHandler(this.chkPlanning_CheckedChanged);
            // 
            // lblPlanningPay
            // 
            this.lblPlanningPay.AutoSize = true;
            this.lblPlanningPay.Location = new System.Drawing.Point(293, 30);
            this.lblPlanningPay.Name = "lblPlanningPay";
            this.lblPlanningPay.Size = new System.Drawing.Size(116, 13);
            this.lblPlanningPay.TabIndex = 1;
            this.lblPlanningPay.Text = "Planning Invoice Paid: ";
            // 
            // lblPlanningGranted
            // 
            this.lblPlanningGranted.AutoSize = true;
            this.lblPlanningGranted.Location = new System.Drawing.Point(16, 30);
            this.lblPlanningGranted.Name = "lblPlanningGranted";
            this.lblPlanningGranted.Size = new System.Drawing.Size(95, 13);
            this.lblPlanningGranted.TabIndex = 0;
            this.lblPlanningGranted.Text = "Planning Granted: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDelayInvoice);
            this.groupBox2.Controls.Add(this.lblDelayInvoice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblDelayCost);
            this.groupBox2.Controls.Add(this.btnDelay);
            this.groupBox2.Controls.Add(this.dtpFoundationDate);
            this.groupBox2.Controls.Add(this.lblFoundationDate);
            this.groupBox2.Controls.Add(this.chkOrderInvoice);
            this.groupBox2.Controls.Add(this.lblOrderInvoice);
            this.groupBox2.Controls.Add(this.chkContract);
            this.groupBox2.Controls.Add(this.lblContract);
            this.groupBox2.Location = new System.Drawing.Point(159, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract and Payment";
            // 
            // chkDelayInvoice
            // 
            this.chkDelayInvoice.AutoSize = true;
            this.chkDelayInvoice.Location = new System.Drawing.Point(406, 95);
            this.chkDelayInvoice.Name = "chkDelayInvoice";
            this.chkDelayInvoice.Size = new System.Drawing.Size(15, 14);
            this.chkDelayInvoice.TabIndex = 14;
            this.chkDelayInvoice.UseVisualStyleBackColor = true;
            // 
            // lblDelayInvoice
            // 
            this.lblDelayInvoice.AutoSize = true;
            this.lblDelayInvoice.Location = new System.Drawing.Point(297, 95);
            this.lblDelayInvoice.Name = "lblDelayInvoice";
            this.lblDelayInvoice.Size = new System.Drawing.Size(99, 13);
            this.lblDelayInvoice.TabIndex = 13;
            this.lblDelayInvoice.Text = "Delay Invoice Paid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cost in £";
            // 
            // lblDelayCost
            // 
            this.lblDelayCost.AutoSize = true;
            this.lblDelayCost.Location = new System.Drawing.Point(19, 95);
            this.lblDelayCost.Name = "lblDelayCost";
            this.lblDelayCost.Size = new System.Drawing.Size(64, 13);
            this.lblDelayCost.TabIndex = 11;
            this.lblDelayCost.Text = "Delay Cost: ";
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(365, 56);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(75, 23);
            this.btnDelay.TabIndex = 10;
            this.btnDelay.Text = "Delay";
            this.btnDelay.UseVisualStyleBackColor = true;
            // 
            // dtpFoundationDate
            // 
            this.dtpFoundationDate.Location = new System.Drawing.Point(114, 56);
            this.dtpFoundationDate.Name = "dtpFoundationDate";
            this.dtpFoundationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFoundationDate.TabIndex = 9;
            // 
            // lblFoundationDate
            // 
            this.lblFoundationDate.AutoSize = true;
            this.lblFoundationDate.Location = new System.Drawing.Point(16, 56);
            this.lblFoundationDate.Name = "lblFoundationDate";
            this.lblFoundationDate.Size = new System.Drawing.Size(92, 13);
            this.lblFoundationDate.TabIndex = 8;
            this.lblFoundationDate.Text = "Foundation Date: ";
            // 
            // chkOrderInvoice
            // 
            this.chkOrderInvoice.AutoSize = true;
            this.chkOrderInvoice.Location = new System.Drawing.Point(406, 26);
            this.chkOrderInvoice.Name = "chkOrderInvoice";
            this.chkOrderInvoice.Size = new System.Drawing.Size(15, 14);
            this.chkOrderInvoice.TabIndex = 7;
            this.chkOrderInvoice.UseVisualStyleBackColor = true;
            this.chkOrderInvoice.CheckedChanged += new System.EventHandler(this.chkOrderInvoice_CheckedChanged);
            // 
            // lblOrderInvoice
            // 
            this.lblOrderInvoice.AutoSize = true;
            this.lblOrderInvoice.Location = new System.Drawing.Point(297, 26);
            this.lblOrderInvoice.Name = "lblOrderInvoice";
            this.lblOrderInvoice.Size = new System.Drawing.Size(101, 13);
            this.lblOrderInvoice.TabIndex = 6;
            this.lblOrderInvoice.Text = "Order Invoice Paid: ";
            // 
            // chkContract
            // 
            this.chkContract.AutoSize = true;
            this.chkContract.Location = new System.Drawing.Point(127, 26);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(15, 14);
            this.chkContract.TabIndex = 5;
            this.chkContract.UseVisualStyleBackColor = true;
            this.chkContract.CheckedChanged += new System.EventHandler(this.chkContract_CheckedChanged);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(16, 26);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(89, 13);
            this.lblContract.TabIndex = 4;
            this.lblContract.Text = "Contract Signed: ";
            // 
            // grpAssembly
            // 
            this.grpAssembly.Controls.Add(this.lblAssemblyDate);
            this.grpAssembly.Controls.Add(this.dateTimePicker1);
            this.grpAssembly.Location = new System.Drawing.Point(159, 488);
            this.grpAssembly.Name = "grpAssembly";
            this.grpAssembly.Size = new System.Drawing.Size(546, 72);
            this.grpAssembly.TabIndex = 13;
            this.grpAssembly.TabStop = false;
            this.grpAssembly.Text = "Assembly";
            // 
            // lblAssemblyDate
            // 
            this.lblAssemblyDate.AutoSize = true;
            this.lblAssemblyDate.Location = new System.Drawing.Point(16, 32);
            this.lblAssemblyDate.Name = "lblAssemblyDate";
            this.lblAssemblyDate.Size = new System.Drawing.Size(80, 13);
            this.lblAssemblyDate.TabIndex = 1;
            this.lblAssemblyDate.Text = "Assembly Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(643, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(505, 595);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // picSidePanel
            // 
            this.picSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picSidePanel.BackColor = System.Drawing.Color.White;
            this.picSidePanel.Image = global::OrderMgt.Properties.Resources.neworder;
            this.picSidePanel.Location = new System.Drawing.Point(-1, 12);
            this.picSidePanel.Name = "picSidePanel";
            this.picSidePanel.Size = new System.Drawing.Size(143, 619);
            this.picSidePanel.TabIndex = 8;
            this.picSidePanel.TabStop = false;
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 627);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpAssembly);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPlanning);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.picSidePanel);
            this.Name = "UpdateOrderForm";
            this.Text = "UpdateOrderStatusForm";
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpPlanning.ResumeLayout(false);
            this.grpPlanning.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAssembly.ResumeLayout(false);
            this.grpAssembly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSidePanel;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.GroupBox grpPlanning;
        private System.Windows.Forms.Label lblPlanningPay;
        private System.Windows.Forms.Label lblPlanningGranted;
        private System.Windows.Forms.CheckBox chkPlanningInvoice;
        private System.Windows.Forms.CheckBox chkPlanning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFoundationDate;
        private System.Windows.Forms.CheckBox chkOrderInvoice;
        private System.Windows.Forms.Label lblOrderInvoice;
        private System.Windows.Forms.CheckBox chkContract;
        private System.Windows.Forms.GroupBox grpAssembly;
        private System.Windows.Forms.CheckBox chkRejected;
        private System.Windows.Forms.Label lblPlanningRejected;
        private System.Windows.Forms.DateTimePicker dtpFoundationDate;
        private System.Windows.Forms.Label lblAssemblyDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.Label lblDelayInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDelayCost;
        private System.Windows.Forms.CheckBox chkDelayInvoice;
        private System.Windows.Forms.Label lblOrderIDTxt;
        private System.Windows.Forms.Label lblOrderID;

    }
}