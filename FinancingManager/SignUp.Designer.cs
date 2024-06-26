﻿namespace FinancingManager
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
            mainLabel = new Label();
            usernameError = new Label();
            emailError = new Label();
            nameError = new Label();
            surnameError = new Label();
            passwordError = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(13, 77);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(71, 17);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            emailLabel.Location = new Point(13, 125);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 17);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(13, 277);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(69, 17);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(121, 71);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(177, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(119, 119);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(177, 23);
            emailTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(119, 271);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(177, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            signUpLabel.Location = new Point(109, 9);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(115, 42);
            signUpLabel.TabIndex = 6;
            signUpLabel.Text = "Sign Up";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.SteelBlue;
            logInBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logInBtn.ForeColor = SystemColors.ButtonFace;
            logInBtn.Location = new Point(151, 328);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(146, 28);
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
            signUpBtn.Location = new Point(12, 328);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(137, 28);
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(13, 176);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 17);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Cambria", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            surnameLabel.Location = new Point(12, 230);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(64, 17);
            surnameLabel.TabIndex = 10;
            surnameLabel.Text = "Surname";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(119, 170);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(177, 23);
            nameTextBox.TabIndex = 11;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(120, 224);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(177, 23);
            surnameTextBox.TabIndex = 12;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.Location = new Point(14, 336);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(0, 20);
            mainLabel.TabIndex = 13;
            // 
            // usernameError
            // 
            usernameError.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            usernameError.ForeColor = Color.Red;
            usernameError.Location = new Point(120, 97);
            usernameError.Name = "usernameError";
            usernameError.Size = new Size(177, 19);
            usernameError.TabIndex = 14;
            usernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailError
            // 
            emailError.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            emailError.ForeColor = Color.Red;
            emailError.Location = new Point(119, 148);
            emailError.Name = "emailError";
            emailError.Size = new Size(177, 19);
            emailError.TabIndex = 15;
            emailError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameError
            // 
            nameError.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            nameError.ForeColor = Color.Red;
            nameError.Location = new Point(120, 202);
            nameError.Name = "nameError";
            nameError.Size = new Size(177, 19);
            nameError.TabIndex = 16;
            nameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // surnameError
            // 
            surnameError.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            surnameError.ForeColor = Color.Red;
            surnameError.Location = new Point(120, 250);
            surnameError.Name = "surnameError";
            surnameError.Size = new Size(177, 19);
            surnameError.TabIndex = 17;
            surnameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordError
            // 
            passwordError.Font = new Font("Segoe Print", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(119, 297);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(177, 19);
            passwordError.TabIndex = 18;
            passwordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 372);
            Controls.Add(passwordError);
            Controls.Add(surnameError);
            Controls.Add(nameError);
            Controls.Add(emailError);
            Controls.Add(usernameError);
            Controls.Add(mainLabel);
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
        private Label mainLabel;
        private Label usernameError;
        private Label emailError;
        private Label nameError;
        private Label surnameError;
        private Label passwordError;
    }
}