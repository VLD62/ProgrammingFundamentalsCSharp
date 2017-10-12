namespace _17.Be_Positive
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();
                List<int> numbers2 = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        numbers2.Add(currentNum);
                    }
                    else
                    {
                        if (j + 1 < numbers.Count)
                        {
                            currentNum += numbers[j + 1];
                            j++;
                        }
                       
                        if (currentNum >= 0)
                        {
                            numbers2.Add(currentNum);
                        }
                    }
                }

                if (numbers2.Count == 0)
                {
                    Console.WriteLine("(empty)");
                }
                else
                    Console.WriteLine(String.Join(" ", numbers2));

            }


        }
    }
}
