using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string figure = Console.ReadLine();
            double area = 0;
            switch (figure)
            {

                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = (side * height)/2;
                    break;

                case "square":
                    double side2 = double.Parse(Console.ReadLine());
                    area = side2 * side2;
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height2 = double.Parse(Console.ReadLine());
                    area = (width * height2);
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = (radius * radius) * Math.PI;
                    break;

            }
            Console.WriteLine("{0:0.00}", Math.Round(area, 2));
        }
    }
}
