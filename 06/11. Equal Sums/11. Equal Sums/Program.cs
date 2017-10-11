namespace _11.Equal_Sums
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool equalSumNotFound = true;

            for (int i = 0; i <= Array1.Length - 1; i++)
            {
                if (Array1.Length == 1)
                {
                    Console.WriteLine(0);
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
                        Console.WriteLine(i);
                        equalSumNotFound = false;
                        break;
                    }
                }
            }
            if (equalSumNotFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}
