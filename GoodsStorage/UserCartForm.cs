using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class UserCartForm : Form
    {
        public UserCartForm()
        {
            InitializeComponent();
            CreateNewDataGtid();
            // Filling up the DataGrid.
            for (int i = 0; i < ShopForm.CurrentUser.ShoppingCart.Count; i++)
            {
                string[] row = new string[3] { ShopForm.CurrentUser.ShoppingCart[i].Name, ShopForm.CurrentUser.ShoppingCart[i].VendorСode.ToString(), ShopForm.CurrentUser.ShoppingCart[i].Price.ToString() + " $" };
                ItemsInCart.Rows.Add(row);
            }
        }
        /// <summary>
        /// Method for creating a new order.
        /// </summary>
        private void OrderButton_Click(object sender, EventArgs e)
        {
            // If there is any items in the cart.
            if (ShopForm.CurrentUser.ShoppingCart.Count != 0)
            {
                Order order = new Order(ShopForm.CurrentUser.ShoppingCart, DateTime.Now);
                ShopForm.CurrentUser.AllOrders.Add(order);
                ShopForm.CurrentUser.ShoppingCart = new List<Item>();
            }
            else
            {
                MessageBox.Show("Your shopping cart is empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            // Closing the form.
            Close();
        }
        /// <summary>
        /// Method for creating new DataGrid.
        /// </summary>
        private void CreateNewDataGtid()
        {
            // Cleaning everything up.
            ItemsInCart.Rows.Clear();
            ItemsInCart.Columns.Clear();
            ItemsInCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string[] titles = new string[3] { "Product Name", "Article Number", "Price" };
            for (int i = 0; i < 3; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = titles[i];
                column.ReadOnly = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                ItemsInCart.Columns.Add(column);
                // Coloring DataGrid inside.
                foreach (DataGridViewRow row in ItemsInCart.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                foreach (DataGridViewColumn col in ItemsInCart.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
        }
        /// <summary>
        /// Method for coloring DataGrid in the beginning.
        /// </summary>
        private void UserCartForm_Activated(object sender, EventArgs e)
        {
            // Coloring the datagrid in AliceBlue for 
            ItemsInCart.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            ItemsInCart.EnableHeadersVisualStyles = false;
        }
    }
}
