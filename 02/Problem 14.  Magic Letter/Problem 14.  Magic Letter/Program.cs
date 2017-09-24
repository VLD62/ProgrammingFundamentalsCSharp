namespace Problem_14.Magic_Letter
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {

                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        string currentSequence = "" + i + j + k;
                        if (!currentSequence.Contains(skipLetter + "")) {
                            Console.Write(currentSequence + " ");
                        }
                    }
                }
            }
          

        }
    }
}
