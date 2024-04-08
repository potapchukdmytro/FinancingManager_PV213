namespace FinancingManager
{
    partial class LogIn
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
            this.logInLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInLabel.Location = new System.Drawing.Point(120, 21);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(95, 42);
            this.logInLabel.TabIndex = 0;
            this.logInLabel.Text = "Log In";
            this.logInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(96, 76);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(205, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(12, 82);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(12, 120);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(205, 23);
            this.passwordTextBox.TabIndex = 4;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 181);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.logInLabel);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label logInLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
    }
}