namespace GoodsStorage
{
    partial class UserCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCartForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ForLabelsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AllGoodsCount = new System.Windows.Forms.Label();
            this.TotalPriceCount = new System.Windows.Forms.Label();
            this.ForButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ItemsInCart = new System.Windows.Forms.DataGridView();
            this.MainTableLayoutPanel.SuspendLayout();
            this.ForLabelsTableLayoutPanel.SuspendLayout();
            this.ForButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ForLabelsTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ForButtonTableLayoutPanel, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.ItemsInCart, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 3;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // ForLabelsTableLayoutPanel
            // 
            this.ForLabelsTableLayoutPanel.ColumnCount = 5;
            this.ForLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ForLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.ForLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ForLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ForLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ForLabelsTableLayoutPanel.Controls.Add(this.CountLabel, 0, 0);
            this.ForLabelsTableLayoutPanel.Controls.Add(this.PriceLabel, 3, 0);
            this.ForLabelsTableLayoutPanel.Controls.Add(this.AllGoodsCount, 1, 0);
            this.ForLabelsTableLayoutPanel.Controls.Add(this.TotalPriceCount, 4, 0);
            this.ForLabelsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForLabelsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ForLabelsTableLayoutPanel.Name = "ForLabelsTableLayoutPanel";
            this.ForLabelsTableLayoutPanel.RowCount = 1;
            this.ForLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ForLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.ForLabelsTableLayoutPanel.Size = new System.Drawing.Size(794, 39);
            this.ForLabelsTableLayoutPanel.TabIndex = 0;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountLabel.Location = new System.Drawing.Point(3, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(192, 39);
            this.CountLabel.TabIndex = 0;
            this.CountLabel.Text = "All Goods:";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(465, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(192, 39);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Total Price:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AllGoodsCount
            // 
            this.AllGoodsCount.AutoSize = true;
            this.AllGoodsCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllGoodsCount.Location = new System.Drawing.Point(201, 0);
            this.AllGoodsCount.Name = "AllGoodsCount";
            this.AllGoodsCount.Size = new System.Drawing.Size(0, 38);
            this.AllGoodsCount.TabIndex = 2;
            this.AllGoodsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPriceCount
            // 
            this.TotalPriceCount.AutoSize = true;
            this.TotalPriceCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceCount.Location = new System.Drawing.Point(663, 0);
            this.TotalPriceCount.Name = "TotalPriceCount";
            this.TotalPriceCount.Size = new System.Drawing.Size(0, 38);
            this.TotalPriceCount.TabIndex = 3;
            this.TotalPriceCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ForButtonTableLayoutPanel
            // 
            this.ForButtonTableLayoutPanel.ColumnCount = 2;
            this.ForButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.ForButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ForButtonTableLayoutPanel.Controls.Add(this.OrderButton, 1, 0);
            this.ForButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForButtonTableLayoutPanel.Location = new System.Drawing.Point(3, 408);
            this.ForButtonTableLayoutPanel.Name = "ForButtonTableLayoutPanel";
            this.ForButtonTableLayoutPanel.RowCount = 1;
            this.ForButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ForButtonTableLayoutPanel.Size = new System.Drawing.Size(794, 39);
            this.ForButtonTableLayoutPanel.TabIndex = 1;
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderButton.Location = new System.Drawing.Point(598, 3);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(193, 33);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "ORDER";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ItemsInCart
            // 
            this.ItemsInCart.AllowUserToAddRows = false;
            this.ItemsInCart.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ItemsInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsInCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsInCart.Location = new System.Drawing.Point(3, 48);
            this.ItemsInCart.Name = "ItemsInCart";
            this.ItemsInCart.RowHeadersVisible = false;
            this.ItemsInCart.RowHeadersWidth = 51;
            this.ItemsInCart.Size = new System.Drawing.Size(794, 354);
            this.ItemsInCart.TabIndex = 2;
            this.ItemsInCart.Text = "dataGridView1";
            // 
            // UserCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCartForm";
            this.Text = " Shopping Cart";
            this.Activated += new System.EventHandler(this.UserCartForm_Activated);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ForLabelsTableLayoutPanel.ResumeLayout(false);
            this.ForLabelsTableLayoutPanel.PerformLayout();
            this.ForButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsInCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ForLabelsTableLayoutPanel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TableLayoutPanel ForButtonTableLayoutPanel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.DataGridView ItemsInCart;
        public System.Windows.Forms.Label AllGoodsCount;
        public System.Windows.Forms.Label TotalPriceCount;
    }
}