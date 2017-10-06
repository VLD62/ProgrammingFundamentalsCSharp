namespace _4.Draw_a_Filled_Square
{
    using System;

    class Program
    {

        static void SquareDrawerLine(int n)
        {


            Console.WriteLine(new string('-', 2 * n));
        }

        static void SquareDrawerBody(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");

        }

        static void SquareDrawer(int n)
        {


            SquareDrawerLine(n);
            for (int i = 0; i < n - 2; i++)
            {
                SquareDrawerBody(n);
            }

            SquareDrawerLine(n);
        }


        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            SquareDrawer(n);
        }
    }
}
