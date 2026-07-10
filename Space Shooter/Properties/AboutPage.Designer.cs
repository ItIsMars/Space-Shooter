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
            About.Location = new Point(798, 59);
            About.Margin = new Padding(0);
            About.Name = "About";
            About.Size = new Size(478, 91);
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
            description.Location = new Point(581, 173);
            description.Margin = new Padding(4, 0, 4, 0);
            description.Name = "description";
            description.Size = new Size(726, 48);
            description.TabIndex = 2;
            description.Text = "This is just a final project for AP in university.";
            description.Click += description_Click;
            // 
            // developers
            // 
            developers.AutoSize = true;
            developers.Font = new Font("Segoe UI", 26F);
            developers.ForeColor = Color.FromArgb(128, 255, 255);
            developers.Location = new Point(822, 250);
            developers.Margin = new Padding(4, 0, 4, 0);
            developers.Name = "developers";
            developers.Size = new Size(297, 70);
            developers.TabIndex = 3;
            developers.Text = "Developers:";
            // 
            // dev1NameAndID
            // 
            dev1NameAndID.AutoSize = true;
            dev1NameAndID.Font = new Font("Segoe UI", 18F);
            dev1NameAndID.ForeColor = Color.White;
            dev1NameAndID.Location = new Point(599, 350);
            dev1NameAndID.Margin = new Padding(4, 0, 4, 0);
            dev1NameAndID.Name = "dev1NameAndID";
            dev1NameAndID.Size = new Size(736, 48);
            dev1NameAndID.TabIndex = 4;
            dev1NameAndID.Text = "Mohammad Merrikh - Student ID: 404522061";
            // 
            // credits
            // 
            credits.AutoSize = true;
            credits.Font = new Font("Segoe UI", 26F);
            credits.ForeColor = Color.FromArgb(128, 255, 255);
            credits.Location = new Point(939, 495);
            credits.Margin = new Padding(4, 0, 4, 0);
            credits.Name = "credits";
            credits.Size = new Size(202, 70);
            credits.TabIndex = 5;
            credits.Text = "Credits:";
            credits.Click += credits_Click;
            // 
            // menumusic
            // 
            menumusic.AutoSize = true;
            menumusic.Font = new Font("Segoe UI", 18F);
            menumusic.ForeColor = Color.White;
            menumusic.Location = new Point(48, 590);
            menumusic.Margin = new Padding(4, 0, 4, 0);
            menumusic.Name = "menumusic";
            menumusic.Size = new Size(1711, 48);
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
            buttonAboutPageBack.Location = new Point(38, 38);
            buttonAboutPageBack.Margin = new Padding(4);
            buttonAboutPageBack.Name = "buttonAboutPageBack";
            buttonAboutPageBack.Size = new Size(112, 112);
            buttonAboutPageBack.TabIndex = 7;
            buttonAboutPageBack.UseVisualStyleBackColor = true;
            buttonAboutPageBack.Click += buttonAboutPageBack_Click;
            // 
            // dev2NameAndID
            // 
            dev2NameAndID.AutoSize = true;
            dev2NameAndID.Font = new Font("Segoe UI", 18F);
            dev2NameAndID.ForeColor = Color.White;
            dev2NameAndID.Location = new Point(599, 411);
            dev2NameAndID.Margin = new Padding(4, 0, 4, 0);
            dev2NameAndID.Name = "dev2NameAndID";
            dev2NameAndID.Size = new Size(747, 48);
            dev2NameAndID.TabIndex = 8;
            dev2NameAndID.Text = "Pandyar Abrishamifar - Student ID: 404400006";
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4);
            Name = "AboutPage";
            Size = new Size(2400, 1350);
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
