namespace OrderMgt
{
    partial class frmDialogue
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogue));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewOrder = new System.Windows.Forms.ToolStripButton();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnOrders = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateOrder = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateFactory = new System.Windows.Forms.ToolStripButton();
            this.btnDelivery = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewOrder,
            this.btnCustomers,
            this.btnOrders,
            this.btnUpdateOrder,
            this.btnUpdateFactory,
            this.btnDelivery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOrder.Image")));
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(68, 43);
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 43);
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(46, 43);
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateOrder.Image")));
            this.btnUpdateOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdateOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(82, 43);
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnUpdateFactory
            // 
            this.btnUpdateFactory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateFactory.Image")));
            this.btnUpdateFactory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateFactory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdateFactory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateFactory.Name = "btnUpdateFactory";
            this.btnUpdateFactory.Size = new System.Drawing.Size(70, 43);
            this.btnUpdateFactory.Text = "Production";
            this.btnUpdateFactory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateFactory.Click += new System.EventHandler(this.btnUpdateFactory_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelivery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(62, 43);
            this.btnDelivery.Text = "Assembly";
            this.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 77);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDialogue";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.frmDialogue_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOrders;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnUpdateFactory;
        private System.Windows.Forms.ToolStripButton btnDelivery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnNewOrder;
        private System.Windows.Forms.ToolStripButton btnUpdateOrder;

    }
}

