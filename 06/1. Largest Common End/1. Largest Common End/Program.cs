namespace _1.Largest_Common_End
{
    using System;
    class Program
    {
        static int ArrayCounter(string[] arr1, string[] arr2) {
            int leftCounter = 0;
            int rightCounter = 0;
            int shoterArray = 0;
            if (arr1.Length > arr2.Length)
            {
                shoterArray = arr2.Length;
            }
            else {
                shoterArray = arr1.Length;
            }

            for (int i = 0; i < shoterArray; i++)
            {
                if (arr1[i] == arr2[i]) {
                    leftCounter++;
                }

                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i]) {
                    rightCounter++;
                }
            }

            if (rightCounter > leftCounter)
            {
                return rightCounter;
            }
            else {
                return leftCounter;
            }

        }

        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            Console.WriteLine(ArrayCounter(arr1, arr2));

        }
    }
}
