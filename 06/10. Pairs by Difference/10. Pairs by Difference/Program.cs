using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                for (int j = i + i; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];

                    if (currentNum - secondNum == difference || secondNum - currentNum == difference) {
                        count++;

                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
