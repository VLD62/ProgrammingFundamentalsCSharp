namespace _5.Temperature_Conversion
{
    using System;
    class Program
    {

        static void FahrenheitToCelsius(double temp)
        {

            Console.WriteLine("{0:0.00}", ((temp - 32) * 5) / 9);

        }


        static void Main(string[] args)
        {
            var temp = double.Parse(Console.ReadLine());
            FahrenheitToCelsius(temp);
        }
    }
}
