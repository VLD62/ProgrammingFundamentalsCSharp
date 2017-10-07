namespace _7.Primes_in_Given_Range
{
    using System;
    class Program
    {
        static void FindPrimesInRange(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                int ctr = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && i != 1 && i > 0)
                {

                    if (i > 2 && i > startNum + 1)
                    {
                        Console.Write(", ");
                    }
                    Console.Write("{0}", i);

                }
            }
        }

        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);
        }
    }
}
