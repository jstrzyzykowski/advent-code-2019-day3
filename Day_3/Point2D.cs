using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point2D(float fromOutX, float fromOutY)
        {
            this.X = fromOutX;
            this.Y = fromOutY;
        }

    }
}
