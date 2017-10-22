namespace _02.Index_of_Letters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText("Input.txt");

            char[] lettersArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] wordArray = contents.ToLower().ToCharArray();


            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {

                for (int i = 0; i < wordArray.Length; i++)
                {
                    for (int j = 0; j < lettersArray.Length; j++)
                    {
                        if (wordArray[i] == lettersArray[j])
                        {
                            outputFile.WriteLine("{0} -> {1}", wordArray[i], j);
                        }
                    }
                }
            }
        }
    }
}
