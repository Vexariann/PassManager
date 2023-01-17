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
            this.VersionText = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.DashboardButtonImage = new System.Windows.Forms.PictureBox();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.Seperator = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ProfileButtonImage = new System.Windows.Forms.PictureBox();
            this.ManageButton = new System.Windows.Forms.Button();
            this.ManageButtonImage = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageButtonImage)).BeginInit();
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
            // ProfileButton
            // 
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Location = new System.Drawing.Point(-24, 150);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(253, 57);
            this.ProfileButton.TabIndex = 9;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButtonImage
            // 
            this.ProfileButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfileButtonImage.Image = global::PassManager.Winforms.Properties.Resources.PassManagerProfile;
            this.ProfileButtonImage.Location = new System.Drawing.Point(26, 166);
            this.ProfileButtonImage.Name = "ProfileButtonImage";
            this.ProfileButtonImage.Size = new System.Drawing.Size(24, 29);
            this.ProfileButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileButtonImage.TabIndex = 10;
            this.ProfileButtonImage.TabStop = false;
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
            this.ManageButton.Location = new System.Drawing.Point(-6, 201);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(235, 57);
            this.ManageButton.TabIndex = 11;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            // 
            // ManageButtonImage
            // 
            this.ManageButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.ManageButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManageButtonImage.Image = global::PassManager.Winforms.Properties.Resources.PassManagerManage;
            this.ManageButtonImage.Location = new System.Drawing.Point(26, 213);
            this.ManageButtonImage.Name = "ManageButtonImage";
            this.ManageButtonImage.Size = new System.Drawing.Size(24, 29);
            this.ManageButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManageButtonImage.TabIndex = 12;
            this.ManageButtonImage.TabStop = false;
            // 
            // PMDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 548);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PMDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passmanager - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PMDashboard_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageButtonImage)).EndInit();
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
    }
}