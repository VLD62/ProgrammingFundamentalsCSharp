namespace _01.Count_Working_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var excludeDates = new List<DateTime>();
            excludeDates.Add(new DateTime(endDate.Year, 1, 1));
            excludeDates.Add(new DateTime(endDate.Year, 3, 3));
            excludeDates.Add(new DateTime(endDate.Year, 5, 1));
            excludeDates.Add(new DateTime(endDate.Year, 5, 6));
            excludeDates.Add(new DateTime(endDate.Year, 5, 24));
            excludeDates.Add(new DateTime(endDate.Year, 9, 6));
            excludeDates.Add(new DateTime(endDate.Year, 9, 22));
            excludeDates.Add(new DateTime(endDate.Year, 11, 1));
            excludeDates.Add(new DateTime(endDate.Year, 12, 24));
            excludeDates.Add(new DateTime(endDate.Year, 12, 25));
            excludeDates.Add(new DateTime(endDate.Year, 12, 26));


            int count = 0;
            for (DateTime index = startDate; index <= endDate; index = index.AddDays(1))
            {
                if (index.DayOfWeek != DayOfWeek.Sunday && index.DayOfWeek != DayOfWeek.Saturday)
                {
                    bool excluded = false; ;
                    for (int i = 0; i < excludeDates.Count; i++)
                    {
                        if (index.Month.CompareTo(excludeDates[i].Month) == 0 && index.Day.CompareTo(excludeDates[i].Day) == 0)
                        {
                            excluded = true;
                            break;
                        }
                    }
                    if (!excluded)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
