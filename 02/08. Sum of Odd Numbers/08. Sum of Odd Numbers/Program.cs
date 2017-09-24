namespace _08.Sum_of_Odd_Numbers
{
    using System;
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
          
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                    if (counter <= numbers)
                    {
                    Console.WriteLine(i);
                    sum = sum + i;
                    }
                }
            }
        
            Console.WriteLine ("Sum: "+sum);

        }
    }
}
