namespace _10.Pairs_by_Difference
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];

                    if (currentNum - secondNum == difference || secondNum - currentNum == difference)
                    {
                       
                        count++;
                        
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
