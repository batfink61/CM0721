namespace OrderMgt
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.vwOptions = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGBP1 = new System.Windows.Forms.Label();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.cboBuildingType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOptPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtOptionsPrice = new System.Windows.Forms.TextBox();
            this.lblFramePrice = new System.Windows.Forms.Label();
            this.txtFramePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picSidePanel = new System.Windows.Forms.PictureBox();
            this.grpOrders.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.btnNewOrder);
            this.grpOrders.Controls.Add(this.lblOrder);
            this.grpOrders.Controls.Add(this.txtOrderId);
            this.grpOrders.Controls.Add(this.btnOrderSearch);
            this.grpOrders.Location = new System.Drawing.Point(149, 12);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(589, 70);
            this.grpOrders.TabIndex = 18;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Order ";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(381, 30);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 20);
            this.btnNewOrder.TabIndex = 10;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Location = new System.Drawing.Point(69, 33);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(100, 23);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order Number:";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(190, 30);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(108, 20);
            this.txtOrderId.TabIndex = 0;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderNumber_TextChanged);
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(319, 30);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(56, 20);
            this.btnOrderSearch.TabIndex = 1;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(186, 99);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(247, 13);
            this.lblTelephone.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(186, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(247, 33);
            this.lblAddress.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(186, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(247, 13);
            this.lblName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(189, 22);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerId.TabIndex = 0;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(65, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telephone:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(318, 22);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(56, 20);
            this.btnCustomerSearch.TabIndex = 1;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(657, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 20);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblTelephone);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Controls.Add(this.btnCustomerSearch);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.txtCustomerId);
            this.grpCustomer.Location = new System.Drawing.Point(150, 88);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(588, 124);
            this.grpCustomer.TabIndex = 19;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer ";
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.vwOptions);
            this.grpProperty.Controls.Add(this.label10);
            this.grpProperty.Controls.Add(this.label8);
            this.grpProperty.Controls.Add(this.label5);
            this.grpProperty.Controls.Add(this.lblGBP1);
            this.grpProperty.Controls.Add(this.btnAddOption);
            this.grpProperty.Controls.Add(this.cboBuildingType);
            this.grpProperty.Controls.Add(this.label9);
            this.grpProperty.Controls.Add(this.label7);
            this.grpProperty.Controls.Add(this.lblOptPrice);
            this.grpProperty.Controls.Add(this.txtTotalPrice);
            this.grpProperty.Controls.Add(this.txtVAT);
            this.grpProperty.Controls.Add(this.txtOptionsPrice);
            this.grpProperty.Controls.Add(this.lblFramePrice);
            this.grpProperty.Controls.Add(this.txtFramePrice);
            this.grpProperty.Controls.Add(this.label4);
            this.grpProperty.Location = new System.Drawing.Point(149, 218);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(589, 250);
            this.grpProperty.TabIndex = 20;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Building ";
            // 
            // vwOptions
            // 
            this.vwOptions.AllowUserToAddRows = false;
            this.vwOptions.AllowUserToDeleteRows = false;
            this.vwOptions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.vwOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vwOptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vwOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Option,
            this.Price});
            this.vwOptions.Location = new System.Drawing.Point(304, 33);
            this.vwOptions.MultiSelect = false;
            this.vwOptions.Name = "vwOptions";
            this.vwOptions.ReadOnly = true;
            this.vwOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwOptions.ShowEditingIcon = false;
            this.vwOptions.Size = new System.Drawing.Size(279, 136);
            this.vwOptions.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Option
            // 
            this.Option.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Option.HeaderText = "Option";
            this.Option.Name = "Option";
            this.Option.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "£";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "£";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "£";
            // 
            // lblGBP1
            // 
            this.lblGBP1.AutoSize = true;
            this.lblGBP1.Location = new System.Drawing.Point(159, 67);
            this.lblGBP1.Name = "lblGBP1";
            this.lblGBP1.Size = new System.Drawing.Size(13, 13);
            this.lblGBP1.TabIndex = 4;
            this.lblGBP1.Text = "£";
            // 
            // btnAddOption
            // 
            this.btnAddOption.Location = new System.Drawing.Point(508, 175);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(75, 20);
            this.btnAddOption.TabIndex = 3;
            this.btnAddOption.Text = "Add Option";
            this.btnAddOption.UseVisualStyleBackColor = true;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // cboBuildingType
            // 
            this.cboBuildingType.FormattingEnabled = true;
            this.cboBuildingType.Location = new System.Drawing.Point(141, 33);
            this.cboBuildingType.Name = "cboBuildingType";
            this.cboBuildingType.Size = new System.Drawing.Size(140, 21);
            this.cboBuildingType.TabIndex = 1;
            this.cboBuildingType.SelectedIndexChanged += new System.EventHandler(this.cboBuildingType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Price:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "VAT:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOptPrice
            // 
            this.lblOptPrice.Location = new System.Drawing.Point(21, 154);
            this.lblOptPrice.Name = "lblOptPrice";
            this.lblOptPrice.Size = new System.Drawing.Size(100, 23);
            this.lblOptPrice.TabIndex = 0;
            this.lblOptPrice.Text = "Options Price:";
            this.lblOptPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(178, 213);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(178, 177);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(103, 20);
            this.txtVAT.TabIndex = 0;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOptionsPrice
            // 
            this.txtOptionsPrice.Location = new System.Drawing.Point(178, 151);
            this.txtOptionsPrice.Name = "txtOptionsPrice";
            this.txtOptionsPrice.Size = new System.Drawing.Size(103, 20);
            this.txtOptionsPrice.TabIndex = 0;
            this.txtOptionsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFramePrice
            // 
            this.lblFramePrice.Location = new System.Drawing.Point(21, 65);
            this.lblFramePrice.Name = "lblFramePrice";
            this.lblFramePrice.Size = new System.Drawing.Size(100, 23);
            this.lblFramePrice.TabIndex = 0;
            this.lblFramePrice.Text = "Frame Price:";
            this.lblFramePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFramePrice
            // 
            this.txtFramePrice.Location = new System.Drawing.Point(178, 62);
            this.txtFramePrice.Name = "txtFramePrice";
            this.txtFramePrice.Size = new System.Drawing.Size(103, 20);
            this.txtFramePrice.TabIndex = 0;
            this.txtFramePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Building Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picSidePanel
            // 
            this.picSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picSidePanel.BackColor = System.Drawing.Color.White;
            this.picSidePanel.Location = new System.Drawing.Point(0, -4);
            this.picSidePanel.Name = "picSidePanel";
            this.picSidePanel.Size = new System.Drawing.Size(143, 520);
            this.picSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSidePanel.TabIndex = 7;
            this.picSidePanel.TabStop = false;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 514);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picSidePanel);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSidePanel;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.Label lblFramePrice;
        private System.Windows.Forms.TextBox txtFramePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBuildingType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGBP1;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOptPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtOptionsPrice;
        private System.Windows.Forms.DataGridView vwOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}