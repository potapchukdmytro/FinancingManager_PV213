namespace FinancingManager
{
    partial class SignUp
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
            usernameLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signUpLabel = new Label();
            logInBtn = new Button();
            signUpBtn = new Button();
            nameLabel = new Label();
            surnameLabel = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(15, 103);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(90, 22);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            emailLabel.Location = new Point(17, 155);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(62, 22);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(17, 313);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 22);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(138, 95);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(202, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(138, 147);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(202, 27);
            emailTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(138, 305);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(202, 27);
            passwordTextBox.TabIndex = 5;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            signUpLabel.Location = new Point(125, 12);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(141, 52);
            signUpLabel.TabIndex = 6;
            signUpLabel.Text = "Sign Up";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.SteelBlue;
            logInBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = SystemColors.ButtonFace;
            logInBtn.Location = new Point(174, 382);
            logInBtn.Margin = new Padding(3, 4, 3, 4);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(167, 37);
            logInBtn.TabIndex = 7;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.OliveDrab;
            signUpBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = SystemColors.ButtonFace;
            signUpBtn.Location = new Point(15, 382);
            signUpBtn.Margin = new Padding(3, 4, 3, 4);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(157, 37);
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(17, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 22);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            surnameLabel.Location = new Point(15, 259);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(81, 22);
            surnameLabel.TabIndex = 10;
            surnameLabel.Text = "Surname";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(138, 201);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 27);
            nameTextBox.TabIndex = 11;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(138, 251);
            surnameTextBox.Margin = new Padding(3, 4, 3, 4);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(202, 27);
            surnameTextBox.TabIndex = 12;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 432);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Controls.Add(signUpBtn);
            Controls.Add(logInBtn);
            Controls.Add(signUpLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(usernameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            Text = "SignUp";
            FormClosing += SignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label signUpLabel;
        private Button logInBtn;
        private Button signUpBtn;
        private Label nameLabel;
        private Label surnameLabel;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
    }
}