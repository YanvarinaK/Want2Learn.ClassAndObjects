using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects.Shapes
{
    public class Point
    {
        public double XPosition { get; set; }
        public double YPosition { get; set; }

        public static Point operator +(Point one, Point two)
        {
            return new Point { XPosition = one.XPosition + two.XPosition, YPosition = one.YPosition + two.YPosition };
        }

        public static Point operator -(Point one, Point two)
        {
            return new Point { XPosition = one.XPosition - two.XPosition, YPosition = one.YPosition - two.YPosition };
        }

        public override string ToString()
        {
            return $"X = {XPosition}, Y = {YPosition}";
        }
    }
}
