namespace Space_Shooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMainMenu = new Panel();
            buttonExit = new Button();
            buttonShop = new Button();
            buttonAbout = new Button();
            buttonSettings = new Button();
            buttonPlay = new Button();
            pictureGameTitle = new PictureBox();
            panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGameTitle).BeginInit();
            SuspendLayout();
            // 
            // panelMainMenu
            // 
            panelMainMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelMainMenu.Controls.Add(buttonExit);
            panelMainMenu.Controls.Add(buttonShop);
            panelMainMenu.Controls.Add(buttonAbout);
            panelMainMenu.Controls.Add(buttonSettings);
            panelMainMenu.Controls.Add(buttonPlay);
            panelMainMenu.Controls.Add(pictureGameTitle);
            panelMainMenu.Dock = DockStyle.Fill;
            panelMainMenu.Location = new Point(0, 0);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(1902, 1033);
            panelMainMenu.TabIndex = 0;
            panelMainMenu.Paint += panelMainMenu_Paint;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.White;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 8;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = Properties.Resources.ExitButton;
            buttonExit.Location = new Point(138, 588);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(260, 260);
            buttonExit.TabIndex = 5;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonShop
            // 
            buttonShop.BackColor = Color.White;
            buttonShop.FlatAppearance.BorderColor = Color.White;
            buttonShop.FlatAppearance.BorderSize = 8;
            buttonShop.FlatStyle = FlatStyle.Flat;
            buttonShop.Image = Properties.Resources.ShopButton;
            buttonShop.Location = new Point(419, 588);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(260, 260);
            buttonShop.TabIndex = 4;
            buttonShop.UseVisualStyleBackColor = false;
            buttonShop.Click += button3_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.White;
            buttonAbout.FlatAppearance.BorderColor = Color.White;
            buttonAbout.FlatAppearance.BorderSize = 8;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Image = Properties.Resources.AboutButton;
            buttonAbout.Location = new Point(1499, 588);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(260, 260);
            buttonAbout.TabIndex = 3;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.White;
            buttonSettings.FlatAppearance.BorderColor = Color.White;
            buttonSettings.FlatAppearance.BorderSize = 8;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Image = Properties.Resources.SettingsButton1;
            buttonSettings.Location = new Point(1219, 588);
            buttonSettings.Margin = new Padding(0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(260, 260);
            buttonSettings.TabIndex = 2;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.White;
            buttonPlay.FlatAppearance.BorderColor = Color.White;
            buttonPlay.FlatAppearance.BorderSize = 8;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.ForeColor = Color.White;
            buttonPlay.Image = Properties.Resources.PlayButton1;
            buttonPlay.Location = new Point(698, 588);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(500, 260);
            buttonPlay.TabIndex = 1;
            buttonPlay.UseVisualStyleBackColor = false;
            // 
            // pictureGameTitle
            // 
            pictureGameTitle.Image = Properties.Resources.GameTitle1;
            pictureGameTitle.Location = new Point(312, 49);
            pictureGameTitle.Name = "pictureGameTitle";
            pictureGameTitle.Size = new Size(1280, 480);
            pictureGameTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pictureGameTitle.TabIndex = 0;
            pictureGameTitle.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelMainMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureGameTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainMenu;
        private PictureBox pictureGameTitle;
        private Button buttonPlay;
        private Button buttonAbout;
        private Button buttonSettings;
        private Button buttonExit;
        private Button buttonShop;
    }
}
