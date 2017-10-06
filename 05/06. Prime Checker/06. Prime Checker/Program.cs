namespace _06.Prime_Checker
{
    using System;
    class Program
    {
        static bool PrimeChecker (long num)  {
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            }
            return isPrime;

        }
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeChecker(num));
        }
    }
}
