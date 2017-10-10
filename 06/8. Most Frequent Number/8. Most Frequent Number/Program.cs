using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostFrequentNumber = 0;
            int repetitions = 0;

            for (int i = 0; i < arr1.Length; i++)
            {

                int currentNumber = arr1[i];
                int counter = 0;
                for (int j = i; j < arr1.Length; j++)
                {
                    if (currentNumber == arr1[j])
                    {

                        counter++;
                    }

                }

                if (counter > repetitions)
                {


                    mostFrequentNumber = currentNumber;
                    repetitions = counter;


                }

            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
