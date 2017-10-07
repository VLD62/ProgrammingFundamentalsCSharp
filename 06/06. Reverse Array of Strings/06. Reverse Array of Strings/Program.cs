﻿using System;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static string[] ArrayReverser(string[] arr) {

            for (int i = 0; i < arr.Length /2 ; i++)
            {
                string tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }

            return arr;
        }
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] arr2 = ArrayReverser(arr);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
