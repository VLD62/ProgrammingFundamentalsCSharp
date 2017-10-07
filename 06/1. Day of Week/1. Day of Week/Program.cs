namespace _1.Day_of_Week
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());

            try
            {
                string[] days = {"Invalid Day!",  "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday","Sunday"};

                Console.WriteLine(days[num]);
            }
            catch {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
