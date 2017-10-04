namespace _11.Convert_Speed_Units
{
    using System;
    class Program
    {


        static void Main(string[] args)
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float timeOverall = hours + minutes / 60.0f + seconds / 3600.0f;

            Console.WriteLine(distance / 1000.0f / timeOverall / 3.6f);
            Console.WriteLine(distance / 1000.0f / timeOverall);
            Console.WriteLine(distance / 1609.0f / timeOverall);

        }
    }
}
