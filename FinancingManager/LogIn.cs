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
            user = userService.GetUsers()[0];
            Close();
        }
    }
}
