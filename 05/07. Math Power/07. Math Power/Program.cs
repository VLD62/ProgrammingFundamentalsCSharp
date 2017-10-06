namespace _7.Math_Power
{
    using System;
    class Program
    {
        static double getPower(double num, double pwr)
        {

            return Math.Pow(num, pwr);

        }

        static void Main(string[] args)
        {

            var num = double.Parse(Console.ReadLine());
            var pwr = double.Parse(Console.ReadLine());

            num = getPower(num, pwr);
            Console.WriteLine(num);
        }
    }
}
