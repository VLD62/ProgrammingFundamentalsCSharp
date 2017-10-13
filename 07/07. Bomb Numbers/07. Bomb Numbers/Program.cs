namespace _7.Bomb_numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int index = numbers.IndexOf(bombArgs[0]);

            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] == bombArgs[0])
                {
                    for (int j = i - bombArgs[1]; j <= bombArgs[1] + i; j++)
                    {
                        if (j >= 0 && j <= numbers.Count - 1)
                        {
                            numbers[j] = 0;
                        }
                    }
                }

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
