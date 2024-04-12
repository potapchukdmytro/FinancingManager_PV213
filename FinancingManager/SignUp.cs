using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancingManager;
using FinancingManager.Entities;
using FinancingManager.Repositories;
using FinancingManager.Validation;

namespace FinancingManager
{
    public partial class SignUp : Form
    {
        public DialogResult result;

        public SignUp()
        {
            InitializeComponent();
            result = DialogResult.Abort;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository(new AppDbContext());
            UserEntity newUser = new UserEntity 
            { 
                Name = nameTextBox.Text,
                UserName = usernameTextBox.Text,
                Email = emailTextBox.Text,
                LastName = surnameTextBox.Text,
                Password = passwordTextBox.Text
            };

            RegisterModelValidator validator = new RegisterModelValidator();
            var res = validator.Validate(newUser);

            foreach (var error in res.Errors)
            {
                if (error.PropertyName == "Email")
                {
                    emailError.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Password")
                {
                    passwordError.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "UserName")
                {
                    usernameError.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "LastName")
                {
                    surnameError.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Name")
                {
                    nameError.Text = error.ErrorMessage;
                    return;
                }
            }

            if (CheckNewUser(userRepository, newUser))
            {
                userRepository.AddAsync(newUser);
                this.result = DialogResult.OK;
                Close();
            }
            else
            {
                mainLabel.Text = "Try another email or username!";
            }
        }

        private bool CheckNewUser(UserRepository repository, UserEntity newUser)
        {
            var users = repository.Users;

            foreach (var user in users)
            {
                if (user.UserName == newUser.UserName) return false;
                else if (user.Email == newUser.Email) return false;
            }

            return true;
        }
    }
}
