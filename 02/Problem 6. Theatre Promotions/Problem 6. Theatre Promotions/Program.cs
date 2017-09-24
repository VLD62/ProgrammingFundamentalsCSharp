namespace Problem_6.Theatre_Promotions
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            int price = 0;
            if (age > 0)
            {
            switch (day) {
             
                
                case "weekday":
                    if (0 >= age || age <= 18) {
                        price = 12;
                    }
                    else if (18 > age || age <= 64)
                    {
                        price = 18;
                    }
                    else if (64 > age || age <= 122)
                    {
                        price = 5;
                    }
                    else {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "weekend":
                    if (0 >= age || age <= 18)
                    {
                        price = 15;
                    }
                    else if (18 > age || age <= 64)
                    {
                        price = 20;
                    }
                    else if (64 > age || age <= 122)
                    {
                        price = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "holiday":
                    if (0 >= age || age <= 18)
                    {
                        price = 5;
                    }
                    else if (18 > age || age <= 64)
                    {
                        price = 12;
                    }
                    else if (64 > age || age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }
            Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
