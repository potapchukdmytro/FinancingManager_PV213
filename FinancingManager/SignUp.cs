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
            // Register logic
            result = DialogResult.OK;

            // if ok
            Close();
        }
    }
}
