using System.Windows.Forms;

namespace InventoryManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Data.DatabaseManager.InitializeDatabase();

            while (true)
            {
                using var loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK || loginForm.LoggedInUser == null)
                    break;

                var mainForm = new Form1(loginForm.LoggedInUser);
                Application.Run(mainForm);

                if (!mainForm.LogoutRequested)
                    break;
            }
        }
    }
}
