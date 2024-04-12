using FinancingManager.Models;
using FinancingManager.Services;

namespace FinancingManager
{
    public partial class MainForm : Form
    {
        private readonly UserService userService;
        private UserModel? currentUser;
        private const string currentUserPath = "currentUser"; 

        public MainForm(Config config)
        {
            InitializeComponent();
            currentUser = null;
            userService = config.UserService;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(currentUserPath))
                {
                    string data = File.ReadAllText(currentUserPath).Trim();
                    int id = int.Parse(data);
                    currentUser = await userService.GetByIdAsync(id);
                    if (currentUser != null)
                    {
                        textBoxCurrentUser.Text = "Logged in as: " + currentUser.UserName;
                        return;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Hide();
            LogIn logIn = new LogIn(userService);
            logIn.ShowDialog();

            if(logIn.CurrentUser == null)
            {
                Close();
            }
            else
            {
                currentUser = logIn.CurrentUser;
                SaveUserToFile();
                Show();
                textBoxCurrentUser.Text = "Logged in as: " + currentUser.UserName;
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            currentUser = null;
            File.Delete(currentUserPath);
            Hide();
            LogIn logIn = new LogIn(userService);
            logIn.ShowDialog();

            if (logIn.CurrentUser == null)
            {
                Close();
            }
            else
            {
                currentUser = logIn.CurrentUser;
                SaveUserToFile();
                Show();
                textBoxCurrentUser.Text = "Logged in as: " + currentUser.UserName;
            }
        }

        private void SaveUserToFile()
        {
            if (currentUser != null)
            {
                File.WriteAllText(currentUserPath, currentUser.Id.ToString());
            }
        }
    }
}
