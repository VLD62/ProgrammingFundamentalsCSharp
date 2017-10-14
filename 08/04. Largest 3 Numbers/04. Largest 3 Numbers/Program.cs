namespace _04.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
           List<double> result = numbers.OrderByDescending(x => x).Take(3).ToList();
           Console.WriteLine(string.Join(" ", result));
        }
    }
}
