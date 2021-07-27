namespace GoodsStorage
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.MainLabel = new System.Windows.Forms.Label();
            this.InitialsText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.PassworLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.InitialsLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainLabel.Location = new System.Drawing.Point(121, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(509, 45);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Please enter user information ";
            // 
            // InitialsText
            // 
            this.InitialsText.Location = new System.Drawing.Point(92, 74);
            this.InitialsText.Name = "InitialsText";
            this.InitialsText.Size = new System.Drawing.Size(210, 27);
            this.InitialsText.TabIndex = 1;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(92, 141);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(210, 27);
            this.AddressText.TabIndex = 2;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(161, 211);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(210, 27);
            this.EmailText.TabIndex = 3;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(477, 74);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(210, 27);
            this.PasswordText.TabIndex = 4;
            // 
            // TelephoneText
            // 
            this.TelephoneText.Location = new System.Drawing.Point(477, 141);
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(210, 27);
            this.TelephoneText.TabIndex = 5;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateUserButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateUserButton.Location = new System.Drawing.Point(227, 261);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(276, 55);
            this.CreateUserButton.TabIndex = 6;
            this.CreateUserButton.Text = "CONTINUE";
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // PassworLabel
            // 
            this.PassworLabel.AutoSize = true;
            this.PassworLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassworLabel.Location = new System.Drawing.Point(374, 76);
            this.PassworLabel.Name = "PassworLabel";
            this.PassworLabel.Size = new System.Drawing.Size(97, 25);
            this.PassworLabel.TabIndex = 7;
            this.PassworLabel.Text = "Password:";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TelephoneLabel.Location = new System.Drawing.Point(366, 144);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(105, 25);
            this.TelephoneLabel.TabIndex = 8;
            this.TelephoneLabel.Text = "Telephone:";
            // 
            // InitialsLabel
            // 
            this.InitialsLabel.AutoSize = true;
            this.InitialsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitialsLabel.Location = new System.Drawing.Point(12, 76);
            this.InitialsLabel.Name = "InitialsLabel";
            this.InitialsLabel.Size = new System.Drawing.Size(67, 25);
            this.InitialsLabel.TabIndex = 9;
            this.InitialsLabel.Text = "Name:";
            this.InitialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(1, 144);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(85, 25);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(92, 213);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 25);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Items.AddRange(new object[] {
            "@yandex.ru",
            "@mail.ru",
            "@gmail.com",
            "@rambler.ru",
            "@outlook.com"});
            this.EmailComboBox.Location = new System.Drawing.Point(382, 210);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(210, 28);
            this.EmailComboBox.TabIndex = 12;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(728, 340);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.InitialsLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.PassworLabel);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.TelephoneText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.InitialsText);
            this.Controls.Add(this.MainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 387);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(746, 387);
            this.Name = "UserForm";
            this.Text = " User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label PassworLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label InitialsLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.ComboBox EmailComboBox;
        public System.Windows.Forms.TextBox InitialsText;
        public System.Windows.Forms.TextBox PasswordText;
        public System.Windows.Forms.TextBox EmailText;
    }
}