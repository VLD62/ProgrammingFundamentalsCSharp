namespace _2.Sign_of_Integer_Number
{
    using System;
    class Program
    {

        static void PrintSign(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("The number " + a + " is positive.");
            }
            else if (a == 0)
            {
                Console.WriteLine("The number " + a + " is zero.");
            }
            else
            {
                Console.WriteLine("The number " + a + " is negative.");
            }
        }

        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
    }
}
