using FinancingManager.Models;
using FinancingManager.Services;
using FinancingManager.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancingManager
{
    public partial class LogIn : Form
    {
        public UserModel? CurrentUser;
        private readonly UserService userService;

        public LogIn(UserService userService)
        {
            InitializeComponent();
            CurrentUser = null;
            this.userService = userService;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();

            if (signUp.result == DialogResult.Abort)
                this.Close();
            else
                this.Visible = true;
        }

        private async void logInBtn_Click(object sender, EventArgs e)
        {
            LogInModel model = new LogInModel
            {
                Login = usernameTextBox.Text,
                Password = passwordTextBox.Text
            };

            LoginModelValidator validator = new LoginModelValidator();
            var res = validator.Validate(model);

            usernameError.Visible = false;
            passwordError.Visible = false;

            foreach (var error in res.Errors)
            {
                if(error.PropertyName == "Login")
                {
                    if (!usernameError.Visible)
                    {
                        usernameError.Text = error.ErrorMessage;
                        usernameError.Visible = true;
                    }
                        
                }
                if (error.PropertyName == "Password")
                {
                    if(!passwordError.Visible)
                    {
                        passwordError.Text = error.ErrorMessage;
                        passwordError.Visible = true;
                    }
                }
            }

            var user = await userService.Login(model);

            if(user == null)
            {
                MessageBox.Show("Не вірний логін або пароль");
            }
            else
            {
                CurrentUser = user;
                Close();
            }
        }
    }
}
