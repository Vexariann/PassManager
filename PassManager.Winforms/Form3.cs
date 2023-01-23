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

            // These are here to make sure the panels are in the right place stacked on top of each other.
            // Unfortunately I cannot stack them on top in the editor mode.
            DashboardPanel.Location = new Point(225, 0);
            ProfilePanel.Location = new Point(225, 0);
            ManagePanel.Location = new Point(225, 0);
            OptionsPanel.Location = new Point(225, 0);

            HideAllPanels();
            DashboardPanel.Visible = true;
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
            // Could be simplefied
            PMDashboard.ActiveForm.Text = "PassManager - Dashboard";
            HideAllPanels();
            DashboardPanel.Visible = true;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            PMDashboard.ActiveForm.Text = "PassManager - Profile";
            HideAllPanels();
            ProfilePanel.Visible = true;
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ManagePanel.Visible = true;
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            OptionsPanel.Visible = true;
        }

        private void HideAllPanels()
        {
            DashboardPanel.Visible = false;
            ProfilePanel.Visible = false;
            ManagePanel.Visible = false;
            OptionsPanel.Visible = false;
        }
    }
}
