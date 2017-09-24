

namespace Problem_1.Passed
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var number = Double.Parse(Console.ReadLine());

            if (number >= 3.00) {
                Console.WriteLine("Passed!");
            }
        }
    }
}
