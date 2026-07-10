using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Shooter
{
    public class Enemy
    {
        public int Y { get; set; }
        public int X { get;set; }
        public int Speed { get; set; }
        public int HP { get; set; } = 1;
        public int Width { get; set; } = 50;
        public int Height { get; set; } = 50;
        public Rectangle Bounds
        {
            get { return new Rectangle(X, Y, Width, Height);}
        }
        public Enemy(int startX,int startY)
        {
            X = startX;
            Y = startY;
        }
        public void Move()
        {
            Y += Speed;
        }
    }


}
