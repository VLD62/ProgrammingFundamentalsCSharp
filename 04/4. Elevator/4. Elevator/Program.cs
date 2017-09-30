namespace _4.Elevator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int courses = 0;

            if (p >= n)
            {
                courses = 1;
            }
            else {
                courses = (int)Math.Ceiling((double)(n / p));
            }

            Console.WriteLine(courses);

        }
    }
}
