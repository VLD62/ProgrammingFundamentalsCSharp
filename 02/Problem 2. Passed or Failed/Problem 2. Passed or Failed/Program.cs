namespace Problem_2.Passed_or_Failed
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var number = Double.Parse(Console.ReadLine());

            if (number >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else {
                Console.WriteLine("Failed!");
            }
        }
    }
}
