using System;


namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int [] arr = new int[lenght];

            for (int i = 0; i <= arr.Length -1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
}
