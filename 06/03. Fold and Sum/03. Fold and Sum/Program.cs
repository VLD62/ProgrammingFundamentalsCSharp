namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int half = arr.Length / 2;
            int part = half / 2;

            int[] sum = new int[half];

            for (int p = 0; p <= 1; p++)
            {
                for (int i = 0; i < part; i++)
                {
                    int firstIndex = ((part - 1) + (-i)) + (p * (half + part));
                    int secondIndex = part + i + (p * part);
                    sum[i + (p * part)] = arr[firstIndex] + arr[secondIndex];
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            
        }
    }
}
