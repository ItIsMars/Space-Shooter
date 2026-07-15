using Space_Shooter.Properties;
using System.Media;
using System.IO;


namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        private GameEngine engine;
        private System.Windows.Forms.Timer renderTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            renderTimer.Interval = 20;
            renderTimer.Tick += (s, e) => { this.Invalidate(); };
            renderTimer.Start();


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


        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (engine == null) return;
        //    if (e.KeyCode == Keys.Left) engine.IsMovingLeft = true;
        //    if (e.KeyCode == Keys.Right) engine.IsMovingRight = true;
        //    if (e.KeyCode == Keys.Down) engine.IsMovingDown = true;
        //    if (e.KeyCode == Keys.Up) engine.IsMovingUp = true;
        //}
        //private void Form1_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (engine == null) return;
        //    if (e.KeyCode == Keys.Left) engine.IsMovingLeft = false;
        //    if (e.KeyCode == Keys.Right) engine.IsMovingRight = false;
        //    if (e.KeyCode == Keys.Down) engine.IsMovingDown = false;
        //    if (e.KeyCode == Keys.Up) engine.IsMovingUp = false;

        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (engine != null)
            {
                this.BackColor = Color.FromArgb(0, 0, 30); 

                Image shipImage = Properties.Resources.ShipImage;

                e.Graphics.DrawImage(shipImage, engine.Player.X, engine.Player.Y, 65, 65);
            }
            e.Graphics.DrawString("Score: " + engine.Score, this.Font, Brushes.White, 10, 10);
            foreach(var coin in engine.coins)
            {
                e.Graphics.FillEllipse(Brushes.Gold, coin.X, coin.Y, 20, 20);
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
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelMainMenu.Hide();
            engine = new GameEngine(this.ClientSize.Width, this.ClientSize.Height);
            engine.Start();
            this.Focus();
            this.KeyPreview = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // creating the about page
            AboutPage about = new AboutPage();
            about.Dock = DockStyle.Fill;
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

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (engine == null) return;
            if (e.KeyCode == Keys.Left) engine.IsMovingLeft = true;
            if (e.KeyCode == Keys.Right) engine.IsMovingRight = true;
            if (e.KeyCode == Keys.Down) engine.IsMovingDown = true;
            if (e.KeyCode == Keys.Up) engine.IsMovingUp = true;
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (engine == null) return;
            if (e.KeyCode == Keys.Left) engine.IsMovingLeft = false;
            if (e.KeyCode == Keys.Right) engine.IsMovingRight = false;
            if (e.KeyCode == Keys.Down) engine.IsMovingDown = false;
            if (e.KeyCode == Keys.Up) engine.IsMovingUp = false;
        }
    }
}
