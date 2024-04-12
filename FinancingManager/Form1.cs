using FinancingManager.Services;

namespace FinancingManager
{
    public partial class MainForm : Form
    {
        private readonly UserService userService;

        public MainForm(Config config)
        {
            InitializeComponent();

            userService = config.UserService;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            LogIn logIn = new LogIn(userService);
            logIn.ShowDialog();

            if(logIn.CurrentUser == null)
            {
                Close();
            }
        }
    }
}
