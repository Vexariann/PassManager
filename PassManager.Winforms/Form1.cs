using Microsoft.Extensions.DependencyInjection;
using PassManager.Winforms;

namespace PassManager
{
    public partial class PMHome : Form
    {
        public List<string> keySequence = new();

        public PMHome()
        {
            InitializeComponent();
            // Updates the version text based off json file
            Rootobject appInfo = Program.GetAppInfo();
            VersionText.Text = $"{appInfo.GeneralInfo.Version} - {appInfo.GeneralInfo.Author} {DateTime.Now.Year}";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = Services.ServiceProvider.GetService<LoginWindow>();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                PMDashboard dashboard = Services.ServiceProvider.GetService<PMDashboard>();
                dashboard.Show();
                this.Hide();
            }
        }

        private void PMHome_KeyDown(object sender, KeyEventArgs e)
        {
            keySequence.Add(e.KeyData.ToString());
            string result = string.Join("", keySequence);
            //MessageBox.Show(result);
            if (e.KeyCode == Keys.Subtract)
            {
                keySequence.Clear();
            }
            if (result == "DEBUGD5")
            {
                DebugForm debugForm = Services.ServiceProvider.GetService<DebugForm>();
                debugForm.Show();
            }
        }
    }
}