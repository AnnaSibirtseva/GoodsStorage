using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class ManageUsersForm : Form
    {
        private static TreeNode CurrentNode { get; set; }
        private Order CurrentOrder { get; set; }
        public ManageUsersForm()
        {
            InitializeComponent();
            // Starting a timer for saving everything.
            SaveTimer.Start();
        }
        /// <summary>
        /// Method for Changing things when user clicks in the DataGrid.
        /// </summary>
        private void AllUsersTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CurrentNode = AllUsersTree.SelectedNode;
            // Cleaning up old datagrid.
            string[] titles = new string[2] { "Order Number", "Order Price" };
            CreateNewDataGtid(titles, UsersOrdersInfo);
            if (CurrentNode != null)
            {
                for (int i = 0; i < StartForm.AllUsers.Count; i++)
                {
                    if (CurrentNode.Text == StartForm.AllUsers[i].Email)
                    {
                        // Counting total price of all orders.
                        double totalPrice = 0;
                        for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                        {
                            string[] row = new string[2] { StartForm.AllUsers[i].AllOrders[j].OrderNumber, StartForm.AllUsers[i].AllOrders[j].OrderPrice.ToString() };
                            UsersOrdersInfo.Rows.Add(row);
                            totalPrice += StartForm.AllUsers[i].AllOrders[j].OrderPrice;
                        }
                        // Changing the label.
                        WhatUserLabel.Text = $"USER '{StartForm.AllUsers[i].Email}' INFO";
                        OrdersTotalPrice.Text = totalPrice + "$";
                    }
                }
            }
        }
        /// <summary>
        /// Method for creating new DataGrid.
        /// </summary>
        /// <param name="titles">Titles for the columns.</param>
        /// <param name="dataGrid">Current DataGrid ti recreate.</param>
        private static void CreateNewDataGtid(string[] titles, DataGridView dataGrid)
        {
            // Cleaning everything up.
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < titles.Length; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = titles[i];
                column.ReadOnly = true;
                column.CellTemplate = new DataGridViewTextBoxCell();
                dataGrid.Columns.Add(column);
                // Coloring DataGrid inside.
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                foreach (DataGridViewColumn col in dataGrid.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
        }
        /// <summary>
        /// Method for creating everything you need before you start working with the form.
        /// </summary>
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < StartForm.AllUsers.Count; i++)
            {
                // Checking that it's not an admin.
                if (StartForm.AllUsers[i].Email != "admin@mail.ru")
                {
                    // Sticking the picture for the new node.
                    TreeNode user = new TreeNode { Text = StartForm.AllUsers[i].Email, ImageIndex = 1, SelectedImageIndex = 1 };
                    AllUsersTree.Nodes[0].Nodes.Add(user);
                }
            }
            AllUsersTree.ExpandAll();
            // Craeting a new DtaGrid.
            string[] titles = new string[3] { "Order Number", "Order Status", "Order Price" };
            CreateNewDataGtid(titles, OrdersDataGrid);
            for (int i = 0; i < StartForm.AllUsers.Count; i++)
            {
                for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                {
                    string[] row = new string[3] { StartForm.AllUsers[i].AllOrders[j].OrderNumber, StartForm.AllUsers[i].AllOrders[j].OrderStatus.ToString(), StartForm.AllUsers[i].AllOrders[j].OrderPrice.ToString() };
                    OrdersDataGrid.Rows.Add(row);
                }
            }
            // Coloring the datagrids in AliceBlue for 
            UsersOrdersInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            UsersOrdersInfo.EnableHeadersVisualStyles = false;
            OrdersDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            OrdersDataGrid.EnableHeadersVisualStyles = false;
            // Subscribe context menu items to ivents.
            ChangeToProcessed.Click += ChangeToProcessed_Clicked;
            ChangeToShipped.Click += ChangeToShipped_Clicked;
            ChangeToCompleted.Click += ChangeToCompleted_Clicked;
        }
        /// <summary>
        /// Event for changing status to completed.
        /// </summary>
        private void ChangeToCompleted_Clicked(object sender, EventArgs e)
        {
            if (CurrentOrder != null)
            {
                CurrentOrder.OrderStatus = Status.Completed;
            }
            // Redrawing the DataGrid with new data.
            RewriteDataGrid(OrdersDataGrid);
        }
        /// <summary>
        /// Event for changing status to shipped.
        /// </summary>
        private void ChangeToShipped_Clicked(object sender, EventArgs e)
        {
            if (CurrentOrder != null)
            {
                CurrentOrder.OrderStatus = Status.Shipped;
            }
            // Redrawing the DataGrid with new data.
            RewriteDataGrid(OrdersDataGrid);
        }
        /// <summary>
        /// Event for changing status to processed.
        /// </summary>
        private void ChangeToProcessed_Clicked(object sender, EventArgs e)
        {
            if (CurrentOrder != null)
            {
                CurrentOrder.OrderStatus = Status.Processed;
            }
            // Redrawing the DataGrid with new data.
            RewriteDataGrid(OrdersDataGrid);
        }
        /// <summary>
        /// Method for recreating DataGrid.
        /// </summary>
        /// <param name="OrdersDataGrid">DataGrid that needed to be rewriten.</param>
        private static void RewriteDataGrid(DataGridView OrdersDataGrid)
        {
            string[] titles = new string[3] { "Order Number", "Order Status", "Order Price" };
            CreateNewDataGtid(titles, OrdersDataGrid);
            for (int i = 0; i < StartForm.AllUsers.Count; i++)
            {
                for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                {
                    string[] row = new string[3] { StartForm.AllUsers[i].AllOrders[j].OrderNumber, StartForm.AllUsers[i].AllOrders[j].OrderStatus.ToString(), StartForm.AllUsers[i].AllOrders[j].OrderPrice.ToString() };
                    OrdersDataGrid.Rows.Add(row);
                }
            }
        }
        /// <summary>
        /// Method for showing only active orders.
        /// </summary>
        private void OnlyActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string[] titles = new string[3] { "Order Number", "Order Status", "Order Price" };
            // Cleaning the DataGrid.
            CreateNewDataGtid(titles, OrdersDataGrid);
            for (int i = 0; i < StartForm.AllUsers.Count; i++)
            {
                for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                {
                    // If the check box is checked, we check that the status is not complete.
                    if (OnlyActiveCheckBox.Checked)
                    {
                        if (StartForm.AllUsers[i].AllOrders[j].OrderStatus != Status.Completed)
                        {
                            string[] row = new string[3] { StartForm.AllUsers[i].AllOrders[j].OrderNumber, StartForm.AllUsers[i].AllOrders[j].OrderStatus.ToString(), StartForm.AllUsers[i].AllOrders[j].OrderPrice.ToString() };
                            OrdersDataGrid.Rows.Add(row);
                        }
                    }
                    else
                    {
                        string[] row = new string[3] { StartForm.AllUsers[i].AllOrders[j].OrderNumber, StartForm.AllUsers[i].AllOrders[j].OrderStatus.ToString(), StartForm.AllUsers[i].AllOrders[j].OrderPrice.ToString() };
                        OrdersDataGrid.Rows.Add(row);
                    }
                }
            }
        }
        /// <summary>
        /// Method for finding current order and change the context menu.
        /// </summary>
        private void OrdersDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Just in case, an empty try-catch, because there may be exeptions.
            try
            {
                var SelectedCell = OrdersDataGrid.SelectedCells[0].Value.ToString();
                var CurrenrRowNumber = OrdersDataGrid.CurrentCell.RowIndex;
                if (SelectedCell != null)
                {
                    string orderToPay = OrdersDataGrid.Rows[CurrenrRowNumber].Cells[0].Value.ToString();
                    string orderToChangeStatus = OrdersDataGrid.Rows[CurrenrRowNumber].Cells[1].Value.ToString();
                    ChangeEnabled(orderToChangeStatus, ChangeToProcessed, ChangeToShipped, ChangeToCompleted);
                    for(int i = 0; i < StartForm.AllUsers.Count; i++)
                    {
                        for(int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                        {
                            if(StartForm.AllUsers[i].AllOrders[j].OrderNumber == orderToPay)
                            {
                                CurrentOrder = StartForm.AllUsers[i].AllOrders[j];
                            }
                        }
                    }
                }
            }
            catch
            {
                // They will not affect the operation of the program at all, so thic block is empty.
            }
        }
        /// <summary>
        /// Method to find out the status int the cell.
        /// </summary>
        /// <param name="orderToPayStatus">Current cell status.</param>
        /// <param name="ChangeToProcessed">ToolStripMenuItem for processed status.</param>
        /// <param name="ChangeToShipped">ToolStripMenuItem for the shipped status.</param>
        /// <param name="ChangeToCompleted">ToolStripMenuItem for the completed status.</param>
        private static void ChangeEnabled(string orderToPayStatus, ToolStripMenuItem ChangeToProcessed, ToolStripMenuItem ChangeToShipped, ToolStripMenuItem ChangeToCompleted)
        {
            if (orderToPayStatus == Status.________.ToString())
            {
                ChangeToProcessed.Enabled = true;
                ChangeToShipped.Enabled = false;
                ChangeToCompleted.Enabled = false;
            }
            else if (orderToPayStatus == Status.Paid.ToString())
            {
                ChangeToProcessed.Enabled = false;
                ChangeToShipped.Enabled = true;
                ChangeToCompleted.Enabled = true;
            }
            else if (orderToPayStatus == Status.Shipped.ToString())
            {
                ChangeToProcessed.Enabled = false;
                ChangeToShipped.Enabled = false;
                ChangeToCompleted.Enabled = true;
            }
            else if (orderToPayStatus == Status.Completed.ToString())
            {
                ChangeToProcessed.Enabled = false;
                ChangeToShipped.Enabled = false;
                ChangeToCompleted.Enabled = false;
            }
        }
        /// <summary>
        /// Method for saving the information.
        /// </summary>
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            // Cleaning up the file.
            if (File.Exists("SavedUsers.json"))
            {
                StreamWriter writer = new StreamWriter("SavedUsers.json");
                writer.WriteLine("");
                writer.Close();
            }
            // Saving evetything in the file.
            using (StreamWriter streamWriter = new StreamWriter(new FileStream("SavedUsers.json", FileMode.Create)))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(streamWriter, StartForm.AllUsers);
            }
            SaveTimer.Start();
        }
    }
}
