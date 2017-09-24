namespace Problem_10.Multiplication_Table_2._0
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var mult = int.Parse(Console.ReadLine());

            if (mult > 10)
            {
                Console.WriteLine(num + " X " + mult + " = " + (num * mult));
            }
            else {

                for (int i = mult; i <= 10; i++)
                {
                    Console.WriteLine(num + " X " + i + " = " + (num * i));
                }
            }


        }
    }
}
