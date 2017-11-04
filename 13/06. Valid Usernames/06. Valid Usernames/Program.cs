﻿
namespace _06.Valid_Usernames
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            {
                string input = Console.ReadLine();
                string pattern = @"\b([A-Za-z]\w{2,24})\b";
                StringBuilder sb = new StringBuilder();
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    sb.Append(match.Value + " ");
                }
                var validUsers = sb
                    .ToString()
                    .Split(' ')
                    .ToArray();
                int sum = 0;
                int counter = 0;
                var firstValidUser = "";
                var secondValidUser = "";
                do
                {
                    var tempSum = validUsers[counter].Length + validUsers[counter + 1].Length;
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        firstValidUser = validUsers[counter];
                        secondValidUser = validUsers[counter + 1];
                    }
                    counter++;
                } while (counter + 1 != validUsers.Length);
                Console.WriteLine($"{firstValidUser}{Environment.NewLine}{secondValidUser}");
            }
        }
    }
}
