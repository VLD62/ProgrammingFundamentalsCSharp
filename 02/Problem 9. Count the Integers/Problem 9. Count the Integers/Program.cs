namespace Problem_9.Count_the_Integers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool infinity = true;

            while (infinity) {
                counter++;
                try
                {
                    int.Parse(Console.ReadLine());
                }
                catch {
                    break;
                }
            }
            Console.WriteLine(counter-1);
        }
    }
}
