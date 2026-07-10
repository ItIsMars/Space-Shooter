using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;


namespace Space_Shooter
{
    public class GameEngine
    {
        public List<Enemy> enemies = new List<Enemy>();
        public List<Bullet> bullets = new List<Bullet>();
        public List<Coin> coins = new List<Coin>();
        public int Score = 0;
        public player Player { get; set; }
        private System.Windows.Forms.Timer gameTimer;
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }


        public GameEngine(int screenWidth,int screenHeight)
        {
            Player = new player { X = screenWidth / 2 -25, Y = screenHeight-150 };
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
        }

        public void Start()
        {
            gameTimer.Start();
        }
        private void GameLoop(object sender,EventArgs e)
        {
            int dx = 0;
            int dy= 0;
            if (IsMovingLeft) dx = -1;
            if (IsMovingRight) dx = 1;
            if (IsMovingUp) dy = -1;
            if (IsMovingDown) dy = 1;
            CheckCollisions();
            foreach(var b in bullets)
            {
                b.Y -= 10;
                if(b.Y<0)
                {
                    b.IsActive = false;
                }
            }
            bullets.RemoveAll(b => !b.IsActive);

            Player.Move(dx, dy, 1920, 1080);
           
        }
        private void CheckCollisions()
        {
            foreach(var b in bullets.ToList())
            {
                foreach(var e in enemies.ToList())
                {
                    if (b.Bounds.IntersectsWith(e.Bounds))
                    {
                        e.HP -= 1;
                        b.IsActive = false;
                        if(e.HP <= 0)
                        {
                            enemies.Remove(e);
                            Score += 100;
                            TryDropCoin(e.X, e.Y);
                        }
                    }
                }
            }
        }
        private void TryDropCoin(float x ,float y)
        {
            Random rand = new Random();
            if(rand.Next(0,100)<30)
            {
                coins.Add(new Coin(x, y,1));
            }
        }



    }
}
