namespace GoodsStorage
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ProggramName = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.PasswordPicture = new System.Windows.Forms.PictureBox();
            this.SighInButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProggramName
            // 
            this.ProggramName.AutoSize = true;
            this.ProggramName.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProggramName.Location = new System.Drawing.Point(120, 9);
            this.ProggramName.Name = "ProggramName";
            this.ProggramName.Size = new System.Drawing.Size(366, 62);
            this.ProggramName.TabIndex = 0;
            this.ProggramName.Text = "Goods Storage";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(141, 107);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(64, 25);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(108, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 25);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(210, 105);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(182, 27);
            this.LoginText.TabIndex = 3;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(210, 157);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(182, 27);
            this.PasswordText.TabIndex = 4;
            // 
            // UserPicture
            // 
            this.UserPicture.Image = ((System.Drawing.Image)(resources.GetObject("UserPicture.Image")));
            this.UserPicture.Location = new System.Drawing.Point(409, 105);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(27, 27);
            this.UserPicture.TabIndex = 5;
            this.UserPicture.TabStop = false;
            // 
            // PasswordPicture
            // 
            this.PasswordPicture.Image = ((System.Drawing.Image)(resources.GetObject("PasswordPicture.Image")));
            this.PasswordPicture.Location = new System.Drawing.Point(409, 157);
            this.PasswordPicture.Name = "PasswordPicture";
            this.PasswordPicture.Size = new System.Drawing.Size(27, 27);
            this.PasswordPicture.TabIndex = 6;
            this.PasswordPicture.TabStop = false;
            // 
            // SighInButton
            // 
            this.SighInButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SighInButton.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SighInButton.Location = new System.Drawing.Point(141, 227);
            this.SighInButton.Name = "SighInButton";
            this.SighInButton.Size = new System.Drawing.Size(142, 42);
            this.SighInButton.TabIndex = 7;
            this.SighInButton.Text = "SIGN UP";
            this.SighInButton.UseVisualStyleBackColor = false;
            this.SighInButton.Click += new System.EventHandler(this.SighInButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInButton.Location = new System.Drawing.Point(294, 227);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(142, 42);
            this.LogInButton.TabIndex = 8;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(595, 317);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.SighInButton);
            this.Controls.Add(this.PasswordPicture);
            this.Controls.Add(this.UserPicture);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ProggramName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 364);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 364);
            this.Name = "StartForm";
            this.Text = " Goods Storage";
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProggramName;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.PictureBox PasswordPicture;
        private System.Windows.Forms.Button SighInButton;
        private System.Windows.Forms.Button LogInButton;
        public System.Windows.Forms.TextBox LoginText;
        public System.Windows.Forms.TextBox PasswordText;
    }
}