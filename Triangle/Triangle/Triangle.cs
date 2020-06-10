using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        Point firstVertex;
        Point secondVertex;
        Point thirdVertex;

        public Point FirstVertex { get => firstVertex; set => firstVertex = value; }
        public Point SecondVertex { get => secondVertex; set => secondVertex = value; }
        public Point ThirdVertex { get => thirdVertex; set => thirdVertex = value; }

        public Triangle(Point first, Point second, Point third)
        {
            if (Distance(first, second) + Distance(first, third) > Distance(second, third) &&
                (Distance(first, second) + Distance(second, third) > Distance(first, third)) && (Distance(first, third) + Distance(second, third) > Distance(first, second)))
            {
                FirstVertex = first;
                SecondVertex = second;
                ThirdVertex = third;
            }
            else
            {
                throw new Exception("This points can't make a triangle");
            }
            
        }
        private double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
        public double Perimeter()
        {
            return Distance(FirstVertex, SecondVertex) + Distance(FirstVertex, ThirdVertex) + Distance(SecondVertex, ThirdVertex);
        }
        public double Area()
        {
            return Math.Sqrt(Perimeter() / 2 * (Perimeter() / 2 - Distance(FirstVertex, SecondVertex)) * (Perimeter() / 2 - Distance(SecondVertex, ThirdVertex)) * 
                (Perimeter() / 2 - Distance(FirstVertex, ThirdVertex)));
        }
    }
}
