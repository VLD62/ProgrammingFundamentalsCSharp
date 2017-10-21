using System;
using System.Collections.Generic;
using System.IO;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = File.ReadAllText("C:\\Users\\Win10\\Dev\\words.txt").ToLower();

            string[] words1 = words.Split(new string[] {Environment.NewLine,"."," ",",","-","!","?","..."},StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(words1[0]);
            //Console.WriteLine(words1[1]);
            //Console.WriteLine(words1[2]);

            string text = File.ReadAllText("C:\\Users\\Win10\\Dev\\text.txt").ToLower();
            string[] text1 = text.Split(new string[] { Environment.NewLine, ".", " ", ",", "-", "!", "?", "..." }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            for (int i = 0; i < words1.Length; i++)
            {

                for (int j = 0; j < text1.Length; j++)
                {
                    if (words1[i] == text1[j])
                    {
                        counter++;
                    }
                    
                }
                Console.WriteLine(words1[i] + " " + counter);
            }
         

        }
    }
}
