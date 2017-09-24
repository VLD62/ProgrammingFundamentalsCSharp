namespace Problem_11.Odd_Number
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());


            if (num % 2 != 0)
            {
                Console.WriteLine("The number is: " + Math.Abs(num));
            }
            else
            {
                while (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    num = int.Parse(Console.ReadLine());

                    if (num % 2 != 0)
                    {
                        Console.WriteLine("The number is: " + Math.Abs(num));
                    }
                }
            }

           }
    }
}
