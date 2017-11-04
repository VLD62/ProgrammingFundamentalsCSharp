namespace _02.Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var sentences = Console.ReadLine();
            var pattern = $"[^.!?;]*(({word}\\W)|(\\W{word}\\W))[^.!?;]*";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(sentences, pattern);
            var count = 0;
            foreach (Match match in matches)
            {
                if (count == 0)
                {
                    Console.WriteLine(match.ToString());
                }
                else
                {
                    var sentence = Convert.ToString(match);
                    Console.WriteLine(sentence.Substring(1));
                }
                count++;
            }
        }
    }
}
