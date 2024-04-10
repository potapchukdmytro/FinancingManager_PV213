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
    public partial class SignUp : Form
    {
        public DialogResult result;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            result = DialogResult.Abort;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
