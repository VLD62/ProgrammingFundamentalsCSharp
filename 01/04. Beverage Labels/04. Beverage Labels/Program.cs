namespace _04.Beverage_Labels
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {

            var name = Console.ReadLine();
            var volume = Double.Parse(Console.ReadLine());
            var energyContent = Double.Parse(Console.ReadLine());
            var sugarContent = Double.Parse(Console.ReadLine());

            Console.WriteLine("{1}ml {0}:", name, volume );
            Console.WriteLine("{0}kcal, {1}g sugars", (energyContent/100)*volume, (sugarContent/100)*volume);
        }
    }
}
