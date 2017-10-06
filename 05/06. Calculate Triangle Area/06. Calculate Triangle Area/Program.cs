namespace _6.Calculate_Triangle_Area
{
    using System;
    class Program
    {

        static double getTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(getTriangleArea(width, height));


        }
    }
}
