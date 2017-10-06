using System;


namespace _03.Printing_Triangle
{
    class Program
    {


        static void PrintHead(int a)
        {
            for (int i = 1; i < a; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


        }


        static void PrintMiddle(int a)
        {

            for (int i = 1; i <= a; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintBottom(int a)
        {
            for (int i = a - 1; i >= 0; i--)
            {


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }


        static void PrintTriangle(int a)
        {

            PrintHead(a);
            PrintMiddle(a);
            PrintBottom(a);

        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
