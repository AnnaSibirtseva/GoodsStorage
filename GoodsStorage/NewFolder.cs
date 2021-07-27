using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class NewFolder : Form
    {
        // A variable to check whether we are making changes or just creating a new element.
        public bool Changes;
        // Variable to understand that we need a report.
        public bool ForCSVFiles;
        public static bool ForCSVDefectiveItems;
        public static Item DefectiveItem;
        private static Dictionary<User, double> UsersForReport = new Dictionary<User, double>();
        private static Dictionary<User, DateTime> UsersForReportDefective = new Dictionary<User, DateTime>();
        public NewFolder()
        {
            InitializeComponent();
            // Limiting the files that can be opened.
            SaveFileDialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
        }
        /// <summary>
        /// Method for creating a folder or for changing the node name.
        /// </summary>
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            // Checking what are we going to do: create or rename.
            if (!Changes)
            {
                if (!ForCSVFiles)
                {
                    if (this.NameBox.Text != null && this.NameBox.Text != "")
                    {
                        // If folder does not exists.
                        if (ContainsFolder(NameBox.Text))
                        {
                            CreateFolder(NameBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("The folder with this name already exists.", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }

                    }
                    else
                    {
                        MessageBox.Show("You didn't enter a name, so the folder wasn't created.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    FindNumber(NameBox.Text, SaveFileDialog);
                }
            }
            else
            {
                // Calling method for renaming. 
                CreateNewName(NameBox.Text);
                Changes = false;
            }
            this.Close();
        }
        /// <summary>
        /// Method for finding all items whose number is less than the one specified by the user.
        /// </summary>
        /// <param name="number">Number that user inputed.</param>
        /// <param name="saveFile">Just a file dialog for saving a CSV report.</param>
        public static void FindNumber(string number, SaveFileDialog saveFile)
        {
            if (!ForCSVDefectiveItems)
            {
                // Checking that user input was correct.
                if (uint.TryParse(number, out uint intNumber))
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        for (int i = 0; i < StartForm.AllUsers.Count; i++)
                        {
                            double totalPrice = 0;
                            for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                            {
                                totalPrice += StartForm.AllUsers[i].AllOrders[j].OrderPrice;
                            }
                            if (totalPrice > intNumber)
                            {
                                UsersForReport.Add(StartForm.AllUsers[i], totalPrice);
                            }
                        }
                        // Ordering by the total price of all orders.
                        UsersForReport = UsersForReport.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                        // Creating a new CSV report.
                        CreateLine(saveFile.FileName);
                    }
                }
            }
            else
            {
                if (IsThereSuchAnItem(number))
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        FindDefectiveItems(saveFile.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("The item with this name does not exists.", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public static bool IsThereSuchAnItem(string itemName)
        {
            for (int i = 0; i < StorageForm.Items.Count; i++)
            {
                if (StorageForm.Items[i].Name == itemName)
                {
                    DefectiveItem = StorageForm.Items[i];
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public static void FindDefectiveItems(string fileName)
        {
            for (int i = 0; i < StartForm.AllUsers.Count; i++)
            {
                for (int j = 0; j < StartForm.AllUsers[i].AllOrders.Count; j++)
                {
                    for (int k = 0; k < StartForm.AllUsers[i].AllOrders[j].Purchases.Count; k++)
                    {
                        if (StartForm.AllUsers[i].AllOrders[j].Purchases[k].Name == DefectiveItem.Name)
                        {
                            if (!UsersForReportDefective.ContainsKey(StartForm.AllUsers[i]))
                            {
                                if (StartForm.AllUsers[i].AllOrders[j].OrderStatus == Status.Shipped)
                                {
                                    DateTime orderDate = DateTime.ParseExact(StartForm.AllUsers[i].AllOrders[j].OrderNumber, "ddMMyyyyHHmmss", null);
                                    UsersForReportDefective.Add(StartForm.AllUsers[i], orderDate);

                                }
                            }
                        }
                    }
                }
            }
            // Creating a new CSV report.
            CreateNewDefectiveReport(fileName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        private static void CreateNewDefectiveReport(string fileName)
        {
            var report = new StringBuilder();
            // Writing headers.
            string line = "User" + ";" + "Order Date";
            report.AppendLine(line);
            if (UsersForReportDefective.Keys.Count != 0)
            {
                foreach (var elem in UsersForReportDefective.Keys)
                {
                    line = elem.Email + ";" + UsersForReportDefective[elem].ToString();
                    report.AppendLine(line);
                }
                // Writing to the file.
                File.WriteAllText(fileName, report.ToString());
            }
        }
        /// <summary>
        /// Method for creating a new CSV report.
        /// </summary>
        /// <param name="fileName">User selected name.</param>
        public static void CreateLine(string fileName)
        {
            var report = new StringBuilder();
            // Writing headers.
            string line = "User" + ";" + "Paid Money";
            report.AppendLine(line);
            if (UsersForReport.Keys.Count != 0)
            {
                foreach (var elem in UsersForReport.Keys)
                {
                    line = elem.Email + ";" + UsersForReport[elem];
                    report.AppendLine(line);
                }
                // Writing to the file.
                File.WriteAllText(fileName, report.ToString());
            }
        }
        /// <summary>
        /// Method for creating a new folder.
        /// </summary>
        /// <param name="name">New folder name.</param>
        public static void CreateFolder(string name)
        {
            Folder new_folder = new Folder(name);
            StorageForm.Folders.Add(new_folder);
            StorageForm.CurrentFolder.AllNodes.Add(new_folder);
            // Attaching the picture to the node.
            TreeNode folder = new TreeNode { Text = name, ImageIndex = 0, SelectedImageIndex = 0 };
            StorageForm.CurrentNode.Nodes.Add(folder);
            // Opening all the nodes.
            (Application.OpenForms[1] as StorageForm).TreeView.ExpandAll();
        }
        /// <summary>
        /// Method for renaming the folder/item.
        /// </summary>
        /// <param name="name">Name that user inputed in the textbox.</param>
        public static void CreateNewName(string name)
        {
            // If element was in the Items list then we skip the part of checking the Folders list.
            bool flag = false;
            for (int i = 0; i < StorageForm.Items.Count; i++)
            {
                if (StorageForm.CurrentNode.Text == StorageForm.Items[i].Name)
                {
                    // If something with this name alredy exists then an error shows.
                    if (StorageForm.Items[i].Name == name)
                    {
                        MessageBox.Show("The element was not renamed because the name is already taken.", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        flag = true;
                    }
                    else
                    {
                        StorageForm.CurrentNode.Text = name;
                        StorageForm.Items[i].Name = name;
                    }
                }
            }
            if (!flag)
            {
                for (int j = 0; j < StorageForm.Folders.Count; j++)
                {
                    if (StorageForm.CurrentNode.Text == StorageForm.Folders[j].Name)
                    {
                        if (StorageForm.Folders[j].Name == name)
                        {
                            MessageBox.Show("The element was not renamed because the name is already taken.", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            StorageForm.CurrentNode.Text = name;
                            StorageForm.Folders[j].Name = name;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Method for checking if something with inputed name already exists.
        /// </summary>
        /// <param name="name">The name that user inputed.</param>
        /// <returns>True if it does not exist and False otherwise.</returns>
        public static bool ContainsFolder(string name)
        {
            // Going through all the Folders.
            for (int i = 0; i < StorageForm.Folders.Count; i++)
            {
                if (StorageForm.Folders[i].Name == name)
                {
                    return false;
                }
            }
            // Going through all the Items.
            for (int i = 0; i < StorageForm.Items.Count; i++)
            {
                if (StorageForm.Items[i].Name == name)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
