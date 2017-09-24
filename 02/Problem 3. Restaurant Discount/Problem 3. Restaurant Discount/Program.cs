namespace Problem_3.Restaurant_Discount
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallName = "Default";
            double price = 0;

            switch (package) {
                case "Normal":
                    if (groupSize <= 50)
                    {
                        price = (2500 + 500) - (2500 + 500) * 0.05;
                        hallName = "Small Hall";
                    }
                    else if (groupSize > 50 && groupSize <= 100)
                    {
                        price = (5000 + 500) - (5000 + 500) * 0.05;
                        hallName = "Terrace";
                    }
                    else if (groupSize > 100 && groupSize <= 120)
                    {
                        price = (7500 + 500) - (7500 + 500) * 0.05;
                        hallName = "Great Hall";
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                            }
                    break;
                case "Gold":
                    if (groupSize <= 50)
                    {
                        price = (2500 + 750) - (2500 + 750) * 0.1;
                        hallName = "Small Hall";
                    }
                    else if (groupSize > 50 && groupSize <= 100)
                    {
                        price = (5000 + 750) - (5000 + 750) * 0.1;
                        hallName = "Terrace";
                    }
                    else if (groupSize > 100 && groupSize <= 120)
                    {
                        price = (7500 + 750) - (7500 + 750) * 0.1;
                        hallName = "Great Hall";
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
                case "Platinum":
                    if (groupSize <= 50)
                    {
                        price = (2500 + 1000) - (2500 + 1000) * 0.15;
                        hallName = "Small Hall";
                    }
                    else if (groupSize > 50 && groupSize <= 100)
                    {
                        price = (5000 + 1000) - (5000 + 1000) * 0.15;
                        hallName = "Terrace";
                    }
                    else if (groupSize > 100 && groupSize <= 120)
                    {
                        price = (7500 + 1000) - (7500 + 1000) * 0.15;
                        hallName = "Great Hall";
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
            }

            if (price > 0) {
                price = price / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:0.00}$");
            }
        }
    }
}
