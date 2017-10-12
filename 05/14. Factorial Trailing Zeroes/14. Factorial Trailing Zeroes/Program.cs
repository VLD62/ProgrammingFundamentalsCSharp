namespace _14.Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;
    class Program
    {
        static int trailing_zeroes_counter(BigInteger number)
        {
            int counter = 0;
            while (number % 10 == 0)
            {
                counter++;
                number /= 10;
            }
            return counter;
        }
        static BigInteger factorial_calculator(int number)
        {
            BigInteger factioral = 1;
            while (number != 1)
            {
                factioral = factioral * number;
                number = number - 1;
            }
            return factioral;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write(trailing_zeroes_counter(factorial_calculator(number)));
        }
    }
}
