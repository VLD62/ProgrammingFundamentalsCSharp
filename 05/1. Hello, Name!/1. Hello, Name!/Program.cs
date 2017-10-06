using System;
namespace _1.Hello__Name_
{
    class Program
    {

        static void HelloPrinter(string name) {

            Console.WriteLine("Hello, " + name +"!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            HelloPrinter(name);
        }
    }
}
