namespace ConsoleApplication2
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            var price = 0;

            if (day == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                }
                // TODO: Add else statement for the other group
            }

            else if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else if (day == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                // TODO: Add the statements for the other cases
            }

            if (price != 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
