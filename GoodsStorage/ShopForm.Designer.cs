namespace GoodsStorage
{
    partial class ShopForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Available Items");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.AvailableItems = new System.Windows.Forms.TreeView();
            this.BuyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BuyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsImageList = new System.Windows.Forms.ImageList(this.components);
            this.PanelForMainElements = new System.Windows.Forms.TableLayoutPanel();
            this.PanelForExtrsElements = new System.Windows.Forms.TableLayoutPanel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.OrdersPicture = new System.Windows.Forms.PictureBox();
            this.CartPicture = new System.Windows.Forms.PictureBox();
            this.CurrentUserName = new System.Windows.Forms.Label();
            this.PurchasesLabel = new System.Windows.Forms.Label();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AvailableItemsInfo = new System.Windows.Forms.DataGridView();
            this.PayForOrderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PayForTheItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTable.SuspendLayout();
            this.BuyMenu.SuspendLayout();
            this.PanelForMainElements.SuspendLayout();
            this.PanelForExtrsElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableItemsInfo)).BeginInit();
            this.PayForOrderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.AliceBlue;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.MainTable.Controls.Add(this.AvailableItems, 0, 0);
            this.MainTable.Controls.Add(this.PanelForMainElements, 1, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // AvailableItems
            // 
            this.AvailableItems.BackColor = System.Drawing.Color.AliceBlue;
            this.AvailableItems.ContextMenuStrip = this.BuyMenu;
            this.AvailableItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableItems.ImageIndex = 0;
            this.AvailableItems.ImageList = this.ItemsImageList;
            this.AvailableItems.Location = new System.Drawing.Point(3, 3);
            this.AvailableItems.Name = "AvailableItems";
            treeNode1.Name = "Available";
            treeNode1.Text = "Available Items";
            this.AvailableItems.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.AvailableItems.SelectedImageIndex = 0;
            this.AvailableItems.Size = new System.Drawing.Size(274, 444);
            this.AvailableItems.TabIndex = 0;
            this.AvailableItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AvailableItems_AfterSelect);
            this.AvailableItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AvailableItems_MouseClick);
            // 
            // BuyMenu
            // 
            this.BuyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BuyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuyItem,
            this.RemoveItem});
            this.BuyMenu.Name = "BuyMenu";
            this.BuyMenu.Size = new System.Drawing.Size(206, 56);
            // 
            // BuyItem
            // 
            this.BuyItem.Image = ((System.Drawing.Image)(resources.GetObject("BuyItem.Image")));
            this.BuyItem.Name = "BuyItem";
            this.BuyItem.Size = new System.Drawing.Size(205, 26);
            this.BuyItem.Text = "Add to Cart";
            // 
            // RemoveItem
            // 
            this.RemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveItem.Image")));
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(205, 26);
            this.RemoveItem.Text = "Remove From Cart";
            // 
            // ItemsImageList
            // 
            this.ItemsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ItemsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ItemsImageList.ImageStream")));
            this.ItemsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ItemsImageList.Images.SetKeyName(0, "treefolder (2).png");
            this.ItemsImageList.Images.SetKeyName(1, "label.png");
            // 
            // PanelForMainElements
            // 
            this.PanelForMainElements.ColumnCount = 1;
            this.PanelForMainElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelForMainElements.Controls.Add(this.PanelForExtrsElements, 0, 0);
            this.PanelForMainElements.Controls.Add(this.AvailableItemsInfo, 0, 1);
            this.PanelForMainElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForMainElements.Location = new System.Drawing.Point(283, 3);
            this.PanelForMainElements.Name = "PanelForMainElements";
            this.PanelForMainElements.RowCount = 2;
            this.PanelForMainElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelForMainElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PanelForMainElements.Size = new System.Drawing.Size(514, 444);
            this.PanelForMainElements.TabIndex = 1;
            // 
            // PanelForExtrsElements
            // 
            this.PanelForExtrsElements.ColumnCount = 7;
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.368421F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21053F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21053F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.368421F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21053F));
            this.PanelForExtrsElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.368421F));
            this.PanelForExtrsElements.Controls.Add(this.UserPicture, 0, 0);
            this.PanelForExtrsElements.Controls.Add(this.OrdersPicture, 4, 0);
            this.PanelForExtrsElements.Controls.Add(this.CartPicture, 6, 0);
            this.PanelForExtrsElements.Controls.Add(this.CurrentUserName, 1, 0);
            this.PanelForExtrsElements.Controls.Add(this.PurchasesLabel, 3, 0);
            this.PanelForExtrsElements.Controls.Add(this.CartLabel, 5, 0);
            this.PanelForExtrsElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForExtrsElements.Location = new System.Drawing.Point(3, 3);
            this.PanelForExtrsElements.Name = "PanelForExtrsElements";
            this.PanelForExtrsElements.RowCount = 1;
            this.PanelForExtrsElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelForExtrsElements.Size = new System.Drawing.Size(508, 38);
            this.PanelForExtrsElements.TabIndex = 0;
            // 
            // UserPicture
            // 
            this.UserPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPicture.Image = ((System.Drawing.Image)(resources.GetObject("UserPicture.Image")));
            this.UserPicture.Location = new System.Drawing.Point(3, 3);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(31, 32);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPicture.TabIndex = 0;
            this.UserPicture.TabStop = false;
            // 
            // OrdersPicture
            // 
            this.OrdersPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersPicture.Image = ((System.Drawing.Image)(resources.GetObject("OrdersPicture.Image")));
            this.OrdersPicture.Location = new System.Drawing.Point(310, 3);
            this.OrdersPicture.Name = "OrdersPicture";
            this.OrdersPicture.Size = new System.Drawing.Size(31, 32);
            this.OrdersPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrdersPicture.TabIndex = 1;
            this.OrdersPicture.TabStop = false;
            // 
            // CartPicture
            // 
            this.CartPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartPicture.Image = ((System.Drawing.Image)(resources.GetObject("CartPicture.Image")));
            this.CartPicture.Location = new System.Drawing.Point(470, 3);
            this.CartPicture.Name = "CartPicture";
            this.CartPicture.Size = new System.Drawing.Size(35, 31);
            this.CartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CartPicture.TabIndex = 2;
            this.CartPicture.TabStop = false;
            // 
            // CurrentUserName
            // 
            this.CurrentUserName.AutoSize = true;
            this.CurrentUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentUserName.Location = new System.Drawing.Point(40, 0);
            this.CurrentUserName.Name = "CurrentUserName";
            this.CurrentUserName.Size = new System.Drawing.Size(54, 28);
            this.CurrentUserName.TabIndex = 3;
            this.CurrentUserName.Text = "User";
            this.CurrentUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentUserName.Click += new System.EventHandler(this.CurrentUserName_Click_1);
            // 
            // PurchasesLabel
            // 
            this.PurchasesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchasesLabel.AutoSize = true;
            this.PurchasesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchasesLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchasesLabel.Location = new System.Drawing.Point(219, 0);
            this.PurchasesLabel.Name = "PurchasesLabel";
            this.PurchasesLabel.Size = new System.Drawing.Size(85, 31);
            this.PurchasesLabel.TabIndex = 4;
            this.PurchasesLabel.Text = "Orders";
            this.PurchasesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PurchasesLabel.Click += new System.EventHandler(this.PurchasesLabel_Click);
            // 
            // CartLabel
            // 
            this.CartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartLabel.AutoSize = true;
            this.CartLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CartLabel.Location = new System.Drawing.Point(404, 0);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(59, 31);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart";
            this.CartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartLabel.Click += new System.EventHandler(this.CartLabel_Click);
            // 
            // AvailableItemsInfo
            // 
            this.AvailableItemsInfo.AllowUserToAddRows = false;
            this.AvailableItemsInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.AvailableItemsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableItemsInfo.ContextMenuStrip = this.PayForOrderMenu;
            this.AvailableItemsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableItemsInfo.Location = new System.Drawing.Point(3, 47);
            this.AvailableItemsInfo.Name = "AvailableItemsInfo";
            this.AvailableItemsInfo.RowHeadersVisible = false;
            this.AvailableItemsInfo.RowHeadersWidth = 51;
            this.AvailableItemsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AvailableItemsInfo.Size = new System.Drawing.Size(508, 394);
            this.AvailableItemsInfo.TabIndex = 1;
            this.AvailableItemsInfo.Text = "dataGridView1";
            this.AvailableItemsInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AvailableItemsInfo_CellMouseClick);
            // 
            // PayForOrderMenu
            // 
            this.PayForOrderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PayForOrderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PayForTheItem});
            this.PayForOrderMenu.Name = "PayForOrderMenu";
            this.PayForOrderMenu.Size = new System.Drawing.Size(195, 30);
            // 
            // PayForTheItem
            // 
            this.PayForTheItem.Image = ((System.Drawing.Image)(resources.GetObject("PayForTheItem.Image")));
            this.PayForTheItem.Name = "PayForTheItem";
            this.PayForTheItem.Size = new System.Drawing.Size(194, 26);
            this.PayForTheItem.Text = "Pay for the Order";
            // 
            // SaveTimer
            // 
            this.SaveTimer.Interval = 5000;
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ShopForm";
            this.Text = " Goods Storage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Activated);
            this.MainTable.ResumeLayout(false);
            this.BuyMenu.ResumeLayout(false);
            this.PanelForMainElements.ResumeLayout(false);
            this.PanelForExtrsElements.ResumeLayout(false);
            this.PanelForExtrsElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableItemsInfo)).EndInit();
            this.PayForOrderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TreeView AvailableItems;
        private System.Windows.Forms.TableLayoutPanel PanelForMainElements;
        private System.Windows.Forms.TableLayoutPanel PanelForExtrsElements;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.PictureBox OrdersPicture;
        private System.Windows.Forms.PictureBox CartPicture;
        private System.Windows.Forms.Label PurchasesLabel;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ImageList ItemsImageList;
        private System.Windows.Forms.DataGridView AvailableItemsInfo;
        private System.Windows.Forms.ContextMenuStrip BuyMenu;
        private System.Windows.Forms.ToolStripMenuItem BuyItem;
        public System.Windows.Forms.Label CurrentUserName;
        private System.Windows.Forms.ToolStripMenuItem RemoveItem;
        private System.Windows.Forms.ContextMenuStrip PayForOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem PayForTheItem;
        private System.Windows.Forms.Timer SaveTimer;
    }
}