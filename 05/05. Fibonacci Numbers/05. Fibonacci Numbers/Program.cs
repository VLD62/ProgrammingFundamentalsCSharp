namespace _05.Fibonacci_Numbers
{
    using System;
    class Program
    {
        static int GetFibonacci(int num)
        {
            int f0 = 1;
            int f1 = 1;

            for (int i = 0; i < (num - 1); i++)
            {
                int fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            return f1;
        }

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(num));

        }
    }
}
