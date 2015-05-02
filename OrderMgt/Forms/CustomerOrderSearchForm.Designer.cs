namespace OrderMgt
{
    partial class CustomerOrderSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.vwOrders = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(299, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(101, 19);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(364, 20);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // vwOrders
            // 
            this.vwOrders.AllowUserToAddRows = false;
            this.vwOrders.AllowUserToDeleteRows = false;
            this.vwOrders.BackgroundColor = System.Drawing.Color.White;
            this.vwOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.cno,
            this.cust,
            this.Building,
            this.status});
            this.vwOrders.Location = new System.Drawing.Point(16, 74);
            this.vwOrders.MultiSelect = false;
            this.vwOrders.Name = "vwOrders";
            this.vwOrders.ReadOnly = true;
            this.vwOrders.RowHeadersVisible = false;
            this.vwOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwOrders.Size = new System.Drawing.Size(449, 150);
            this.vwOrders.TabIndex = 5;
            this.vwOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwOrders_CellContentClick);
            // 
            // no
            // 
            this.no.FillWeight = 50F;
            this.no.HeaderText = "OrdNo";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // cno
            // 
            this.cno.FillWeight = 50F;
            this.cno.HeaderText = "Cust";
            this.cno.Name = "cno";
            this.cno.ReadOnly = true;
            this.cno.Width = 50;
            // 
            // cust
            // 
            this.cust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cust.HeaderText = "Name";
            this.cust.Name = "cust";
            this.cust.ReadOnly = true;
            // 
            // Building
            // 
            this.Building.HeaderText = "Building";
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // CustomerOrderSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 284);
            this.Controls.Add(this.vwOrders);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomerOrderSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrderSearchForm";
            this.Load += new System.EventHandler(this.CustomerOrderSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView vwOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}