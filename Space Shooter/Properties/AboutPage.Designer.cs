namespace Space_Shooter.Properties
{
    partial class AboutPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            About = new Label();
            description = new Label();
            developers = new Label();
            dev1NameAndID = new Label();
            credits = new Label();
            menumusic = new Label();
            buttonAboutPageBack = new Button();
            dev2NameAndID = new Label();
            SuspendLayout();
            // 
            // About
            // 
            About.Anchor = AnchorStyles.Top;
            About.AutoSize = true;
            About.Font = new Font("Segoe UI", 30F);
            About.ForeColor = Color.FromArgb(128, 255, 255);
            About.Location = new Point(719, 54);
            About.Margin = new Padding(0);
            About.Name = "About";
            About.Size = new Size(398, 76);
            About.TabIndex = 1;
            About.Text = "About the game:";
            About.UseCompatibleTextRendering = true;
            About.Click += About_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 18F);
            description.ForeColor = Color.White;
            description.Location = new Point(584, 159);
            description.Name = "description";
            description.Size = new Size(603, 41);
            description.TabIndex = 2;
            description.Text = "This is just a final project for AP in university.";
            description.Click += description_Click;
            // 
            // developers
            // 
            developers.AutoSize = true;
            developers.Font = new Font("Segoe UI", 26F);
            developers.ForeColor = Color.FromArgb(128, 255, 255);
            developers.Location = new Point(807, 270);
            developers.Name = "developers";
            developers.Size = new Size(253, 60);
            developers.TabIndex = 3;
            developers.Text = "Developers:";
            // 
            // dev1NameAndID
            // 
            dev1NameAndID.AutoSize = true;
            dev1NameAndID.Font = new Font("Segoe UI", 18F);
            dev1NameAndID.ForeColor = Color.White;
            dev1NameAndID.Location = new Point(614, 364);
            dev1NameAndID.Name = "dev1NameAndID";
            dev1NameAndID.Size = new Size(617, 41);
            dev1NameAndID.TabIndex = 4;
            dev1NameAndID.Text = "Mohammad Merrikh - Student ID: 404522061";
            // 
            // credits
            // 
            credits.AutoSize = true;
            credits.Font = new Font("Segoe UI", 26F);
            credits.ForeColor = Color.FromArgb(128, 255, 255);
            credits.Location = new Point(858, 502);
            credits.Name = "credits";
            credits.Size = new Size(171, 60);
            credits.TabIndex = 5;
            credits.Text = "Credits:";
            credits.Click += credits_Click;
            // 
            // menumusic
            // 
            menumusic.AutoSize = true;
            menumusic.Font = new Font("Segoe UI", 18F);
            menumusic.ForeColor = Color.White;
            menumusic.Location = new Point(77, 590);
            menumusic.Name = "menumusic";
            menumusic.Size = new Size(1433, 41);
            menumusic.TabIndex = 6;
            menumusic.Text = "Main menu music: Title theme from the game \"Space Captain Yanya\" (Downloaded from opengameart.org)";
            menumusic.Click += label2_Click;
            // 
            // buttonAboutPageBack
            // 
            buttonAboutPageBack.FlatAppearance.BorderColor = Color.White;
            buttonAboutPageBack.FlatAppearance.BorderSize = 4;
            buttonAboutPageBack.FlatStyle = FlatStyle.Flat;
            buttonAboutPageBack.Image = Resources.AboutPageBackButton;
            buttonAboutPageBack.Location = new Point(30, 30);
            buttonAboutPageBack.Name = "buttonAboutPageBack";
            buttonAboutPageBack.Size = new Size(90, 90);
            buttonAboutPageBack.TabIndex = 7;
            buttonAboutPageBack.UseVisualStyleBackColor = true;
            buttonAboutPageBack.Click += buttonAboutPageBack_Click;
            // 
            // dev2NameAndID
            // 
            dev2NameAndID.AutoSize = true;
            dev2NameAndID.Font = new Font("Segoe UI", 18F);
            dev2NameAndID.ForeColor = Color.White;
            dev2NameAndID.Location = new Point(594, 415);
            dev2NameAndID.Name = "dev2NameAndID";
            dev2NameAndID.Size = new Size(625, 41);
            dev2NameAndID.TabIndex = 8;
            dev2NameAndID.Text = "Pandyar Abrishamifar - Student ID: 404400006";
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(dev2NameAndID);
            Controls.Add(buttonAboutPageBack);
            Controls.Add(menumusic);
            Controls.Add(credits);
            Controls.Add(dev1NameAndID);
            Controls.Add(developers);
            Controls.Add(description);
            Controls.Add(About);
            Name = "AboutPage";
            Size = new Size(1920, 1080);
            Load += AboutPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label About;
        private Label description;
        private Label developers;
        private Label dev1NameAndID;
        private Label credits;
        private Label menumusic;
        private Button buttonAboutPageBack;
        private Label dev2NameAndID;
    }
}
