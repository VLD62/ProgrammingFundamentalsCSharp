namespace _09.Index_of_Letters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettersArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] wordArray = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 0; j < lettersArray.Length; j++)
                {
                    if (wordArray[i] == lettersArray[j])
                    {
                        Console.WriteLine("{0} -> {1}", wordArray[i], j);
                    }
                }
            }
        }
    }
}
