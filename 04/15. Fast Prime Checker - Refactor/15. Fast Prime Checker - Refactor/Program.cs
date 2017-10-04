namespace _15.Fast_Prime_Checker___Refactor
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var N = int.Parse(Console.ReadLine());
            for (int i = 2; i <= N; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
