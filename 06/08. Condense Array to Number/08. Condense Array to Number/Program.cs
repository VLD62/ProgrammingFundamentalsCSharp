namespace _08.Condense_Array_to_Number
{
    using System;
    using System.Linq;
    class Program
    {
        static void ArrayToNumber( int[] arr) {

            for (int i = arr.Length; i > 1; i--)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j] + arr[j + 1];
                }
            }
            Console.WriteLine(arr[0]);
        }

        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ArrayToNumber(arr1);
        }
    }
}
