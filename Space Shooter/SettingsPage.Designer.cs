namespace Space_Shooter
{
    partial class SettingsPage
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
            SettingsTitle = new Label();
            buttonSettingsBack = new Button();
            AudioSettingsLabel = new Label();
            buttonToggleMusic = new Button();
            buttonToggleSoundEffects = new Button();
            ControlsGuideLabel = new Label();
            ControlsGuide = new Label();
            SuspendLayout();
            // 
            // SettingsTitle
            // 
            SettingsTitle.AutoSize = true;
            SettingsTitle.Font = new Font("Segoe UI", 30F);
            SettingsTitle.ForeColor = Color.FromArgb(128, 255, 255);
            SettingsTitle.Location = new Point(796, 72);
            SettingsTitle.Name = "SettingsTitle";
            SettingsTitle.Size = new Size(200, 76);
            SettingsTitle.TabIndex = 0;
            SettingsTitle.Text = "Settings";
            SettingsTitle.UseCompatibleTextRendering = true;
            // 
            // buttonSettingsBack
            // 
            buttonSettingsBack.FlatAppearance.BorderColor = Color.White;
            buttonSettingsBack.FlatAppearance.BorderSize = 4;
            buttonSettingsBack.FlatStyle = FlatStyle.Flat;
            buttonSettingsBack.Image = Properties.Resources.AboutPageBackButton;
            buttonSettingsBack.Location = new Point(30, 30);
            buttonSettingsBack.Name = "buttonSettingsBack";
            buttonSettingsBack.Size = new Size(90, 90);
            buttonSettingsBack.TabIndex = 1;
            buttonSettingsBack.UseVisualStyleBackColor = true;
            buttonSettingsBack.Click += buttonSettingsBack_Click;
            // 
            // AudioSettingsLabel
            // 
            AudioSettingsLabel.AutoSize = true;
            AudioSettingsLabel.Font = new Font("Segoe UI", 26F);
            AudioSettingsLabel.ForeColor = Color.FromArgb(128, 255, 255);
            AudioSettingsLabel.Location = new Point(637, 288);
            AudioSettingsLabel.Name = "AudioSettingsLabel";
            AudioSettingsLabel.Size = new Size(151, 60);
            AudioSettingsLabel.TabIndex = 2;
            AudioSettingsLabel.Text = "Audio:";
            // 
            // buttonToggleMusic
            // 
            buttonToggleMusic.FlatAppearance.BorderColor = Color.White;
            buttonToggleMusic.FlatAppearance.BorderSize = 4;
            buttonToggleMusic.FlatStyle = FlatStyle.Flat;
            buttonToggleMusic.Image = Properties.Resources.MusicButton_Enabled;
            buttonToggleMusic.Location = new Point(1136, 254);
            buttonToggleMusic.Name = "buttonToggleMusic";
            buttonToggleMusic.Size = new Size(150, 150);
            buttonToggleMusic.TabIndex = 3;
            buttonToggleMusic.UseVisualStyleBackColor = true;
            buttonToggleMusic.Click += buttonToggleMusic_Click;
            // 
            // buttonToggleSoundEffects
            // 
            buttonToggleSoundEffects.FlatAppearance.BorderColor = Color.White;
            buttonToggleSoundEffects.FlatAppearance.BorderSize = 4;
            buttonToggleSoundEffects.FlatStyle = FlatStyle.Flat;
            buttonToggleSoundEffects.Image = Properties.Resources.SoundEffectsButton_Enabled;
            buttonToggleSoundEffects.Location = new Point(947, 254);
            buttonToggleSoundEffects.Name = "buttonToggleSoundEffects";
            buttonToggleSoundEffects.Size = new Size(150, 150);
            buttonToggleSoundEffects.TabIndex = 4;
            buttonToggleSoundEffects.UseVisualStyleBackColor = true;
            buttonToggleSoundEffects.Click += buttonToggleSoundEffects_Click;
            // 
            // ControlsGuideLabel
            // 
            ControlsGuideLabel.AutoSize = true;
            ControlsGuideLabel.Font = new Font("Segoe UI", 26F);
            ControlsGuideLabel.ForeColor = Color.FromArgb(128, 255, 255);
            ControlsGuideLabel.Location = new Point(721, 472);
            ControlsGuideLabel.Name = "ControlsGuideLabel";
            ControlsGuideLabel.Size = new Size(326, 60);
            ControlsGuideLabel.TabIndex = 5;
            ControlsGuideLabel.Text = "Controls Guide:";
            // 
            // ControlsGuide
            // 
            ControlsGuide.AutoSize = true;
            ControlsGuide.Font = new Font("Segoe UI", 18F);
            ControlsGuide.ForeColor = Color.White;
            ControlsGuide.Location = new Point(767, 596);
            ControlsGuide.Name = "ControlsGuide";
            ControlsGuide.Size = new Size(339, 328);
            ControlsGuide.TabIndex = 6;
            ControlsGuide.Text = "Move ship up:          W\r\nMove ship left:         A\r\nMove ship down:      S\r\nMove ship right:       D\r\n\r\nShoot:                   SPACE\r\n\r\nPause:                    ESC";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(ControlsGuide);
            Controls.Add(ControlsGuideLabel);
            Controls.Add(buttonToggleSoundEffects);
            Controls.Add(buttonToggleMusic);
            Controls.Add(AudioSettingsLabel);
            Controls.Add(buttonSettingsBack);
            Controls.Add(SettingsTitle);
            Name = "SettingsPage";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsTitle;
        private Button buttonSettingsBack;
        private Label AudioSettingsLabel;
        private Button buttonToggleMusic;
        private Button buttonToggleSoundEffects;
        private Label ControlsGuideLabel;
        private Label ControlsGuide;
    }
}
