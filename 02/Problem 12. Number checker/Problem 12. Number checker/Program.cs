namespace Problem_12.Number_checker
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
