namespace PassManager.Winforms
{
    public partial class PMDashboard : Form
    {
        public PMDashboard()
        {
            InitializeComponent();
            // Updates the version text based off json file
            Rootobject appInfo = Program.GetAppInfo();
            VersionText.Text = $"{appInfo.GeneralInfo.Version} - {appInfo.GeneralInfo.Author} {DateTime.Now.Year}";
        }
    }
}
