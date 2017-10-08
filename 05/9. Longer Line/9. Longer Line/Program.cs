using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static string GetFarestPoints(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Sqrt((X1 * X1) + (Y1 * Y1)) >= Math.Sqrt((X2 * X2) + (Y2 * Y2)))
            {
                return (X1 + ", " + Y1);
            }
            else
            {
                return (X2 + ", " + Y2);
            }
        }

        static string GetClosestPoints(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Sqrt((X1 * X1) + (Y1 * Y1)) <= Math.Sqrt((X2 * X2) + (Y2 * Y2)))
            {
                 return (X1 + ", " + Y1);
            }

            else
            {
                return (X2 + ", " + Y2);
            }

          
        }
        static void Main(string[] args)
        {
            var X1 = double.Parse(Console.ReadLine());
            var Y1 = double.Parse(Console.ReadLine());
            var X2 = double.Parse(Console.ReadLine());
            var Y2 = double.Parse(Console.ReadLine());
            var X3 = double.Parse(Console.ReadLine());
            var Y3 = double.Parse(Console.ReadLine());
            var X4 = double.Parse(Console.ReadLine());
            var Y4 = double.Parse(Console.ReadLine());

            

           double [] points1 = (GetFarestPoints(X1, Y1, X3, Y3)).Split(',').Select(double.Parse).ToArray();
           double [] points2 = (GetFarestPoints(X2, Y2, X4, Y4)).Split(',').Select(double.Parse).ToArray();

    
            Console.WriteLine("("+GetClosestPoints(points1[0], points1[1], points2[0], points2[1])+")("+
                GetFarestPoints(points1[0], points1[1], points2[0],points2[1]) +")");
        



        }
    }
}
