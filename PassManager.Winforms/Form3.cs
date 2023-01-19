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

            // Custom code to make the profile picture PictureBox a circle
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ProfilePicture.Width - 3, ProfilePicture.Height - 3);
            Region rg = new Region(gp);
            ProfilePicture.Region = rg;
        }

        private void PMDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
