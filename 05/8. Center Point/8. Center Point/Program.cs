namespace _8.Center_Point
{
    using System;
    class Program
    {
        static void GetClosestPoints(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Sqrt((X1 * X1) + (Y1 * Y1)) < Math.Sqrt((X2 * X2) + (Y2 * Y2))) { 
                Console.WriteLine("({0}, {1})",X1, Y1);
            }

            else { 
                Console.WriteLine("({0}, {1})", X2, Y2);
            }
        }
        static void Main(string[] args)
        {
            var X1 = double.Parse(Console.ReadLine());
            var Y1 = double.Parse(Console.ReadLine());
            var X2 = double.Parse(Console.ReadLine());
            var Y2 = double.Parse(Console.ReadLine());

            GetClosestPoints(X1, Y1, X2, Y2);
        }
    }
}
