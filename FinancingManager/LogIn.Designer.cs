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
            logInLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            logInBtn = new Button();
            signUpBtn = new Button();
            SuspendLayout();
            // 
            // logInLabel
            // 
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            logInLabel.Location = new Point(137, 28);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(117, 52);
            logInLabel.TabIndex = 0;
            logInLabel.Text = "Log In";
            logInLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(110, 101);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(234, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(14, 109);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(90, 22);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(14, 160);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 22);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(110, 152);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(234, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.OliveDrab;
            logInBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = SystemColors.ButtonFace;
            logInBtn.Location = new Point(14, 217);
            logInBtn.Margin = new Padding(3, 4, 3, 4);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(167, 37);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.SteelBlue;
            signUpBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = SystemColors.ButtonFace;
            signUpBtn.Location = new Point(187, 217);
            signUpBtn.Margin = new Padding(3, 4, 3, 4);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(157, 37);
            signUpBtn.TabIndex = 6;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 271);
            Controls.Add(signUpBtn);
            Controls.Add(logInBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(logInLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logInLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button logInBtn;
        private Button signUpBtn;
    }
}