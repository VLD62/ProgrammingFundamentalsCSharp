namespace _13.Factorial
{
    using System;
    using System.Numerics;
    class Program
    {
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
            Console.Write(factorial_calculator(number));
        }
    }
}
