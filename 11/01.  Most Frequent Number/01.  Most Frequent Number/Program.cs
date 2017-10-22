

namespace _01.Most_Frequent_Number
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

            string contents = File.ReadAllText("C:\\Users\\Win10\\Dev\\Input.txt");

            int[] numbers = contents.Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int number = 0;
            int maxCounter = 0;
            bool max = false;



            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !max)
                    {
                        counter++;

                        if (counter > maxCounter)
                        {
                            number = numbers[i];
                            maxCounter = counter;
                            max = true;
                        }
                        else
                        {
                            counter = 0;
                        }

                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter("C:\\Users\\Win10\\Dev\\Output.txt"))
            {
                outputFile.WriteLine(number);
            }
        }
    }
}
