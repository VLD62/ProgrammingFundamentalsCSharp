

namespace _16.Comparing_floats
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            if (Math.Abs(a - b) >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else {
                Console.WriteLine("True");
            }
        }
    }
}
