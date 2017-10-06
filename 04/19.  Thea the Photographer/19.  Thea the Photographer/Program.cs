namespace _19.Thea_the_Photographer
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var FT = double.Parse(Console.ReadLine());
            var FF = double.Parse(Console.ReadLine());
            var UT = double.Parse(Console.ReadLine());

            double totalTime = (N * FT) + ((Math.Ceiling(N * (FF / 100))) * UT);
            TimeSpan t = TimeSpan.FromSeconds(totalTime);

            string amountOftime = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);

            Console.WriteLine(amountOftime);

        }
    }
}
