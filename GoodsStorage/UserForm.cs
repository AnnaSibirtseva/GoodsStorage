using System;
using System.Windows.Forms;

namespace GoodsStorage
{
    public partial class UserForm : Form
    {
        // Array of all characters forbidden in the mail name.
        string[] ForbiddenCharacters = new string[] { "!", "#", "$", "%", "&", "'", "*", "+", "/", "=", "?", "^", "`", "{", "|", "}", "~", "@" };
        public UserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method for creating a new user.
        /// </summary>
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            // Checking that line is not empty.
            if (AddressText.Text != "" || AddressText != null)
            {
                if (ParseTelephoneNumber(TelephoneText.Text))
                {
                    if (ParseEmail(EmailText.Text))
                    {
                        if (EmailComboBox.Text == "")
                        {
                            MessageBox.Show("You didn't select a mail domain.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            // Creating a new user.
                            User user = new User(InitialsText.Text, ulong.Parse(TelephoneText.Text), AddressText.Text, EmailText.Text + EmailComboBox.Text, PasswordText.Text);
                            StartForm.AllUsers.Add(user);

                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The mail can't contain characters from this list: !#$%&'*+@/=?^`{|}~", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show("The phone number must be digits only and must be 5-11 characters long.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show("You didn't enter your address information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        /// <summary>
        /// Method for checking the correctness of the mail input.
        /// </summary>
        /// <param name="mail">Email for checking.</param>
        /// <returns>True if everything goes right and False otherwise.</returns>
        private bool ParseEmail(string mail)
        {
            // Checking that line is not empty.
            if (mail == null || mail == "")
            {
                return false;
            }
            for (int i = 0; i < ForbiddenCharacters.Length; i++)
            {
                // Checking that line does not have any forbidden characters.
                if (mail.Contains(ForbiddenCharacters[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Method for checking the correctness of the telephone number input.
        /// </summary>
        /// <param name="number">Telephone number for checking.</param>
        /// <returns>True if everything goes right and False otherwise.</returns>
        private bool ParseTelephoneNumber(string number)
        {
            if (ulong.TryParse(number, out ulong ulongNumber))
            {
                // Checking that telephone number located within certain boundaries.
                if (ulongNumber.ToString().Length >= 5 && ulongNumber.ToString().Length <= 11)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
