namespace _03.Miles_to_Kilometers
{
    using System;
    class Startup
    {
     
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());


            var kilometers = miles * 1.60934;

            Console.WriteLine("{0:0.00}", kilometers);
        }
    }
}
