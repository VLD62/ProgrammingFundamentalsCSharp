namespace _02.Rectangle_area
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine()); 
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine("{0:0.00}", area);


        }
    }
}
