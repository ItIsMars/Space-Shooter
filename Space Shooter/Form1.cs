using Space_Shooter.Properties;
using System.Media;
using System.IO;


namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SoundPlayer menuMusic = new SoundPlayer("MainMenuThemeMusic.wav");
        public static bool IsMusicActive = true;
        public static bool IsSoundEffectsActive = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                menuMusic.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Main menu music not found " + ex.Message);
            }
        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // creating the about page
            AboutPage about = new AboutPage();

            //// ۲. هماهنگ کردن اندازه این صفحه با فرم اصلی بازی
            //about.Dock = DockStyle.Fill;

            // adding this form to the main form
            this.Controls.Add(about);

            // bringing it to the front so the main page is hidden
            about.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Create a new instance of your Settings UserControl
                SettingsPage settingsView = new SettingsPage();

                // 2. Set the exact starting position (Top-Left corner of the form)
                settingsView.Location = new Point(0, 0);

                // 3. Set the exact fixed size to match your 1920x1080 resolution
                settingsView.Size = new Size(1920, 1080);

                // 4. Add the settings control to the main form's control layer
                this.Controls.Add(settingsView);

                // 5. Bring it to the absolute front so it covers the main menu elements
                settingsView.BringToFront();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Failed to open Settings: " + ex.Message);
            }
        }
    }
}
