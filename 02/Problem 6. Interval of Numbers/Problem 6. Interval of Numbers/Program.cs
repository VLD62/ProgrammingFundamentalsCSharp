namespace Problem_6.Interval_of_Numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            int lower = 0, bigger = 0;

            if (num1 > num2)
            {
                bigger = num1;
                lower = num2;
            }
            else {
                bigger = num2;
                lower = num1;
            }

            for (int i = lower; i <= bigger; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
