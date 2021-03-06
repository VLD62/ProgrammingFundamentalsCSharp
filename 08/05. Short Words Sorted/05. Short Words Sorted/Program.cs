﻿namespace _05.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
  
        static void Main(string[] args)
        {
            var arrayOfWords = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var smallWords = new List<string>();

            foreach (var word in arrayOfWords)
            {
                if (word.Length < 5)
                {
                    smallWords.Add(word);
                }
            }
            var result = smallWords
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}

