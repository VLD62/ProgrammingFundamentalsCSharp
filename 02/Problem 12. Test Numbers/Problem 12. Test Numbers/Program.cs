namespace Problem_12.Test_Numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;
            for (int i = n; i >= 1; i--)
            {

                for (int j = 1; j <= m; j++)
                {
                    if (sum <= maxSum)
                    {
                        sum = sum + (i * j * 3);
                    }
                    else
                    {
                        break;
                    }
                    combinations++;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
