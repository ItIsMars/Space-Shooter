using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Shooter
{
    public class Bullet
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsActive { get; set; } = true;
        public int Damage { get; set; } = 1;
        public Bullet(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Rectangle Bounds => new Rectangle((int)X, (int)Y, Width, Height);
    }
}
