namespace _7.Sum_Arrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void GetArraySum (int[] arr1, int[] arr2) {
           
            int maxArray = Math.Max(arr1.Length, arr2.Length);
            for (int i = 0; i < maxArray; i++)
            {
                int sum = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                Console.Write($"{sum} ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            GetArraySum(arr1,arr2);
            
        }
    }
}
