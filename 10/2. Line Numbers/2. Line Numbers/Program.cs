namespace _2.Line_Numbers
{
    using System;
    using System.IO;
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
                    lines[i] = i+1 + " " + lines[i];
                    outputFile.WriteLine(lines[i]);
                }

            }
        }
    }
}
