

namespace _8.Center_Point
{
    using System;
    class Program
    {
        static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            var X1 = decimal.Parse(Console.ReadLine());
            var Y1 = decimal.Parse(Console.ReadLine());
            var X2 = decimal.Parse(Console.ReadLine());
            var Y2 = decimal.Parse(Console.ReadLine());

            decimal MINX = (GetMin(X1, X2));
            decimal MINY = (GetMin(Y1, Y2));

            Console.WriteLine("({0}, {1})", MINX, MINY);
            

        }
    }
}
