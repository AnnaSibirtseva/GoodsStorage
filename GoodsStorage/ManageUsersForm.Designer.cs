namespace GoodsStorage
{
    partial class ManageUsersForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Users");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.KindaManager = new System.Windows.Forms.TabControl();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AllUsersTree = new System.Windows.Forms.TreeView();
            this.UsersImageList = new System.Windows.Forms.ImageList(this.components);
            this.PanelForMainElements = new System.Windows.Forms.TableLayoutPanel();
            this.TableForLabels = new System.Windows.Forms.TableLayoutPanel();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.OrdersTotalPrice = new System.Windows.Forms.Label();
            this.UsersOrdersInfo = new System.Windows.Forms.DataGridView();
            this.WhatUserLabel = new System.Windows.Forms.Label();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelForButton = new System.Windows.Forms.TableLayoutPanel();
            this.OnlyActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.StatucContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeToProcessed = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToShipped = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageImagelist = new System.Windows.Forms.ImageList(this.components);
            this.OrdersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.KindaManager.SuspendLayout();
            this.UsersPage.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelForMainElements.SuspendLayout();
            this.TableForLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersOrdersInfo)).BeginInit();
            this.OrdersPage.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.PanelForButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.StatucContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KindaManager
            // 
            this.KindaManager.Controls.Add(this.UsersPage);
            this.KindaManager.Controls.Add(this.OrdersPage);
            this.KindaManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KindaManager.ImageList = this.TabPageImagelist;
            this.KindaManager.Location = new System.Drawing.Point(0, 0);
            this.KindaManager.Name = "KindaManager";
            this.KindaManager.SelectedIndex = 0;
            this.KindaManager.Size = new System.Drawing.Size(800, 450);
            this.KindaManager.TabIndex = 0;
            // 
            // UsersPage
            // 
            this.UsersPage.BackColor = System.Drawing.Color.AliceBlue;
            this.UsersPage.Controls.Add(this.MainPanel);
            this.UsersPage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsersPage.ImageIndex = 0;
            this.UsersPage.Location = new System.Drawing.Point(4, 29);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(792, 417);
            this.UsersPage.TabIndex = 0;
            this.UsersPage.Text = "Users     ";
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel.Controls.Add(this.AllUsersTree, 0, 0);
            this.MainPanel.Controls.Add(this.PanelForMainElements, 1, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 1;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 411F));
            this.MainPanel.Size = new System.Drawing.Size(786, 411);
            this.MainPanel.TabIndex = 0;
            // 
            // AllUsersTree
            // 
            this.AllUsersTree.BackColor = System.Drawing.Color.AliceBlue;
            this.AllUsersTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllUsersTree.ImageIndex = 0;
            this.AllUsersTree.ImageList = this.UsersImageList;
            this.AllUsersTree.Location = new System.Drawing.Point(3, 3);
            this.AllUsersTree.Name = "AllUsersTree";
            treeNode1.Name = "AllUsers";
            treeNode1.Text = "All Users";
            this.AllUsersTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.AllUsersTree.SelectedImageIndex = 0;
            this.AllUsersTree.Size = new System.Drawing.Size(308, 405);
            this.AllUsersTree.TabIndex = 0;
            this.AllUsersTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AllUsersTree_AfterSelect);
            // 
            // UsersImageList
            // 
            this.UsersImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.UsersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UsersImageList.ImageStream")));
            this.UsersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.UsersImageList.Images.SetKeyName(0, "group.png");
            this.UsersImageList.Images.SetKeyName(1, "user_suit.png");
            // 
            // PanelForMainElements
            // 
            this.PanelForMainElements.ColumnCount = 1;
            this.PanelForMainElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelForMainElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelForMainElements.Controls.Add(this.TableForLabels, 0, 2);
            this.PanelForMainElements.Controls.Add(this.UsersOrdersInfo, 0, 1);
            this.PanelForMainElements.Controls.Add(this.WhatUserLabel, 0, 0);
            this.PanelForMainElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForMainElements.Location = new System.Drawing.Point(317, 3);
            this.PanelForMainElements.Name = "PanelForMainElements";
            this.PanelForMainElements.RowCount = 3;
            this.PanelForMainElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelForMainElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.PanelForMainElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelForMainElements.Size = new System.Drawing.Size(466, 405);
            this.PanelForMainElements.TabIndex = 1;
            // 
            // TableForLabels
            // 
            this.TableForLabels.ColumnCount = 2;
            this.TableForLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableForLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableForLabels.Controls.Add(this.Pricelabel, 0, 1);
            this.TableForLabels.Controls.Add(this.OrdersTotalPrice, 1, 1);
            this.TableForLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableForLabels.Location = new System.Drawing.Point(3, 346);
            this.TableForLabels.Name = "TableForLabels";
            this.TableForLabels.RowCount = 2;
            this.TableForLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForLabels.Size = new System.Drawing.Size(460, 56);
            this.TableForLabels.TabIndex = 0;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pricelabel.Location = new System.Drawing.Point(3, 28);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(132, 28);
            this.Pricelabel.TabIndex = 0;
            this.Pricelabel.Text = "Total Price:";
            // 
            // OrdersTotalPrice
            // 
            this.OrdersTotalPrice.AutoSize = true;
            this.OrdersTotalPrice.Location = new System.Drawing.Point(141, 28);
            this.OrdersTotalPrice.Name = "OrdersTotalPrice";
            this.OrdersTotalPrice.Size = new System.Drawing.Size(19, 25);
            this.OrdersTotalPrice.TabIndex = 1;
            this.OrdersTotalPrice.Text = "-";
            // 
            // UsersOrdersInfo
            // 
            this.UsersOrdersInfo.AllowUserToAddRows = false;
            this.UsersOrdersInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.UsersOrdersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersOrdersInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersOrdersInfo.Location = new System.Drawing.Point(3, 43);
            this.UsersOrdersInfo.Name = "UsersOrdersInfo";
            this.UsersOrdersInfo.RowHeadersVisible = false;
            this.UsersOrdersInfo.RowHeadersWidth = 51;
            this.UsersOrdersInfo.Size = new System.Drawing.Size(460, 297);
            this.UsersOrdersInfo.TabIndex = 1;
            this.UsersOrdersInfo.Text = "dataGridView2";
            // 
            // WhatUserLabel
            // 
            this.WhatUserLabel.AutoSize = true;
            this.WhatUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WhatUserLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WhatUserLabel.Location = new System.Drawing.Point(3, 0);
            this.WhatUserLabel.Name = "WhatUserLabel";
            this.WhatUserLabel.Size = new System.Drawing.Size(460, 40);
            this.WhatUserLabel.TabIndex = 2;
            this.WhatUserLabel.Text = "USER INFO";
            this.WhatUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersPage
            // 
            this.OrdersPage.BackColor = System.Drawing.Color.AliceBlue;
            this.OrdersPage.Controls.Add(this.MainTableLayoutPanel);
            this.OrdersPage.ImageIndex = 1;
            this.OrdersPage.Location = new System.Drawing.Point(4, 29);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(792, 417);
            this.OrdersPage.TabIndex = 1;
            this.OrdersPage.Text = "Orders    ";
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Controls.Add(this.PanelForButton, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.OrdersDataGrid, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(786, 411);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // PanelForButton
            // 
            this.PanelForButton.ColumnCount = 2;
            this.PanelForButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PanelForButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.PanelForButton.Controls.Add(this.OnlyActiveCheckBox, 0, 0);
            this.PanelForButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForButton.Location = new System.Drawing.Point(3, 372);
            this.PanelForButton.Name = "PanelForButton";
            this.PanelForButton.RowCount = 1;
            this.PanelForButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelForButton.Size = new System.Drawing.Size(780, 36);
            this.PanelForButton.TabIndex = 0;
            // 
            // OnlyActiveCheckBox
            // 
            this.OnlyActiveCheckBox.AutoSize = true;
            this.OnlyActiveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlyActiveCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OnlyActiveCheckBox.Location = new System.Drawing.Point(3, 3);
            this.OnlyActiveCheckBox.Name = "OnlyActiveCheckBox";
            this.OnlyActiveCheckBox.Size = new System.Drawing.Size(267, 30);
            this.OnlyActiveCheckBox.TabIndex = 1;
            this.OnlyActiveCheckBox.Text = "Show Only Active Orders";
            this.OnlyActiveCheckBox.UseVisualStyleBackColor = true;
            this.OnlyActiveCheckBox.CheckedChanged += new System.EventHandler(this.OnlyActiveCheckBox_CheckedChanged);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            this.OrdersDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.ContextMenuStrip = this.StatucContextMenu;
            this.OrdersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.RowHeadersVisible = false;
            this.OrdersDataGrid.RowHeadersWidth = 51;
            this.OrdersDataGrid.Size = new System.Drawing.Size(780, 363);
            this.OrdersDataGrid.TabIndex = 1;
            this.OrdersDataGrid.Text = "dataGridView1";
            this.OrdersDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersDataGrid_CellMouseClick);
            // 
            // StatucContextMenu
            // 
            this.StatucContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatucContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeToProcessed,
            this.ChangeToShipped,
            this.ChangeToCompleted});
            this.StatucContextMenu.Name = "StatucContextMenu";
            this.StatucContextMenu.Size = new System.Drawing.Size(157, 82);
            // 
            // ChangeToProcessed
            // 
            this.ChangeToProcessed.Image = ((System.Drawing.Image)(resources.GetObject("ChangeToProcessed.Image")));
            this.ChangeToProcessed.Name = "ChangeToProcessed";
            this.ChangeToProcessed.Size = new System.Drawing.Size(156, 26);
            this.ChangeToProcessed.Text = "Processed";
            // 
            // ChangeToShipped
            // 
            this.ChangeToShipped.Image = ((System.Drawing.Image)(resources.GetObject("ChangeToShipped.Image")));
            this.ChangeToShipped.Name = "ChangeToShipped";
            this.ChangeToShipped.Size = new System.Drawing.Size(156, 26);
            this.ChangeToShipped.Text = "Shipped";
            // 
            // ChangeToCompleted
            // 
            this.ChangeToCompleted.Image = ((System.Drawing.Image)(resources.GetObject("ChangeToCompleted.Image")));
            this.ChangeToCompleted.Name = "ChangeToCompleted";
            this.ChangeToCompleted.Size = new System.Drawing.Size(156, 26);
            this.ChangeToCompleted.Text = "Completed";
            // 
            // TabPageImagelist
            // 
            this.TabPageImagelist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TabPageImagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabPageImagelist.ImageStream")));
            this.TabPageImagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.TabPageImagelist.Images.SetKeyName(0, "users.png");
            this.TabPageImagelist.Images.SetKeyName(1, "shopping_bag.png");
            // 
            // OrdersContextMenu
            // 
            this.OrdersContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrdersContextMenu.Name = "OrdersContextMenu";
            this.OrdersContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // SaveTimer
            // 
            this.SaveTimer.Interval = 3000;
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KindaManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.Name = "ManageUsersForm";
            this.Text = " Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.KindaManager.ResumeLayout(false);
            this.UsersPage.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelForMainElements.ResumeLayout(false);
            this.PanelForMainElements.PerformLayout();
            this.TableForLabels.ResumeLayout(false);
            this.TableForLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersOrdersInfo)).EndInit();
            this.OrdersPage.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.PanelForButton.ResumeLayout(false);
            this.PanelForButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.StatucContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl KindaManager;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.ImageList TabPageImagelist;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TreeView AllUsersTree;
        private System.Windows.Forms.ImageList UsersImageList;
        private System.Windows.Forms.TableLayoutPanel PanelForMainElements;
        private System.Windows.Forms.TableLayoutPanel TableForLabels;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label OrdersTotalPrice;
        private System.Windows.Forms.DataGridView UsersOrdersInfo;
        private System.Windows.Forms.Label WhatUserLabel;
        private System.Windows.Forms.ContextMenuStrip OrdersContextMenu;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel PanelForButton;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.CheckBox OnlyActiveCheckBox;
        private System.Windows.Forms.ContextMenuStrip StatucContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeToProcessed;
        private System.Windows.Forms.ToolStripMenuItem ChangeToShipped;
        private System.Windows.Forms.ToolStripMenuItem ChangeToCompleted;
        private System.Windows.Forms.Timer SaveTimer;
    }
}