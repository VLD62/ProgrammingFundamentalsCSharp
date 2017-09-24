namespace Problem_4.Hotel
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            double studioPrice = 0, doublePrice = 0, suitePrice = 0;

            switch (month) {
                case "May":
                case "October":
            
                    if (nights > 7)
                    {
                        if (month == "October")
                        {
                         studioPrice = ( 50 * (nights - 1)) - (50 * (nights - 1)) * 0.05;
                        } else {
                         studioPrice = ( 50 * nights ) - (50 * nights ) * 0.05;
                        }
                        
                    }
                    else {
                        studioPrice = 50 * nights;
                    }

                    doublePrice = 65 * nights;
                    suitePrice = 75 * nights;
                    break;
                case "June":
                case "September":
                    if (nights > 7)
                    {
                        if (month == "September")
                        {
                            studioPrice = (60 * (nights - 1));
                        }
                        else
                        {
                            studioPrice = 60 * nights;
                        }

                    }
                    else
                    {
                        studioPrice = 60 * nights;
                    }

                    if (nights > 14)
                    {
                        doublePrice = (72 * nights) - (72 * nights) * 0.1;
                    }
                    else
                    {
                        doublePrice = 72 * nights;
                    }
                    suitePrice = 82 * nights;
                    break;
                    
                case "July":
                case "August":
                case "December":
                    studioPrice = 68 * nights;
                    doublePrice = 77 * nights;
                    if (nights > 14)
                    {
                        suitePrice = (89 * nights) - (89 * nights) * 0.15;
                    }
                    else
                    {
                        suitePrice = 89 * nights;
                    }
                    break;
             
            }
            Console.WriteLine($"Studio: {studioPrice:0.00} lv.");
            Console.WriteLine($"Double: {doublePrice:0.00} lv.");
            Console.WriteLine($"Suite: {suitePrice:0.00} lv.");

        }
    }
}
