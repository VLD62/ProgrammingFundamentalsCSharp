
namespace Problem_3.Back_in_30_Minutes
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            if ((minute + 30) > 60)
            {
                minute = minute - 30;
                hour++;
            }
            else {
                minute = minute + 30;
            }
            if (hour > 23) {
                hour = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine(hour + ":0" + minute);
            }
            else {
                Console.WriteLine(hour + ":" + minute);
            }
            


        }
    }
}
