namespace _12.Rectangle_Properties
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * (width + height));
            Console.WriteLine(width * height);
            Console.WriteLine(Math.Sqrt(((width * width) + (height * height))));
        }
    }
}
