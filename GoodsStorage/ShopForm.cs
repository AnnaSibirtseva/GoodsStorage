using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class ShopForm : Form
    {
        public static User CurrentUser { get; set; }
        // Variable to understand whether this is the final closing of the program.
        public static bool FinalClose = true;
        // The variable to understand is the first loading of the form.
        public bool FirstOpening = true;
        public int CurrenrColumnNumber { get; private set; } = 0;
        public int CurrenrRowNumber { get; private set; }
        public string SelectedCell { get; set; }
        public ShopForm()
        {
            InitializeComponent();
            MaximumSize = SystemInformation.PrimaryMonitorSize;
            int Width = SystemInformation.PrimaryMonitorSize.Width / 2;
            int Height = SystemInformation.PrimaryMonitorSize.Height / 2;
            MinimumSize = new Size(Width, Height);
            SaveTimer.Start();
        }
        /// <summary>
        /// Method for calling the shopping cart form.
        /// </summary>
        private void CartLabel_Click(object sender, EventArgs e)
        {
            UserCartForm userCart = new UserCartForm();
            // Changing labels.
            userCart.AllGoodsCount.Text = CurrentUser.ShoppingCart.Count.ToString();
            userCart.TotalPriceCount.Text = CountPrice();
            userCart.Show();
        }
        /// <summary>
        /// Method for counting the total price in the cart.
        /// </summary>
        /// <returns>Total price in the cart.</returns>
        private static string CountPrice()
        {
            double total = 0;
            for (int i = 0; i < CurrentUser.ShoppingCart.Count; i++)
            {
                total += CurrentUser.ShoppingCart[i].Price;
            }
            return total.ToString() + " $";
        }
        /// <summary>
        /// Method for viewing all the orders.
        /// </summary>
        private void PurchasesLabel_Click(object sender, EventArgs e)
        {
            // Creating new DataGrid.
            CreateNewDataGtid("Order Number", "Status", "Total Price");
            for (int i = 0; i < CurrentUser.AllOrders.Count; i++)
            {
                string[] row = new string[3] { CurrentUser.AllOrders[i].OrderNumber, CurrentUser.AllOrders[i].OrderStatus.ToString(), CurrentUser.AllOrders[i].OrderPrice.ToString() + " $" };
                AvailableItemsInfo.Rows.Add(row);
                AvailableItemsInfo.ContextMenuStrip = PayForOrderMenu;
            }
        }
        /// <summary>
        /// Method for creating a tree of available items.
        /// </summary>
        /// <param name="folder">Current folder to find items in.</param>
        /// <param name="node">CUrrent node to add the item.</param>
        private static void CreateATree(Folder folder, TreeNode node)
        {
            // Additing all the items in tree firstly.
            for (int i = 0; i < folder.AllItems.Count; i++)
            {
                StorageForm.Items.Add(folder.AllItems[i]);
            }
            // Additing all the folders in tree secondly.
            for (int i = 0; i < folder.AllFolders.Count; i++)
            {
                StorageForm.Folders.Add(folder.AllFolders[i]);
                folder.AllNodes.Add(folder.AllFolders[i]);
                CreateATree(folder.AllFolders[i], node);
            }

        }
        /// <summary>
        /// A method with important actions to perform before the user starts working with the program.
        /// </summary>
        private void ShopForm_Activated(object sender, EventArgs e)
        {
            // Cleaning the inner objects in the folder.
            for (int i = 0; i < StorageForm.Folders.Count; i++)
            {
                StorageForm.Folders[i].AllNodes = new List<Node>();
            }
            // Removing all the objects from the list inside the folder.
            StorageForm.Folders = new List<Folder>();
            StorageForm.Items = new List<Item>();
            using (StreamReader streamReader = new StreamReader(new FileStream("SavedThings.json", FileMode.Open)))
            {
                string savedData = streamReader.ReadToEnd();
                var cSavedThings = JsonConvert.DeserializeObject<Folder>(savedData);
                StorageForm.Folders.Add(cSavedThings);
                StorageForm.Folders[0].Name = StorageForm.Folders[0].FolderName;
                // Calling method for recreating a tree.
                CreateATree(StorageForm.Folders[0], AvailableItems.Nodes[0]);
            }
            AvailableItems.Nodes[0].Nodes.Clear();
            for (int i = 0; i < StorageForm.Items.Count; i++)
            {
                // Sticking the picture for the new node.
                TreeNode item = new TreeNode { Text = StorageForm.Items[i].Name, ImageIndex = 1, SelectedImageIndex = 1 };
                AvailableItems.Nodes[0].Nodes.Add(item);
                AvailableItems.ExpandAll();
            }
            BuyItem.Click += BuyItemClicked;
            RemoveItem.Click += RemoveItemClicked;
            PayForTheItem.Click += PayForTheItemClicked;

            // Coloring the datagrid in AliceBlue for 
            AvailableItemsInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            AvailableItemsInfo.EnableHeadersVisualStyles = false;
        }
        /// <summary>
        /// Method for changing tha order status to 'paid'. 
        /// </summary>
        private void PayForTheItemClicked(object sender, EventArgs e)
        {
            string orderToPay = AvailableItemsInfo.Rows[CurrenrRowNumber].Cells[0].Value.ToString();
            for (int i = 0; i < CurrentUser.AllOrders.Count; i++)
            {
                if (CurrentUser.AllOrders[i].OrderNumber == orderToPay)
                {
                    CurrentUser.AllOrders[i].OrderStatus ^= Status.Paid;
                }
            }
            // Recreating DataGrid with new data.
            CreateNewDataGtid("Order Number", "Status", "Total Price");
            for (int i = 0; i < CurrentUser.AllOrders.Count; i++)
            {
                string[] row = new string[3] { CurrentUser.AllOrders[i].OrderNumber, CurrentUser.AllOrders[i].OrderStatus.ToString(), CurrentUser.AllOrders[i].OrderPrice.ToString() + " $" };
                AvailableItemsInfo.Rows.Add(row);
                AvailableItemsInfo.ContextMenuStrip = PayForOrderMenu;
            }
        }
        /// <summary>
        /// Method for removing item from the users cart.
        /// </summary>
        private void RemoveItemClicked(object sender, EventArgs e)
        {
            if (AvailableItems.SelectedNode != null)
            {
                for (int i = 0; i < StorageForm.Items.Count; i++)
                {
                    if (StorageForm.Items[i].Name == AvailableItems.SelectedNode.Text)
                    {
                        CurrentUser.ShoppingCart.Remove(StorageForm.Items[i]);
                    }
                }
            }
        }
        /// <summary>
        /// Method for additing item to the users cart.
        /// </summary>
        private void BuyItemClicked(object sender, EventArgs e)
        {
            if (AvailableItems.SelectedNode != null)
            {
                for (int i = 0; i < StorageForm.Items.Count; i++)
                {
                    if (StorageForm.Items[i].Name == AvailableItems.SelectedNode.Text)
                    {
                        CurrentUser.ShoppingCart.Add(StorageForm.Items[i]);
                    }
                }
            }
        }
        /// <summary>
        /// Method to do something before closing the form.
        /// </summary>
        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If it is final cloe than we closing the first form.
            if (FinalClose)
            {
                (Application.OpenForms[0] as StartForm).Close();
            }
        }
        /// <summary>
        /// Method for recreating DataGrid.
        /// </summary>
        /// <param name="firstName">First column tittle.</param>
        /// <param name="secondName">Second column tittle.</param>
        /// <param name="thirdName">Third column tittle.</param>
        private void CreateNewDataGtid(string firstName, string secondName, string thirdName)
        {
            // Cleaning everything up.
            AvailableItemsInfo.Rows.Clear();
            AvailableItemsInfo.Columns.Clear();
            AvailableItemsInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string[] titles = new string[3] { firstName, secondName, thirdName };
            for (int i = 0; i < 3; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = titles[i];
                column.ReadOnly = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                AvailableItemsInfo.Columns.Add(column);
                // Coloring DataGrid inside.
                foreach (DataGridViewRow row in AvailableItemsInfo.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                foreach (DataGridViewColumn col in AvailableItemsInfo.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
        }
        /// <summary>
        /// Method for showing the product information.
        /// </summary>
        private void AvailableItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Cleaning up DataGrid.
            CreateNewDataGtid("Product Name", "Article Number", "Price");
            if (AvailableItems.SelectedNode != null)
            {
                for (int i = 0; i < StorageForm.Items.Count; i++)
                {
                    if (StorageForm.Items[i].Name == AvailableItems.SelectedNode.Text)
                    {
                        string[] row = new string[3] { StorageForm.Items[i].Name, StorageForm.Items[i].VendorСode.ToString(), StorageForm.Items[i].Price.ToString() + " $" };
                        AvailableItemsInfo.Rows.Add(row);
                        AvailableItemsInfo.ContextMenuStrip = new ContextMenuStrip();
                    }
                }
            }
        }
        /// <summary>
        /// Method to enable the remove item.
        /// </summary>
        private void AvailableItems_MouseClick(object sender, MouseEventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < CurrentUser.ShoppingCart.Count; i++)
            {
                // If there is such item in the cart then we can remove it from there.
                if (CurrentUser.ShoppingCart[i].Name == AvailableItems.SelectedNode.Text)
                {
                    RemoveItem.Enabled = true;
                    flag = true;
                }
            }
            if (!flag)
            {
                RemoveItem.Enabled = false;
            }
        }
        /// <summary>
        /// Method to understand if we can pay for the item or not.
        /// </summary>
        private void AvailableItemsInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Just in case, an empty try-catch, because there may be exeptions.
            try
            {
                SelectedCell = AvailableItemsInfo.SelectedCells[0].Value.ToString();
                CurrenrRowNumber = AvailableItemsInfo.CurrentCell.RowIndex;
                bool flag = false;
                if (SelectedCell != null)
                {
                    string orderToPay = AvailableItemsInfo.Rows[CurrenrRowNumber].Cells[0].Value.ToString();
                    string orderToPayStatus = AvailableItemsInfo.Rows[CurrenrRowNumber].Cells[1].Value.ToString();
                    if (orderToPayStatus == Status.Processed.ToString())
                    {
                        PayForTheItem.Enabled = true;
                        flag = true;
                    }
                    if (!flag)
                    {
                        PayForTheItem.Enabled = false;
                    }
                }
            }
            catch
            {
                // They will not affect the operation of the program at all, so thic block is empty.
            }
        }
        /// <summary>
        /// Method for loging out.
        /// </summary>
        private void CurrentUserName_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.No)
            {
                // We don't need to do anything in this case.
            }
            if (result == DialogResult.Yes)
            {
                // If user decides to leave then we closing up everything.
                FinalClose = false;
                (Application.OpenForms[0] as StartForm).Show();
                Close();
            }
        }
        /// <summary>
        /// Method for saving evetything.
        /// </summary>
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            // Cleaning the file before writing in it.
            if (File.Exists("SavedUsers.json"))
            {
                StreamWriter writer = new StreamWriter("SavedUsers.json");
                writer.WriteLine("");
                writer.Close();
            }
            using (StreamWriter streamWriter = new StreamWriter(new FileStream("SavedUsers.json", FileMode.Create)))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(streamWriter, StartForm.AllUsers);
            }
            // Starting the timer again.
            SaveTimer.Start();
        }
    }
}
