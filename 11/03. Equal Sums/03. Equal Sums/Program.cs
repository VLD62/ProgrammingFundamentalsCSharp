using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText("Input.txt");

            int[] Array1 = contents.Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool equalSumNotFound = true;

            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {

                for (int i = 0; i <= Array1.Length - 1; i++)
                {
                    if (Array1.Length == 1)
                    {
                        outputFile.WriteLine(0);
                        equalSumNotFound = false;
                        break;
                    }
                    else
                    {
                        leftSum = 0;
                        for (int j = i; 0 < j; j--)
                        {
                            if (j > 0)
                            {
                                leftSum += Array1[j - 1];
                            }
                        }
                        rightSum = 0;
                        for (int j = i; j < Array1.Length; j++)
                        {
                            if (j < Array1.Length - 1)
                            {
                                rightSum += Array1[j + 1];
                            }
                        }

                        if (leftSum == rightSum)
                        {
                            outputFile.WriteLine(i);
                            equalSumNotFound = false;
                            break;
                        }
                    }
                }
                if (equalSumNotFound)
                {
                    outputFile.WriteLine("no");
                }
            }

        }
    }
}
