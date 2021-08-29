using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Models.Shapes
{
    public class Square : Shape
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }

        public double Edge
        {
            get
            {
                double edge = Math.Abs((FirstPoint - SecondPoint).YPosition);
                return edge;
            }
        }

    
        public override double GetPerimeter()
        {
            return Edge * 4;
        }

        public override double GetSquare()
        {
            return Math.Pow(Edge, 2);
        }

        public override string ToString()
        {
            return $"Perimeter = {GetPerimeter()}, Square = {GetSquare()}";
        }

        public Square()
        {
            FirstPoint = new Point();
            SecondPoint = new Point();
        }
    }
}
