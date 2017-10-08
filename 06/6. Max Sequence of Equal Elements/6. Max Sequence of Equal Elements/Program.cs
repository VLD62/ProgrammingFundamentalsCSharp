using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int count = 1;
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] == arr1[i - 1])
                {
                    count++;

                }
                else {
                    count = 1;
                }
                if (count > bestCount) {
                    bestCount = count;
                    bestIndex = i - count + 1;
                }
            }
            for (int i = bestIndex; i < bestIndex + bestCount; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
