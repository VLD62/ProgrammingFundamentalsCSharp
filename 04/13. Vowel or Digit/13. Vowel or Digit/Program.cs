﻿namespace _13.Vowel_or_Digit
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                Console.WriteLine("digit");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }




        }
    }
}
