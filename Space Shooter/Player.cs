using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Shooter
{
    public class player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        private DateTime lastShoot = DateTime.MinValue;
        private readonly int fireRaate = 200;
        public player()
        {
            Speed = 9;
            X = 100;
            Y = 100;
        }
        public void ResetPosition()
        {
            X = 900;
            Y = 800;
        }
        public void Move(int dX, int dY, int screenWidth, int screenHeight)
        {
            int newX = X + dX * Speed;
            int newY = Y + dY * Speed;
            X = Math.Max(0, Math.Min(newX, screenWidth - 50));
            Y = Math.Max(0, Math.Min(newY, screenHeight - 50));

        }
        public bool can_shoot()
        {
            if ((DateTime.Now - lastShoot).TotalMilliseconds >= fireRaate)
            {
                lastShoot = DateTime.Now;
                return true;

            }
            return false;
        }





    }
}
