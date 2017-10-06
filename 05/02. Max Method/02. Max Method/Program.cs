using System;

namespace _02.Max_Method
{
    class Program
    {
        static int GetMax(int a, int b) {
            if (a >= b)
            {
                return a;
            }
            else {
                return b;
            }       

        }
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (GetMax(a, b) >= GetMax(a, c))
            {
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                Console.WriteLine(GetMax(a, c));
            }

        }
    }
}
