namespace _1.Centuries_to_Minutes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes"); 

        }
    }
}
