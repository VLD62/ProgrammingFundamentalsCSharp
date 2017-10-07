namespace _03.Last_K_Numbers_Sums
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (long prev = i - k; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += arr[prev];
                arr[i] = sum;
            }
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
