using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class StartForm : Form
    {
        public static List<User> AllUsers = new List<User>();
        public static User Admin;
        public StartForm()
        {
            InitializeComponent();
            // Creating admin.
            User admin = new User("doctor_who", 88005553535, "Baker Street 221B", "admin@mail.ru", "12345");
            Admin = admin;
            AllUsers.Add(admin);
            // Loading all saved data.
            LoadAllUsers();
        }
        /// <summary>
        /// Method for signing up new user.
        /// </summary>
        private void SighInButton_Click(object sender, EventArgs e)
        {
            // A variable to check that there is no such user yet.
            bool flag = false;
            if((LoginText.Text != null) && (LoginText.Text != "") && (PasswordText.Text != null) && (PasswordText.Text != ""))
            {
                for(int i = 0; i < AllUsers.Count; i++)
                {
                    string userEmail = AllUsers[i].Email.Split('@')[0];
                    if (userEmail == LoginText.Text)
                    {
                        MessageBox.Show("User with this login already exists.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        flag = true;
                    }
                }
                if (!flag)
                {
                    if (PasswordText.Text.Length < 5)
                    {
                        MessageBox.Show("The password must be at least five characters long.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        UserForm userForm = new UserForm();
                        userForm.EmailText.Text = LoginText.Text;
                        userForm.PasswordText.Text = PasswordText.Text;
                        userForm.ShowDialog();
                    }
                }
            }
        }
        /// <summary>
        /// Method to log in user.
        /// </summary>
        private void LogInButton_Click(object sender, EventArgs e)
        {
            // A variable to check that user with such login exists.
            bool flag = false;
            if ((LoginText.Text != null) && (LoginText.Text != "") && (PasswordText.Text != null) && (PasswordText.Text != ""))
            {
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    string userEmail = AllUsers[i].Email.Split('@')[0];
                    string adminEmail = Admin.Email.Split('@')[0];
                    if (userEmail == LoginText.Text)
                    {
                        if(AllUsers[i].Password == PasswordText.Text)
                        {
                            if (userEmail == adminEmail && AllUsers[i].Password == Admin.Password)
                            {
                                StorageForm storage = new StorageForm();
                                storage.Show();
                                Hide();
                            }
                            else
                            {
                                ShopForm shop = new ShopForm();
                                shop.CurrentUserName.Text = userEmail;
                                ShopForm.CurrentUser = AllUsers[i];
                                shop.Show();
                                Hide();
                            }
                            flag = true;
                        }
                        else
                        {
                            MessageBox.Show("Wrong password, please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("User with this login does not exists.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
        /// <summary>
        /// Method for loading all users data in the beginning if the program.
        /// </summary>
        private void LoadAllUsers()
        {
            using (StreamReader streamReader = new StreamReader(new FileStream("SavedUsers.json", FileMode.Open)))
            {
                string savedData = streamReader.ReadToEnd();
                var SavedThings = JsonConvert.DeserializeObject<List<User>>(savedData);
                // Assign the list of previously saved users.
                AllUsers = SavedThings;
            }
        }
    }
}
