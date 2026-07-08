using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Space_Shooter.Properties
{
    public partial class AboutPage : UserControl
    {
        // Global collection holding both loaded fonts
        private PrivateFontCollection modernFonts = new PrivateFontCollection();

        public AboutPage()
        {
            InitializeComponent();

            // Load both font files into the memory collection
            LoadPixelFontFromMemory();

            // Apply them to respective labels
            ApplyPixelFontToLabels();
        }

        private void LoadPixelFontFromMemory()
        {
            // Array containing the exact resource paths for both files
            string[] resourceNames = {
                "Space_Shooter.PixeloidSans.ttf",
                "Space_Shooter.PixeloidSans-Bold.ttf"
            };

            foreach (string resourceName in resourceNames)
            {
                try
                {
                    using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                    {
                        if (stream == null)
                        {
                            System.Diagnostics.Debug.WriteLine($"Resource not found: {resourceName}");
                            continue;
                        }

                        byte[] fontData = new byte[stream.Length];
                        stream.Read(fontData, 0, (int)stream.Length);

                        IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                        Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                        // Adding each font data to the shared collection
                        modernFonts.AddMemoryFont(fontPtr, fontData.Length);
                        Marshal.FreeCoTaskMem(fontPtr);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Loading font failed for {resourceName}: " + ex.Message);
                }
            }
        }

        private void ApplyPixelFontToLabels()
        {
            try
            {
                // Check if at least one font family was loaded successfully
                if (modernFonts.Families.Length > 0)
                {
                    // Both regular and bold weights reside inside the same family index [0]
                    // Windows Forms automatically picks the correct file based on FontStyle
                    Font pixelFontRegular = new Font(modernFonts.Families[0], 18, FontStyle.Regular);
                    Font pixelFontBold30 = new Font(modernFonts.Families[0], 30, FontStyle.Bold);
                    Font pixelFontBold26 = new Font(modernFonts.Families[0], 26, FontStyle.Bold);

                    // Assigning fonts to your labels safely
                    About.Font = pixelFontBold30;
                    description.Font = pixelFontRegular;
                    developers.Font = pixelFontBold26;
                    dev1NameAndID.Font = pixelFontRegular;
                    dev2NameAndID.Font = pixelFontRegular;
                    credits.Font = pixelFontBold26;
                    menumusic.Font = pixelFontRegular;

                    // Force the control to redraw text with proper custom font rendering
                    About.UseCompatibleTextRendering = true;
                    description.UseCompatibleTextRendering = true;
                    developers.UseCompatibleTextRendering = true;
                    dev1NameAndID.UseCompatibleTextRendering = true;
                    dev2NameAndID.UseCompatibleTextRendering = true;
                    credits.UseCompatibleTextRendering = true;
                    menumusic.UseCompatibleTextRendering = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Applying font failed: " + ex.Message);
            }
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void credits_Click(object sender, EventArgs e)
        {

        }

        private void buttonAboutPageBack_Click(object sender, EventArgs e)
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
    }
}