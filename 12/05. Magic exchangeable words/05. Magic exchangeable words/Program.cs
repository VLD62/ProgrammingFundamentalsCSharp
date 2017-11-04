namespace _05.Magic_exchangeable_words
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var firstChars = input[0].ToCharArray().Distinct().ToArray();
            var secondChars = input[1].ToCharArray().Distinct().ToArray();
            Console.WriteLine(firstChars.Length == secondChars.Length ? "true" : "false");
        }
    }
}
