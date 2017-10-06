using System;
namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOfEven(int n)
        {
            int sum = 0;

            while (n > 0)
            {

                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += n % 10;
                }

                n /= 10;
            }

            return sum;

        }

        static int GetSumOfOdd(int n)
        {
            int sum = 0;

            while (n > 0)
            {

                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += n % 10;
                }

                n /= 10;
            }

            return sum;

        }

        static int GetSumOfOddEven(int n)
        {

            int sumOddEven = GetSumOfOdd(n) * GetSumOfEven(n);
            return sumOddEven;
        }

        static void Main(string[] args)
        {
            var N = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetSumOfOddEven(N));

        }
    }
}
