using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(new Point(0, 0, 0), new Point(1, 1, 1), new Point(2, 2, 2));
                Console.WriteLine($"Периметр = {triangle.Perimeter()}, Площадь = {triangle.Area()}");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
