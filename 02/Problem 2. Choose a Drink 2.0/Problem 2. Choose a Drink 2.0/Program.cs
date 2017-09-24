namespace Problem_2.Choose_a_Drink_2._0
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = Double.Parse(Console.ReadLine());
            double price =0 , totalPrice = 0;

            switch (profession)
            {

                case "Athlete":
                    //Console.WriteLine("Water");
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    //Console.WriteLine("Coffee");
                    price = 1.00;
                    break;
                case "SoftUni Student":
                   //Console.WriteLine("Beer");
                    price = 1.70;
                    break;
                default:
                    //Console.WriteLine("Tea");
                    price = 1.20;
                    break;
            }
            totalPrice = price * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:0.00}.");
        }
    }
}
