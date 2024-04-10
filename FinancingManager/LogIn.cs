using FinancingManager.Models;
using FinancingManager.Services;
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
        public UserModel? user;
        private readonly UserService userService;

        public LogIn(UserService userService)
        {
            InitializeComponent();
            user = null;
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

        private void logInBtn_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                label2.Text = "Required";
                label2.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                label3.Text = "Required";
                label3.Visible = true;
                return;
            }


            //UserModel foundUser = userService.GetUserByUsername(username);
            //if (foundUser != null && foundUser.Password == password)
            //{
            //    user = foundUser;
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
