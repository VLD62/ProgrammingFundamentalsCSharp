using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            string contents = File.ReadAllText("C:\\Users\\Win10\\Dev\\Input.txt");

            string[] lines = contents.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            using (StreamWriter outputFile = new StreamWriter("C:\\Users\\Win10\\Dev\\Output.txt"))
            {

                for (int i = 0; i < lines.Length; i++)
                {
                    
                    if (i % 2 == 0)
                    {
                        outputFile.WriteLine(lines[i]);
                    }
                }

            }

        }
    }
}
