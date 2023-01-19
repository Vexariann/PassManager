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
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp2.AddEllipse(0, 0, ProfilePicturePage.Width - 3, ProfilePicturePage.Height - 3);
            Region rg = new Region(gp);
            Region rn = new Region(gp2);
            ProfilePicture.Region = rg;
            ProfilePicturePage.Region = rn;

            //HideAllPanels();
            DashboardPanel.BringToFront();
        }

        private void PMDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            DashboardPanel.BringToFront();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            ProfilePanel.BringToFront();
        }

        private void HideAllPanels()
        {
            DashboardPanel.Visible = false;
            ProfilePanel.Visible = false;
        }
    }
}
