using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Shooter
{ 
    public class Coin
    {
        public float X {  get; set; }
        public float Y { get; set; }
        public int Value { get; set; }
        public Coin(float x,float y,int value)
        {
            X = x;
            Y = y;
            Value = value;
        }
        public Rectangle Bounds => new Rectangle((int)X, (int)Y, 20, 20);
    }
}
