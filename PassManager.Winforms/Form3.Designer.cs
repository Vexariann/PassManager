namespace PassManager.Winforms
{
    partial class PMDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMDashboard));
            this.VersionText = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.ManageButtonImage = new System.Windows.Forms.PictureBox();
            this.ManageButton = new System.Windows.Forms.Button();
            this.ProfileButtonImage = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.DashboardButtonImage = new System.Windows.Forms.PictureBox();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.Seperator = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.PasswordList = new System.Windows.Forms.ListBox();
            this.filterMenu = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.PasswordThumbnail = new System.Windows.Forms.PictureBox();
            this.PasswordRevealButton = new System.Windows.Forms.Button();
            this.UsernameTitleLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTitleLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionText
            // 
            this.VersionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionText.AutoSize = true;
            this.VersionText.BackColor = System.Drawing.Color.Transparent;
            this.VersionText.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionText.ForeColor = System.Drawing.Color.DimGray;
            this.VersionText.Location = new System.Drawing.Point(12, 524);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(206, 15);
            this.VersionText.TabIndex = 3;
            this.VersionText.Text = "V0.0001 BETA build - Vexarian 2022";
            this.VersionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.MainMenu.Controls.Add(this.pictureBox1);
            this.MainMenu.Controls.Add(this.OptionsButton);
            this.MainMenu.Controls.Add(this.ManageButtonImage);
            this.MainMenu.Controls.Add(this.ManageButton);
            this.MainMenu.Controls.Add(this.ProfileButtonImage);
            this.MainMenu.Controls.Add(this.ProfileButton);
            this.MainMenu.Controls.Add(this.DashboardButtonImage);
            this.MainMenu.Controls.Add(this.DashboardButton);
            this.MainMenu.Controls.Add(this.Seperator);
            this.MainMenu.Controls.Add(this.ProfileName);
            this.MainMenu.Controls.Add(this.ProfilePicture);
            this.MainMenu.Controls.Add(this.VersionText);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(225, 548);
            this.MainMenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::PassManager.Winforms.Properties.Resources.PassManagerSettings;
            this.pictureBox1.Location = new System.Drawing.Point(26, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // OptionsButton
            // 
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.OptionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.ForeColor = System.Drawing.Color.White;
            this.OptionsButton.Location = new System.Drawing.Point(-6, 292);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(235, 57);
            this.OptionsButton.TabIndex = 13;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            // 
            // ManageButtonImage
            // 
            this.ManageButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.ManageButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManageButtonImage.Image = global::PassManager.Winforms.Properties.Resources.PassManagerManage;
            this.ManageButtonImage.Location = new System.Drawing.Point(26, 241);
            this.ManageButtonImage.Name = "ManageButtonImage";
            this.ManageButtonImage.Size = new System.Drawing.Size(24, 29);
            this.ManageButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManageButtonImage.TabIndex = 12;
            this.ManageButtonImage.TabStop = false;
            // 
            // ManageButton
            // 
            this.ManageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageButton.FlatAppearance.BorderSize = 0;
            this.ManageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManageButton.ForeColor = System.Drawing.Color.White;
            this.ManageButton.Location = new System.Drawing.Point(-6, 229);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(235, 57);
            this.ManageButton.TabIndex = 11;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButtonImage
            // 
            this.ProfileButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfileButtonImage.Image = global::PassManager.Winforms.Properties.Resources.PassManagerProfile;
            this.ProfileButtonImage.Location = new System.Drawing.Point(26, 182);
            this.ProfileButtonImage.Name = "ProfileButtonImage";
            this.ProfileButtonImage.Size = new System.Drawing.Size(24, 29);
            this.ProfileButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileButtonImage.TabIndex = 10;
            this.ProfileButtonImage.TabStop = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Location = new System.Drawing.Point(-24, 166);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(253, 57);
            this.ProfileButton.TabIndex = 9;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // DashboardButtonImage
            // 
            this.DashboardButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DashboardButtonImage.Image = global::PassManager.Winforms.Properties.Resources.PassManagerLock;
            this.DashboardButtonImage.Location = new System.Drawing.Point(26, 115);
            this.DashboardButtonImage.Name = "DashboardButtonImage";
            this.DashboardButtonImage.Size = new System.Drawing.Size(24, 29);
            this.DashboardButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashboardButtonImage.TabIndex = 8;
            this.DashboardButtonImage.TabStop = false;
            // 
            // DashboardButton
            // 
            this.DashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(0, 103);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(258, 57);
            this.DashboardButton.TabIndex = 7;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            // 
            // Seperator
            // 
            this.Seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.Seperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seperator.Location = new System.Drawing.Point(-6, 85);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(235, 5);
            this.Seperator.TabIndex = 6;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.BackColor = System.Drawing.Color.Transparent;
            this.ProfileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileName.ForeColor = System.Drawing.Color.White;
            this.ProfileName.Location = new System.Drawing.Point(78, 34);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(105, 24);
            this.ProfileName.TabIndex = 5;
            this.ProfileName.Text = "Username";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.White;
            this.ProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(60, 60);
            this.ProfilePicture.TabIndex = 4;
            this.ProfilePicture.TabStop = false;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.DashboardPanel.Controls.Add(this.PasswordLabel);
            this.DashboardPanel.Controls.Add(this.PasswordTitleLabel);
            this.DashboardPanel.Controls.Add(this.UsernameLabel);
            this.DashboardPanel.Controls.Add(this.UsernameTitleLabel);
            this.DashboardPanel.Controls.Add(this.PasswordRevealButton);
            this.DashboardPanel.Controls.Add(this.PasswordThumbnail);
            this.DashboardPanel.Controls.Add(this.PasswordList);
            this.DashboardPanel.Controls.Add(this.filterMenu);
            this.DashboardPanel.Controls.Add(this.SearchBox);
            this.DashboardPanel.Location = new System.Drawing.Point(225, 0);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(559, 548);
            this.DashboardPanel.TabIndex = 15;
            // 
            // PasswordList
            // 
            this.PasswordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.PasswordList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordList.FormattingEnabled = true;
            this.PasswordList.HorizontalExtent = 265;
            this.PasswordList.HorizontalScrollbar = true;
            this.PasswordList.ItemHeight = 21;
            this.PasswordList.Items.AddRange(new object[] {
            "Password 1",
            "Password 2",
            "Password 3",
            "Password 4",
            "Password 5",
            "Password 6"});
            this.PasswordList.Location = new System.Drawing.Point(10, 43);
            this.PasswordList.Name = "PasswordList";
            this.PasswordList.Size = new System.Drawing.Size(303, 508);
            this.PasswordList.TabIndex = 3;
            this.PasswordList.SelectedIndexChanged += new System.EventHandler(this.PasswordList_SelectedIndexChanged);
            // 
            // filterMenu
            // 
            this.filterMenu.BackColor = System.Drawing.Color.White;
            this.filterMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterMenu.Items.AddRange(new object[] {
            "Alphabetical",
            "Date added",
            "With star"});
            this.filterMenu.Location = new System.Drawing.Point(162, 12);
            this.filterMenu.Name = "filterMenu";
            this.filterMenu.Size = new System.Drawing.Size(151, 25);
            this.filterMenu.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.Location = new System.Drawing.Point(10, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search...";
            this.SearchBox.Size = new System.Drawing.Size(146, 25);
            this.SearchBox.TabIndex = 1;
            // 
            // PasswordThumbnail
            // 
            this.PasswordThumbnail.BackColor = System.Drawing.Color.White;
            this.PasswordThumbnail.Location = new System.Drawing.Point(319, 43);
            this.PasswordThumbnail.Name = "PasswordThumbnail";
            this.PasswordThumbnail.Size = new System.Drawing.Size(226, 180);
            this.PasswordThumbnail.TabIndex = 4;
            this.PasswordThumbnail.TabStop = false;
            // 
            // PasswordRevealButton
            // 
            this.PasswordRevealButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordRevealButton.Location = new System.Drawing.Point(366, 475);
            this.PasswordRevealButton.Name = "PasswordRevealButton";
            this.PasswordRevealButton.Size = new System.Drawing.Size(147, 29);
            this.PasswordRevealButton.TabIndex = 5;
            this.PasswordRevealButton.Text = "Reveal Information";
            this.PasswordRevealButton.UseVisualStyleBackColor = true;
            // 
            // UsernameTitleLabel
            // 
            this.UsernameTitleLabel.AutoSize = true;
            this.UsernameTitleLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTitleLabel.Location = new System.Drawing.Point(319, 244);
            this.UsernameTitleLabel.Name = "UsernameTitleLabel";
            this.UsernameTitleLabel.Size = new System.Drawing.Size(97, 21);
            this.UsernameTitleLabel.TabIndex = 6;
            this.UsernameTitleLabel.Text = "Username:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(319, 265);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(152, 21);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "SampleUsername";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTitleLabel
            // 
            this.PasswordTitleLabel.AutoSize = true;
            this.PasswordTitleLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTitleLabel.Location = new System.Drawing.Point(319, 312);
            this.PasswordTitleLabel.Name = "PasswordTitleLabel";
            this.PasswordTitleLabel.Size = new System.Drawing.Size(94, 21);
            this.PasswordTitleLabel.TabIndex = 8;
            this.PasswordTitleLabel.Text = "Password:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(319, 333);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(101, 21);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "*************";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PMDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 548);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PMDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passmanager - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PMDashboard_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label VersionText;
        private Panel MainMenu;
        private PictureBox ProfilePicture;
        private Label ProfileName;
        private Label Seperator;
        private Button DashboardButton;
        private PictureBox DashboardButtonImage;
        private PictureBox ManageButtonImage;
        private Button ManageButton;
        private PictureBox ProfileButtonImage;
        private Button ProfileButton;
        private PictureBox pictureBox1;
        private Button OptionsButton;
        private Panel DashboardPanel;
        private TextBox SearchBox;
        private ComboBox filterMenu;
        private ListBox PasswordList;
        private Label PasswordLabel;
        private Label PasswordTitleLabel;
        private Label UsernameLabel;
        private Label UsernameTitleLabel;
        private Button PasswordRevealButton;
        private PictureBox PasswordThumbnail;
    }
}