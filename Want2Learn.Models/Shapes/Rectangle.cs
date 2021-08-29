using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Models.Shapes
{
    public class Rectangle : Shape
    {
        public Point LeftTopPoint { get; set; }
        public Point RightLowerPoint { get; set; }

        public double Height
        {
            get
            {
                double height = Math.Abs((LeftTopPoint - RightLowerPoint).YPosition);
                return height;
            }
        }

        public double Width
        {
            get
            {
                double wight = Math.Abs((RightLowerPoint - LeftTopPoint).XPosition);
                return wight;
            }
        }

        public override double GetPerimeter()
        {
            return Height * 2 + Width * 2;
        }

        public override double GetSquare()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Perimeter = {GetPerimeter()}, Square = {GetSquare()}";
        }

        public Rectangle()
        {
            LeftTopPoint = new Point();
            RightLowerPoint = new Point();
        }
    }
}
