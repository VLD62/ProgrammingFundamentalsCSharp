namespace _02.Rotate_and_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static int[] ArrayRotator(int[] arr, int k)
        {

            int[] sumArray = new int[arr.Length];

            for (int i = 0; i < k; i++)
            {
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    
                }
              
               for (int u = 0; u < arr.Length; u++)
               {
                    sumArray[u] += arr[u];
               }
            }

            return sumArray;
        }



        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] arr2 = ArrayRotator(arr,k);

            for (int i = 0; i < arr2.Length; i++)
            {
              Console.Write(arr2[i] + " ");
            }
        }
    }
}
