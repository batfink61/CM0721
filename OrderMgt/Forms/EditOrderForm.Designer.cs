namespace OrderMgt
{
    partial class EditOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabWizzard = new System.Windows.Forms.TabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistered = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.Building = new System.Windows.Forms.TabPage();
            this.txtReceptionRooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboBuildingType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBuildingType = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSelectedOptionsPrice = new System.Windows.Forms.TextBox();
            this.lblCostOfSelected = new System.Windows.Forms.Label();
            this.vwBuildingOptions = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGBP1 = new System.Windows.Forms.Label();
            this.txtOptionsPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtFramePrice = new System.Windows.Forms.TextBox();
            this.lbloptions = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSidePanel = new System.Windows.Forms.PictureBox();
            this.grpChangeCustomer = new System.Windows.Forms.GroupBox();
            this.tabWizzard.SuspendLayout();
            this.Customer.SuspendLayout();
            this.Building.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwBuildingOptions)).BeginInit();
            this.Confirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).BeginInit();
            this.grpChangeCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWizzard
            // 
            this.tabWizzard.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabWizzard.Controls.Add(this.Customer);
            this.tabWizzard.Controls.Add(this.Building);
            this.tabWizzard.Controls.Add(this.Options);
            this.tabWizzard.Controls.Add(this.Confirm);
            this.tabWizzard.Location = new System.Drawing.Point(147, 12);
            this.tabWizzard.Name = "tabWizzard";
            this.tabWizzard.SelectedIndex = 0;
            this.tabWizzard.Size = new System.Drawing.Size(447, 309);
            this.tabWizzard.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabWizzard.TabIndex = 9;
            this.tabWizzard.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabWizzard_Selected);
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.grpChangeCustomer);
            this.Customer.Controls.Add(this.label2);
            this.Customer.Controls.Add(this.label3);
            this.Customer.Controls.Add(this.txtCustomerName);
            this.Customer.Controls.Add(this.label4);
            this.Customer.Controls.Add(this.label5);
            this.Customer.Controls.Add(this.txtRegistered);
            this.Customer.Controls.Add(this.txtAddress);
            this.Customer.Controls.Add(this.txtMobile);
            this.Customer.Controls.Add(this.label6);
            this.Customer.Controls.Add(this.txtTelephone);
            this.Customer.Controls.Add(this.txtTown);
            this.Customer.Controls.Add(this.label8);
            this.Customer.Controls.Add(this.label7);
            this.Customer.Controls.Add(this.txtPostCode);
            this.Customer.Controls.Add(this.txtCustomerId);
            this.Customer.Controls.Add(this.lblCustomer);
            this.Customer.Location = new System.Drawing.Point(4, 25);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(439, 280);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(144, 83);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Town:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Postcode:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRegistered
            // 
            this.txtRegistered.Location = new System.Drawing.Point(144, 239);
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.ReadOnly = true;
            this.txtRegistered.Size = new System.Drawing.Size(96, 20);
            this.txtRegistered.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(144, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(144, 213);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(185, 20);
            this.txtMobile.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telephone:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(144, 187);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(185, 20);
            this.txtTelephone.TabIndex = 21;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(144, 135);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(247, 20);
            this.txtTown.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Registered:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mobile:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(144, 161);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.ReadOnly = true;
            this.txtPostCode.Size = new System.Drawing.Size(96, 20);
            this.txtPostCode.TabIndex = 20;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(78, 11);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(66, 20);
            this.btnNewCustomer.TabIndex = 2;
            this.btnNewCustomer.Text = "New";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(6, 11);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(66, 20);
            this.btnCustomerSearch.TabIndex = 2;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(144, 47);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(44, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(94, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Number:";
            // 
            // Building
            // 
            this.Building.Controls.Add(this.txtReceptionRooms);
            this.Building.Controls.Add(this.txtBathrooms);
            this.Building.Controls.Add(this.label14);
            this.Building.Controls.Add(this.txtBedrooms);
            this.Building.Controls.Add(this.label13);
            this.Building.Controls.Add(this.cboBuildingType);
            this.Building.Controls.Add(this.label9);
            this.Building.Controls.Add(this.lblBuildingType);
            this.Building.Location = new System.Drawing.Point(4, 25);
            this.Building.Name = "Building";
            this.Building.Padding = new System.Windows.Forms.Padding(3);
            this.Building.Size = new System.Drawing.Size(439, 280);
            this.Building.TabIndex = 1;
            this.Building.Text = "Building";
            this.Building.UseVisualStyleBackColor = true;
            // 
            // txtReceptionRooms
            // 
            this.txtReceptionRooms.Location = new System.Drawing.Point(144, 78);
            this.txtReceptionRooms.Name = "txtReceptionRooms";
            this.txtReceptionRooms.ReadOnly = true;
            this.txtReceptionRooms.Size = new System.Drawing.Size(46, 20);
            this.txtReceptionRooms.TabIndex = 4;
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(144, 130);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.ReadOnly = true;
            this.txtBathrooms.Size = new System.Drawing.Size(46, 20);
            this.txtBathrooms.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(27, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Reception Rooms:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Location = new System.Drawing.Point(144, 104);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.ReadOnly = true;
            this.txtBedrooms.Size = new System.Drawing.Size(46, 20);
            this.txtBedrooms.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(62, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Bathrooms:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboBuildingType
            // 
            this.cboBuildingType.FormattingEnabled = true;
            this.cboBuildingType.Location = new System.Drawing.Point(144, 47);
            this.cboBuildingType.Name = "cboBuildingType";
            this.cboBuildingType.Size = new System.Drawing.Size(157, 21);
            this.cboBuildingType.TabIndex = 3;
            this.cboBuildingType.SelectedValueChanged += new System.EventHandler(this.cboBuildingType_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(62, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bedrooms:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBuildingType
            // 
            this.lblBuildingType.Location = new System.Drawing.Point(62, 50);
            this.lblBuildingType.Name = "lblBuildingType";
            this.lblBuildingType.Size = new System.Drawing.Size(74, 16);
            this.lblBuildingType.TabIndex = 0;
            this.lblBuildingType.Text = "Building Type:";
            this.lblBuildingType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.label15);
            this.Options.Controls.Add(this.txtSelectedOptionsPrice);
            this.Options.Controls.Add(this.lblCostOfSelected);
            this.Options.Controls.Add(this.vwBuildingOptions);
            this.Options.Location = new System.Drawing.Point(4, 25);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(3);
            this.Options.Size = new System.Drawing.Size(439, 280);
            this.Options.TabIndex = 2;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "£";
            // 
            // txtSelectedOptionsPrice
            // 
            this.txtSelectedOptionsPrice.Location = new System.Drawing.Point(345, 196);
            this.txtSelectedOptionsPrice.Name = "txtSelectedOptionsPrice";
            this.txtSelectedOptionsPrice.ReadOnly = true;
            this.txtSelectedOptionsPrice.Size = new System.Drawing.Size(69, 20);
            this.txtSelectedOptionsPrice.TabIndex = 5;
            // 
            // lblCostOfSelected
            // 
            this.lblCostOfSelected.AutoSize = true;
            this.lblCostOfSelected.Location = new System.Drawing.Point(195, 199);
            this.lblCostOfSelected.Name = "lblCostOfSelected";
            this.lblCostOfSelected.Size = new System.Drawing.Size(125, 13);
            this.lblCostOfSelected.TabIndex = 7;
            this.lblCostOfSelected.Text = "Price For Selected Items:";
            // 
            // vwBuildingOptions
            // 
            this.vwBuildingOptions.AllowUserToAddRows = false;
            this.vwBuildingOptions.AllowUserToDeleteRows = false;
            this.vwBuildingOptions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.vwBuildingOptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vwBuildingOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwBuildingOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Option,
            this.Price,
            this.type});
            this.vwBuildingOptions.Location = new System.Drawing.Point(30, 29);
            this.vwBuildingOptions.Name = "vwBuildingOptions";
            this.vwBuildingOptions.ReadOnly = true;
            this.vwBuildingOptions.RowHeadersVisible = false;
            this.vwBuildingOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwBuildingOptions.ShowEditingIcon = false;
            this.vwBuildingOptions.Size = new System.Drawing.Size(384, 156);
            this.vwBuildingOptions.TabIndex = 6;
            this.vwBuildingOptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwBuildingOptions_CellContentClick);
            this.vwBuildingOptions.SelectionChanged += new System.EventHandler(this.vwBuildingOptions_SelectionChanged);
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
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // Confirm
            // 
            this.Confirm.Controls.Add(this.label11);
            this.Confirm.Controls.Add(this.label12);
            this.Confirm.Controls.Add(this.label10);
            this.Confirm.Controls.Add(this.lblGBP1);
            this.Confirm.Controls.Add(this.txtOptionsPrice);
            this.Confirm.Controls.Add(this.txtTotalPrice);
            this.Confirm.Controls.Add(this.txtVat);
            this.Confirm.Controls.Add(this.txtFramePrice);
            this.Confirm.Controls.Add(this.lbloptions);
            this.Confirm.Controls.Add(this.lblTotal);
            this.Confirm.Controls.Add(this.lblVat);
            this.Confirm.Controls.Add(this.label1);
            this.Confirm.Location = new System.Drawing.Point(4, 25);
            this.Confirm.Name = "Confirm";
            this.Confirm.Padding = new System.Windows.Forms.Padding(3);
            this.Confirm.Size = new System.Drawing.Size(439, 280);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "£";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "£";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "£";
            // 
            // lblGBP1
            // 
            this.lblGBP1.AutoSize = true;
            this.lblGBP1.Location = new System.Drawing.Point(162, 92);
            this.lblGBP1.Name = "lblGBP1";
            this.lblGBP1.Size = new System.Drawing.Size(13, 13);
            this.lblGBP1.TabIndex = 16;
            this.lblGBP1.Text = "£";
            // 
            // txtOptionsPrice
            // 
            this.txtOptionsPrice.Location = new System.Drawing.Point(181, 115);
            this.txtOptionsPrice.Name = "txtOptionsPrice";
            this.txtOptionsPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOptionsPrice.TabIndex = 12;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(181, 167);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(181, 141);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 10;
            // 
            // txtFramePrice
            // 
            this.txtFramePrice.Location = new System.Drawing.Point(181, 89);
            this.txtFramePrice.Name = "txtFramePrice";
            this.txtFramePrice.Size = new System.Drawing.Size(100, 20);
            this.txtFramePrice.TabIndex = 11;
            // 
            // lbloptions
            // 
            this.lbloptions.Location = new System.Drawing.Point(75, 118);
            this.lbloptions.Name = "lbloptions";
            this.lbloptions.Size = new System.Drawing.Size(74, 13);
            this.lbloptions.TabIndex = 7;
            this.lbloptions.Text = "Options Price:";
            this.lbloptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(75, 170);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Price:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVat
            // 
            this.lblVat.Location = new System.Drawing.Point(75, 144);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(74, 13);
            this.lblVat.TabIndex = 9;
            this.lblVat.Text = "VAT:";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(75, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FramePrice:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(515, 327);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(434, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderMgt.Properties.Resources.neworder;
            this.pictureBox1.Location = new System.Drawing.Point(1, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picSidePanel
            // 
            this.picSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picSidePanel.BackColor = System.Drawing.Color.White;
            this.picSidePanel.Location = new System.Drawing.Point(-2, -2);
            this.picSidePanel.Name = "picSidePanel";
            this.picSidePanel.Size = new System.Drawing.Size(143, 380);
            this.picSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSidePanel.TabIndex = 8;
            this.picSidePanel.TabStop = false;
            // 
            // grpChangeCustomer
            // 
            this.grpChangeCustomer.Controls.Add(this.btnCustomerSearch);
            this.grpChangeCustomer.Controls.Add(this.btnNewCustomer);
            this.grpChangeCustomer.Location = new System.Drawing.Point(250, 36);
            this.grpChangeCustomer.Name = "grpChangeCustomer";
            this.grpChangeCustomer.Size = new System.Drawing.Size(148, 36);
            this.grpChangeCustomer.TabIndex = 24;
            this.grpChangeCustomer.TabStop = false;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabWizzard);
            this.Controls.Add(this.picSidePanel);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Order Form";
            this.Load += new System.EventHandler(this.EditOrderForm_Load);
            this.tabWizzard.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.Building.ResumeLayout(false);
            this.Building.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwBuildingOptions)).EndInit();
            this.Confirm.ResumeLayout(false);
            this.Confirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).EndInit();
            this.grpChangeCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSidePanel;
        private System.Windows.Forms.TabControl tabWizzard;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TabPage Building;
        private System.Windows.Forms.Label lblBuildingType;
        private System.Windows.Forms.TabPage Options;
        private System.Windows.Forms.TabPage Confirm;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegistered;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.ComboBox cboBuildingType;
        private System.Windows.Forms.TextBox txtReceptionRooms;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGBP1;
        private System.Windows.Forms.TextBox txtOptionsPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtFramePrice;
        private System.Windows.Forms.Label lbloptions;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vwBuildingOptions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSelectedOptionsPrice;
        private System.Windows.Forms.Label lblCostOfSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpChangeCustomer;
    }
}