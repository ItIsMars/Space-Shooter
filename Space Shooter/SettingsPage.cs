using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Space_Shooter
{
    public partial class SettingsPage : UserControl
    {
        private bool isMusicPlaying = true;
        private bool isSoundEffectsPlaying = true;

        private PrivateFontCollection modernFonts = new PrivateFontCollection();

        public SettingsPage()
        {
            InitializeComponent();
            LoadPixelFontFromMemory();
            ApplyPixelFontToLabels();

            if (Form1.IsMusicActive)
            {
                buttonToggleMusic.Image = Properties.Resources.MusicButton_Enabled;
                isMusicPlaying = true; // Local sync
            }
            else
            {
                buttonToggleMusic.Image = Properties.Resources.MusicButton_Disabled;
                isMusicPlaying = false; // Local sync
            }

            if (Form1.IsSoundEffectsActive)
            {
                buttonToggleSoundEffects.Image = Properties.Resources.SoundEffectsButton_Enabled;
                isSoundEffectsPlaying = true; // Local sync
            }
            else
            {
                buttonToggleSoundEffects.Image = Properties.Resources.SoundEffectsButton_Disabled;
                isSoundEffectsPlaying = false; // Local sync
            }
        }


        private void LoadPixelFontFromMemory()
        {
            try
            {
                string resourceName = "Space_Shooter.PixeloidSans.ttf";
                using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream == null) return;
                    byte[] fontData = new byte[stream.Length];
                    stream.Read(fontData, 0, (int)stream.Length);
                    IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                    modernFonts.AddMemoryFont(fontPtr, fontData.Length);
                    Marshal.FreeCoTaskMem(fontPtr);
                }
            }
            catch { }
        }

        private void ApplyPixelFontToLabels()
        {
            try
            {
                if (modernFonts.Families.Length > 0)
                {
                    Font pixelFontBold40 = new Font(modernFonts.Families[0], 40, FontStyle.Bold);
                    Font pixelFontBold32 = new Font(modernFonts.Families[0], 32, FontStyle.Bold);
                    Font pixelFontRegular = new Font(modernFonts.Families[0], 18, FontStyle.Regular);

                    SettingsTitle.Font = pixelFontBold40;
                    SettingsTitle.UseCompatibleTextRendering = true;
                    AudioSettingsLabel.Font = pixelFontBold32;
                    AudioSettingsLabel.UseCompatibleTextRendering = true;
                    ControlsGuideLabel.Font = pixelFontBold32;
                    ControlsGuideLabel.UseCompatibleTextRendering = true;
                    ControlsGuide.Font = pixelFontRegular;
                    ControlsGuide.UseCompatibleTextRendering = true;
                }
            }
            catch { }
        }

        private void buttonSettingsBack_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if this UserControl is currently hosted inside a parent Form/Panel
                if (this.Parent != null)
                {
                    // Remove this AboutPage from the parent's control collection
                    this.Parent.Controls.Remove(this);

                    // Optional: Safely dispose the resources of this page to free up memory
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Navigation back failed: " + ex.Message);
            }
        }

        private void buttonToggleMusic_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMusicPlaying)
                {
                    Form1.menuMusic.Stop();
                    buttonToggleMusic.Image = Properties.Resources.MusicButton_Disabled;

                    isMusicPlaying = false;
                    Form1.IsMusicActive = false; // Sync with global state
                }
                else
                {
                    Form1.menuMusic.PlayLooping();
                    buttonToggleMusic.Image = Properties.Resources.MusicButton_Enabled;

                    isMusicPlaying = true;
                    Form1.IsMusicActive = true; // Sync with global state
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Music toggle failed: " + ex.Message);
            }
        }

        private void buttonToggleSoundEffects_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSoundEffectsPlaying)
                {
                    //Form1.menuMusic.Stop();
                    buttonToggleSoundEffects.Image = Properties.Resources.SoundEffectsButton_Disabled;

                    isSoundEffectsPlaying = false;
                    Form1.IsSoundEffectsActive = false; // Sync with global state
                }
                else
                {
                    //Form1.menuMusic.PlayLooping();
                    buttonToggleSoundEffects.Image = Properties.Resources.SoundEffectsButton_Enabled;

                    isSoundEffectsPlaying = true;
                    Form1.IsSoundEffectsActive = true; // Sync with global state
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Music toggle failed: " + ex.Message);
            }
        }
    }
}