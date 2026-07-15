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
            panelMainMenu.BackColor = Color.Black;
            panelMainMenu.Controls.Add(buttonExit);
            panelMainMenu.Controls.Add(buttonShop);
            panelMainMenu.Controls.Add(buttonAbout);
            panelMainMenu.Controls.Add(buttonSettings);
            panelMainMenu.Controls.Add(buttonPlay);
            panelMainMenu.Controls.Add(pictureGameTitle);
            panelMainMenu.Dock = DockStyle.Fill;
            panelMainMenu.Location = new Point(0, 0);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(1539, 840);
            panelMainMenu.TabIndex = 0;
            panelMainMenu.Paint += panelMainMenu_Paint;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = Color.White;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 8;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = Properties.Resources.ExitButton;
            buttonExit.Location = new Point(255, 446);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(203, 195);
            buttonExit.TabIndex = 5;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonShop
            // 
            buttonShop.Anchor = AnchorStyles.None;
            buttonShop.BackColor = Color.White;
            buttonShop.FlatAppearance.BorderColor = Color.White;
            buttonShop.FlatAppearance.BorderSize = 8;
            buttonShop.FlatStyle = FlatStyle.Flat;
            buttonShop.Image = Properties.Resources.ShopButton;
            buttonShop.Location = new Point(457, 446);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(186, 195);
            buttonShop.TabIndex = 4;
            buttonShop.UseVisualStyleBackColor = false;
            buttonShop.Click += button3_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.None;
            buttonAbout.BackColor = Color.White;
            buttonAbout.FlatAppearance.BorderColor = Color.White;
            buttonAbout.FlatAppearance.BorderSize = 8;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Image = Properties.Resources.AboutButton;
            buttonAbout.Location = new Point(1103, 446);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(178, 195);
            buttonAbout.TabIndex = 3;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.None;
            buttonSettings.BackColor = Color.White;
            buttonSettings.FlatAppearance.BorderColor = Color.White;
            buttonSettings.FlatAppearance.BorderSize = 8;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Image = Properties.Resources.SettingsButton1;
            buttonSettings.Location = new Point(935, 446);
            buttonSettings.Margin = new Padding(0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(173, 195);
            buttonSettings.TabIndex = 2;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Anchor = AnchorStyles.None;
            buttonPlay.BackColor = Color.White;
            buttonPlay.FlatAppearance.BorderColor = Color.White;
            buttonPlay.FlatAppearance.BorderSize = 8;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.ForeColor = Color.White;
            buttonPlay.Image = Properties.Resources.PlayButton1;
            buttonPlay.Location = new Point(631, 446);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(314, 195);
            buttonPlay.TabIndex = 1;
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // pictureGameTitle
            // 
            pictureGameTitle.Image = Properties.Resources.GameTitle1;
            pictureGameTitle.Location = new Point(400, 63);
            pictureGameTitle.Name = "pictureGameTitle";
            pictureGameTitle.Size = new Size(1139, 377);
            pictureGameTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pictureGameTitle.TabIndex = 0;
            pictureGameTitle.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 840);
            Controls.Add(panelMainMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown_1;
            KeyUp += Form1_KeyUp_1;
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
